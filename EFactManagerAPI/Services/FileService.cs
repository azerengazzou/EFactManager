using AutoMapper;
using EFactManagerAPI.Controllers;
using EFactManagerAPI.Models;
using EFactManagerAPI.Models.Dto.FilesDTO;
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
        private readonly IMapper _mapper;
        public FileService(IFileRepository fileRepository, IRecordRepository recordRepository, IMessageRepository messageRepository,IMapper mapper)
        {
            _dbfile = fileRepository;
            _mapper = mapper;
            _messageRepository = messageRepository;
            _recordRepository = recordRepository;
        }



        public async Task<FileEntity> CreateFileService(IFormFile file)
        {
            //préparation de modèle fichier
            var fileContent = new StreamReader(file.OpenReadStream()).ReadToEnd();
            var model = new FileCreateDTO
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
            if (!(message==null))
            { model.Description = message.description; }
            
            BackUpFileCreation(file);

            //splitbodycontent(fileContent, message.id);
            
            //SplitContentIntoFileStructure(fileContent, model.fileName);
            FileEntity modeltodb = _mapper.Map<FileEntity>(model);
            await _dbfile.CreateAsync(modeltodb);
            return modeltodb;

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



        public void splitbodycontent(string content, int messageId)
        {

            //var records = _recordRepository.GetRecordsByMessageIdAsync(messageId).Result;
            //List<RecordEntity> bodyrecords = records.Where(r => r.recordPlacement == "body").ToList();
            
            //string header = content.Substring(0, 227);
            //string restOfFile = content.Substring(227);
            //List<string> lines = new List<string>();
            //int recordLength = 0;

            //while (restOfFile.Length >= 0)
            //{
            //    string recStartDetect = restOfFile.Substring(0, 2);
            //    var specificRec =bodyrecords.FirstOrDefault(r=>r.recordValue == recStartDetect);

            //    recordLength = specificRec.recordLength;
            //    var zonesOfRecord = specificRec.Zones;
            //    var record = restOfFile.Substring(0,recordLength);
            //    restOfFile = restOfFile.Substring(recordLength);

            //    foreach (ZoneEntity zone in zonesOfRecord)
            //    {
            //        var zonesplit = record.Substring(zone.startPosition - 1, zone.zonelength);
            //        lines.Add(zonesplit+"= "+zone.zoneSection);
            //        record.Substring(recordLength - zone.zonelength);
            //        if (recordLength == 0)
            //        {
            //            break;
            //        }
            //    }
            //}
           
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
