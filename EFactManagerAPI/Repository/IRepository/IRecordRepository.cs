using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IRecordRepository : IRepository<RecordConfig>
    {
        Task<RecordConfig> UpdateAsync(RecordConfig entity);
        //Task<List<RecordConfig>> GetRecordsByField(int fieldId);
        //Task<List<RecordEntity>> GetAllRecordsWithZonesAsync();
        Task<List<RecordConfig>> GetRecordsByMessageIdAsync(int messageId);
    }
}
