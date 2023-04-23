using EFactManagerAPI.Models;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EFactManagerAPI.Services.IServices
{
    public interface IFileService 
    {
        Task<EfactFile> CreateFileService(IFormFile file);
        Task SplitBodyContentAsync(string contentToSplit, int messageId, int fileId, EfactFile filemodel);
    }
}
