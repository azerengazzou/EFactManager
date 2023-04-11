using EFactManagerAPI.Models;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EFactManagerAPI.Services.IServices
{
    public interface IFileService 
    {
        Task<FileEntity> CreateFileService(IFormFile file);
    }
}
