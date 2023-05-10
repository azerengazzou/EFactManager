using EFactManagerAPI.Models;

namespace EFactManagerAPI.Services.IServices
{
    public interface ISplitFileNoErrorService
    {
        Task SplitHeaderContentAsync(List<RecordConfig> records, string headerToSpllt, int fileId, EfactFile filemodel);
        Task SplitBodyContentAsync(string filePath, List<RecordConfig> records, int fileId, EfactFile filemodel);
    }
}
