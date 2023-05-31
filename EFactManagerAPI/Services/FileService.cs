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
        private readonly IBackUpFileService _backUpFileService;
        private readonly ISplitFileNoErrorService _splitFileNoErrorService;
        private readonly ISplitFileErrorService _splitFileErrorService;

        private readonly IMapper _mapper;
        public FileService( IFileRepository fileRepository,IRecordRepository recordRepository,
                            IMessageRepository messageRepository,
                            ISplitFileNoErrorService splitFileNoErrorService,
                            ISplitFileErrorService splitFileErrorService,
                           IBackUpFileService backUpFileService,
                            IMapper mapper)
        {
            _mapper = mapper;
            _dbfile = fileRepository;
            _recordRepository = recordRepository;
            _messageRepository = messageRepository;
            _splitFileNoErrorService= splitFileNoErrorService;
            _splitFileErrorService=splitFileErrorService;
            _backUpFileService = backUpFileService;
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
                

                var filepath= _backUpFileService.BackUpFileCreation(file);

                await _dbfile.CreateAsync(modeltodb);
                var records = await _recordRepository.GetRecordsByMessageIdAsync(message.id);
                var headerRecords = records.Where(hrec => hrec.recordPlacement.Equals("header"));

                if (code.Equals("920000"))
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        string contentToSplit = await reader.ReadToEndAsync();
                        string header = contentToSplit.Substring(0, 227);
                        string restOfFile = contentToSplit.Substring(227);

                        await _splitFileNoErrorService.SplitHeaderContentAsync(records, header, modeltodb.id, modeltodb);
                        await _splitFileNoErrorService.SplitBodyContentAsync(filepath, records, modeltodb.id, modeltodb);
                    }
                }
                else
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        string contentToSplit = await reader.ReadToEndAsync();
                        string header = contentToSplit.Substring(0, 677);
                        string restOfFile = contentToSplit.Substring(677);
                        await _splitFileErrorService.SplitHeaderContentAsync(records, header, modeltodb.id, modeltodb);
                        await _splitFileErrorService.SplitBodyContentAsync(filepath, records, modeltodb.id, modeltodb);
                    }
                }

                return modeltodb;
            }
        }

    }
}
