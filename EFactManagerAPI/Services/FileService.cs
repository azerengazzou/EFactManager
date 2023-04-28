using AutoMapper;
using EFactManagerAPI.Controllers;
using EFactManagerAPI.Models;
using EFactManagerAPI.Models.Dto.FieldsDTO;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Models.Dto.ZonesContentDTO;
using EFactManagerAPI.Repository.IRepository;
using EFactManagerAPI.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace EFactManagerAPI.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _dbfile;
        private readonly IMessageRepository _messageRepository;
        private readonly IRecordRepository _recordRepository;
        private readonly IFieldRepository _fieldRepository;
        private readonly IZoneRepository _zoneRepository;
        private readonly IEfactFileContentRepository _factFileContentRepository;
        private readonly IMapper _mapper;
        public FileService(IFileRepository fileRepository,
                            IRecordRepository recordRepository, IMessageRepository messageRepository, IZoneRepository zoneRepository,
                            IEfactFileContentRepository factFileContentRepository,
                            IMapper mapper, IFieldRepository fieldRepository)
        {
            _mapper = mapper;
            _dbfile = fileRepository;
            _recordRepository = recordRepository;
            _messageRepository = messageRepository;
            _fieldRepository = fieldRepository;
            _zoneRepository = zoneRepository;
            _factFileContentRepository = factFileContentRepository;
        }



        public async Task<EfactFile> CreateFileService(IFormFile file)
        {
            //préparation de modèle fichier
            var fileContent = new StreamReader(file.OpenReadStream()).ReadToEnd();
            var filemodel = new FileCreateDTO
            {
                fileName = file.FileName,
                size = file.Length,
                Description = "Unknown type of file",
                fileUploadedContent = fileContent,
                upload_date = DateTime.Now,
                update_date = DateTime.Now
            };

            var code = fileContent.Substring(0, 6);
            var message = _messageRepository.GetMessageByCode(code);

            if (message == null) { return null; } else
            {
                filemodel.Description = message.description;
                EfactFile modeltodb = _mapper.Map<EfactFile>(filemodel);
                await _dbfile.CreateAsync(modeltodb);
                var filepath=BackUpFileCreation(file);

                var records = await _recordRepository.GetRecordsByMessageIdAsync(message.id);

                if (filepath != null)
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {

                        string contentToSplit = await reader.ReadToEndAsync();
                        string header = contentToSplit.Substring(0, 227);
                        string restOfFile = contentToSplit.Substring(227);


                        await SplitHeaderContentAsync(records, header, modeltodb.id, modeltodb);
                        await SplitBodyContentAsync(filepath, records, modeltodb.id, modeltodb);
                    }
                }

                return modeltodb;
            }
        }

        public async Task SplitHeaderContentAsync(List<RecordConfig> records,string headerToSpllt, int fileId, EfactFile filemodel)
        {
            List<RecordConfig> headerRecords = records.Where(r => r.recordPlacement.Equals("header")).ToList();

            int headerRecordLength = 0;
            int recordLength = 0;
            int startpos = 0;
            var header = headerToSpllt;
            var zoneContentList = new List<ZoneContent>();
            
            var headerStartRecord = headerRecords.FirstOrDefault(h => h.recordNumber.Equals(header.Substring(0, 6)));
            var headerZones = await _zoneRepository.GetZonesByRecordIdAsync(headerStartRecord.id);

            try
            {
                foreach (RecordConfig headerRecordsConfig in headerRecords)

                    if (headerRecordsConfig.recordLength == headerStartRecord.recordLength)
                    {
                        headerRecordLength = headerStartRecord.recordLength;
                        var headerRecordSplit = header.Substring(0, headerRecordLength);
                        foreach (ZoneConfig zoneHeader in headerZones)
                        {
                            var zoneHeaderSplit = headerRecordSplit.Substring(startpos, zoneHeader.zonelength);
                            startpos = (startpos + zoneHeader.zonelength)-1;
                            
                            var contentModel = new ZoneContentCreateDTO
                                {
                                    content = zoneHeaderSplit,
                                    description = zoneHeader.description,
                                };

                                var field = new FieldCreateDTO
                                {
                                    FileId = filemodel.id,
                                    ZoneConfigId = zoneHeader.id,
                                };

                                contentModel.Field = field;
                                ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
                                zoneContentList.Add(contentModeltoDB);
                           
                        }
                        header=header.Substring(headerRecordLength,header.Length- headerRecordLength);
                        // header = header.Substring(headerRecordLength-1, 227);
                    }
                    else
                    {
                        var recordSplit = header.Substring(0, headerRecordsConfig.recordLength);
                        headerZones = await _zoneRepository.GetZonesByRecordIdAsync(headerRecordsConfig.id);
                        foreach (ZoneConfig zoneHeader in headerZones)
                        {
                            if (startpos + zoneHeader.zonelength > recordSplit.Length)
                            {
                                throw new Exception("Zone length is greater than record length.");
                            }

                            var zoneHeaderSplit = recordSplit.Substring(startpos, zoneHeader.zonelength);

                            var contentModel = new ZoneContentCreateDTO
                            {
                                content = zoneHeaderSplit,
                                description = zoneHeader.description,
                            };

                            var field = new FieldCreateDTO
                            {
                                FileId = filemodel.id,
                                ZoneConfigId = zoneHeader.id,
                            };

                            contentModel.Field = field;

                            ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
                            zoneContentList.Add(contentModeltoDB);
                        }
                        if (header.Length != 0 & headerRecords.Last() == headerRecordsConfig)
                        {
                            await _factFileContentRepository.CreateZoneContentsAsync(zoneContentList);
                            break;
                        }
                    }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
       


        public async Task SplitBodyContentAsync(string filePath, List<RecordConfig> records, int fileId, EfactFile filemodel)
        {
            
            List<RecordConfig> bodyAndFooterRecords = records.Where(r => r.recordPlacement != "header").ToList();
            int recordLength = 0;
            var zoneContentList = new List<ZoneContent>();

            int numAttestation = 0;
            int numPrestation = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string contentToSplit = await reader.ReadToEndAsync();
                    string header = contentToSplit.Substring(0, 227);
                    string restOfFile = contentToSplit.Substring(227);

                    try
                    {
                        while (restOfFile.Length > 0)
                        {
                            string recordStartNumber = restOfFile.Substring(0, 2);

                            var specificRec = bodyAndFooterRecords.FirstOrDefault(r => r.recordNumber == recordStartNumber);
                            if (specificRec != null)
                            {
                                switch (recordStartNumber)
                                {
                                    case "20":
                                        numAttestation++;
                                        numPrestation = 0;
                                        break;
                                    case "50":
                                        numPrestation++;
                                        break;
                                    case "51":
                                        break;
                                    case "80":
                                        numPrestation = 0;
                                        break;
                                    default:
                                        numAttestation = 0;
                                        numPrestation = 0;
                                        break;
                                }

                                var zones = await _zoneRepository.GetZonesByRecordIdAsync(specificRec.id);
                                recordLength = specificRec.recordLength;
                                var recordSplit = restOfFile.Substring(0, recordLength);
                                restOfFile = restOfFile.Substring(recordLength);

                                if (zones != null)
                                {
                                    foreach (ZoneConfig zone in zones)
                                    {
                                        var start = zone.startPosition - 1;
                                        if (start + zone.zonelength > recordSplit.Length)
                                        {
                                            throw new Exception("Zone length is greater than record length.");
                                        }

                                        var zonesplit = recordSplit.Substring(start, zone.zonelength);

                                        var contentModel = new ZoneContentCreateDTO
                                        {
                                            content = zonesplit,
                                            description = zone.description,
                                        };

                                        var field = new FieldCreateDTO
                                        {
                                            FileId = filemodel.id,
                                            ZoneConfigId = zone.id,
                                            numAttestation = numAttestation,
                                            numPrestation=numPrestation,
                                        };

                                        contentModel.Field = field;

                                        ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
                                        zoneContentList.Add(contentModeltoDB);
                                    }
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                   
                }
                await _factFileContentRepository.CreateZoneContentsAsync(zoneContentList);
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }

        //Sauvegarde d'un fichier conforme sur le disque "serveur"
        public string BackUpFileCreation(IFormFile file)
        {
            try
            {
                string dateTimeWithoutSpaces = createDateForFileUse();
                string timer = DateTime.Now.Microsecond.ToString();
                string filePath = Path.Combine(@"E:\CorilusFormation_23\", "GestionFichier_Facturation_Corilus", "backfiles", dateTimeWithoutSpaces + timer + file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                }
                return filePath;
            }
            catch (Exception e)
            {
                Console.WriteLine("Problème de création fichier: " + e.ToString());
                throw;
            }
        }

            public string createDateForFileUse()
            {
                DateTime dateTime = DateTime.Now;
                string formattedDateTime = dateTime.ToString("MM-dd-yyyy hh-mm-ss tt"); // example formatted string
                string dateTimeWithoutSpaces = formattedDateTime.Replace(" ", ""); // remove spaces
                return dateTimeWithoutSpaces;
            }

            public bool DirectoryCreation(string directoryPath)
            {
                if (!Directory.Exists(directoryPath))
                { Directory.CreateDirectory(directoryPath); }
                else
                { return false; }
                return true;
            }
        }
    }
