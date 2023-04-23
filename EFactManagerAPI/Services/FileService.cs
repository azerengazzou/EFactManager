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
                if (filepath != null)
                {
                    await SplitBodyContentAsync(filepath, message.id, modeltodb.id, modeltodb);
                }

                return modeltodb;
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
                Console.WriteLine("Problème de création fichier: "+ e.ToString());
                throw;
            }
        }

        //public async Task SplitBodyContentAsync(string filePath, int messageId, int fileId, EfactFile filemodel)
        //{
        //    var records = await _recordRepository.GetRecordsByMessageIdAsync(messageId);
        //    List<RecordConfig> bodyAndFooterRecords = records.Where(r => r.recordPlacement != "header").ToList();
        //    List<string> lines = new List<string>();
        //    int recordLength = 0;

        //    using (StreamReader reader = new StreamReader(filePath))
        //    {
        //        string contentToSplit = await reader.ReadToEndAsync();

        //        string header = contentToSplit.Substring(0, 227);
        //        string restOfFile = contentToSplit.Substring(227);

        //        while (restOfFile.Length > 0)
        //        {
        //            string recordStartNumber = restOfFile.Substring(0, 2);

        //            var specificRec = bodyAndFooterRecords.FirstOrDefault(r => r.recordNumber == recordStartNumber);
        //            if (specificRec != null)
        //            {
        //                var zones = await _zoneRepository.GetZonesByRecordIdAsync(specificRec.id);
        //                recordLength = specificRec.recordLength;
        //                var recordSplit = restOfFile.Substring(0, recordLength);
        //                restOfFile = restOfFile.Substring(recordLength);

        //                if (zones != null)
        //                {
        //                    foreach (ZoneConfig zone in zones)
        //                    {
        //                        var start = zone.startPosition - 1;
        //                        if (start + zone.zonelength > recordSplit.Length)
        //                        {
        //                            throw new Exception("Zone length is greater than record length.");
        //                        }

        //                        var zonesplit = recordSplit.Substring(start, zone.zonelength);

        //                        var contentModel = new ZoneContentCreateDTO
        //                        {
        //                            content = zonesplit,
        //                            description = zone.description,
        //                        };

        //                        var field = new FieldCreateDTO
        //                        {
        //                            FileId = filemodel.id,
        //                            ZoneConfigId = zone.id,
        //                        };

        //                        contentModel.Field = field;

        //                        ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
        //                        await _factFileContentRepository.CreateAsync(contentModeltoDB);

        //                        //field.ZoneContent = contentModel;
        //                        //Field fieldtoDB = _mapper.Map<Field>(field);
        //                        //await _fieldRepository.CreateAsync(fieldtoDB);

        //                        Console.WriteLine(field);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        public async Task SplitBodyContentAsync(string filePath, int messageId, int fileId, EfactFile filemodel)
        {
            var records = await _recordRepository.GetRecordsByMessageIdAsync(messageId);
            List<RecordConfig> bodyAndFooterRecords = records.Where(r => r.recordPlacement != "header").ToList();
            List<string> lines = new List<string>();
            int recordLength = 0;
            var zoneContentList = new List<ZoneContent>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string contentToSplit = await reader.ReadToEndAsync();

                    string header = contentToSplit.Substring(0, 227);
                    string restOfFile = contentToSplit.Substring(227);

                    while (restOfFile.Length > 0)
                    {
                        string recordStartNumber = restOfFile.Substring(0, 2);

                        var specificRec = bodyAndFooterRecords.FirstOrDefault(r => r.recordNumber == recordStartNumber);
                        if (specificRec != null)
                        {
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
                                    };

                                    contentModel.Field = field;

                                    ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
                                    zoneContentList.Add(contentModeltoDB);
                                }
                            }
                        }
                    }
                }
                await _factFileContentRepository.CreateZoneContentsAsync(zoneContentList);
            }
            catch(Exception ex)
            {
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

            //Première décomposition de fichier: header-body-footer
            //public bool SplitContentIntoFileStructure(string content,string nameFile)
            //{
            //    int maxLineLength = 350;
            //    string[] lines = new string[] { content.Substring(0, 227) };
            //    string[] linesFooter = new string[] {};
            //    string timer = DateTime.Now.Microsecond.ToString();
            //    string dateTimeWithoutSpaces = createDateForFileUse();
            //    string directoryPath = Path.Combine(@"E:\CorilusFormation_23\", "GestionFichier_Facturation_Corilus", "backfiles",dateTimeWithoutSpaces+ timer+nameFile);

            //    DirectoryCreation(directoryPath);
            //    var fileHeaderName = "Header" + dateTimeWithoutSpaces+timer+ ".txt";
            //    var fileBodyName = "Body" + dateTimeWithoutSpaces+timer+ ".txt";
            //    var fileFooterName = "Footer" + dateTimeWithoutSpaces + timer + ".txt";
            //    try
            //    {
            //        File.WriteAllLines(directoryPath + @"\" + fileHeaderName, lines);
            //        lines = new string[] { };
            //        content = content.Substring(227);
            //        while (content.Length > 0)
            //        {
            //            if (!(content.StartsWith("90") | content.StartsWith("95") | content.StartsWith("96")))
            //            {
            //                lines = lines.Concat(new string[] { content.Substring(0, maxLineLength) }).ToArray();
            //                content = content.Substring(maxLineLength);
            //                File.WriteAllLines(directoryPath + @"\" + fileBodyName, lines);
            //            }
            //            else
            //            {
            //                linesFooter = linesFooter.Concat(new string[] { content.Substring(0, maxLineLength) }).ToArray();
            //                content = content.Substring(maxLineLength);

            //                File.WriteAllLines(directoryPath + @"\" + fileFooterName, linesFooter);
            //            }
            //        }

            //        return true;
            //    }
            //    catch(Exception e)
            //    {
            //        return false;
            //    }

            //}
        }
    }
