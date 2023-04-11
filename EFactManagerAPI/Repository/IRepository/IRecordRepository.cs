using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IRecordRepository : IRepository<RecordEntity>
    {
        Task<RecordEntity> UpdateAsync(RecordEntity entity);
        //Task<List<RecordEntity>> GetAllRecordsWithZonesAsync();
        //Task<List<RecordEntity>> GetRecordsByMessageIdAsync(int msgId);
    }
}
