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
            _zoneRepository= zoneRepository;
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
            if(message == null) { return null; } else
            {
                EfactFile modeltodb = _mapper.Map<EfactFile>(filemodel);
                await _dbfile.CreateAsync(modeltodb);
                
                filemodel.Description = message.description;
                BackUpFileCreation(file);
                splitbodycontent(fileContent, message.id, modeltodb.id,modeltodb);
                return modeltodb;
            }

        }


        //Sauvegarde d'un fichier conforme sur le disque "serveur"
        public bool BackUpFileCreation(IFormFile file)
        {
            try
            {
                string dateTimeWithoutSpaces = createDateForFileUse();
                string timer=DateTime.Now.Microsecond.ToString();
                string filePath = Path.Combine(@"E:\CorilusFormation_23\", "GestionFichier_Facturation_Corilus", "backfiles", dateTimeWithoutSpaces+timer+ file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async void splitbodycontent(string contentToSplit, int messageId,int fileId,EfactFile filemodel)
        {
            var records = _recordRepository.GetRecordsByMessageIdAsync(messageId).Result;
            List<RecordConfig> bodyrecords = records.Where(r => r.recordPlacement == "body").ToList();
            string header = contentToSplit.Substring(0, 227);
            string restOfFile = contentToSplit.Substring(227);
            List<string> lines = new List<string>();
            int recordLength = 0;

            while (restOfFile.Length >= 0)
            {
                string recordStartNumber = restOfFile.Substring(0, 2);
                var specificRec = bodyrecords.FirstOrDefault(r => r.recordNumber == recordStartNumber);
                var zones = _zoneRepository.GetZonesByRecordIdAsync(specificRec.id).Result;
                recordLength = specificRec.recordLength;
                var recordSplit = restOfFile.Substring(0,recordLength);
                restOfFile = restOfFile.Substring(recordLength);


                foreach (ZoneConfig zone in zones)
                {
                    var zonesplit = recordSplit.Substring(zone.startPosition - 1, zone.zonelength);

                    var contentModel = new ZoneContentCreateDTO
                    {
                        content = zonesplit,
                        description = zone.description,
                    };

                    var field = new Field
                    {
                        File = filemodel,
                        ZoneConfig = zone,
                        FileId = filemodel.id,
                    };
                    contentModel.Field = field;

                    // First create the zone content
                    ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
                   await _factFileContentRepository.CreateAsync(contentModeltoDB);

                    // Then assign the zone content to the field
                    field.ZoneContent = contentModeltoDB;
                    // Finally, create the field with the assigned zone content
                    // Field fieldModeltoDB = _mapper.Map<Field>(field);
                    // await _fieldRepository.CreateAsync(fieldModeltoDB);
                    Console.WriteLine(field);
                    recordSplit = recordSplit.Substring(zone.zonelength);

                    if (recordLength == 0)
                    {
                        break;
                    }
                }
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
            {   Directory.CreateDirectory(directoryPath); }
            else
            {   return false; }
            return true;
        }

        //Première décomposition de fichier: header-body-footer
        public bool SplitContentIntoFileStructure(string content,string nameFile)
        {
            int maxLineLength = 350;
            string[] lines = new string[] { content.Substring(0, 227) };
            string[] linesFooter = new string[] {};
            string timer = DateTime.Now.Microsecond.ToString();
            string dateTimeWithoutSpaces = createDateForFileUse();
            string directoryPath = Path.Combine(@"E:\CorilusFormation_23\", "GestionFichier_Facturation_Corilus", "backfiles",dateTimeWithoutSpaces+ timer+nameFile);

            DirectoryCreation(directoryPath);
            var fileHeaderName = "Header" + dateTimeWithoutSpaces+timer+ ".txt";
            var fileBodyName = "Body" + dateTimeWithoutSpaces+timer+ ".txt";
            var fileFooterName = "Footer" + dateTimeWithoutSpaces + timer + ".txt";
            try
            {
                File.WriteAllLines(directoryPath + @"\" + fileHeaderName, lines);
                lines = new string[] { };
                content = content.Substring(227);
                while (content.Length > 0)
                {
                    if (!(content.StartsWith("90") | content.StartsWith("95") | content.StartsWith("96")))
                    {
                        lines = lines.Concat(new string[] { content.Substring(0, maxLineLength) }).ToArray();
                        content = content.Substring(maxLineLength);
                        File.WriteAllLines(directoryPath + @"\" + fileBodyName, lines);
                    }
                    else
                    {
                        linesFooter = linesFooter.Concat(new string[] { content.Substring(0, maxLineLength) }).ToArray();
                        content = content.Substring(maxLineLength);

                        File.WriteAllLines(directoryPath + @"\" + fileFooterName, linesFooter);
                    }
                }

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            
        }

    }
}
