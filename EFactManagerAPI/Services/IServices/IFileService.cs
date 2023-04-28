using EFactManagerAPI.Models;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EFactManagerAPI.Services.IServices
{
    public interface IFileService 
    {
        Task<EfactFile> CreateFileService(IFormFile file);
        Task SplitBodyContentAsync(string filePath, List<RecordConfig> records, int fileId, EfactFile filemodel);
        Task SplitHeaderContentAsync(List<RecordConfig> records, string header, int fileId, EfactFile filemodel);
    }
}
