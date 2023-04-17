using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFactManagerAPI.Repository
{
    public class RecordRepository : Repository<RecordConfig>, IRecordRepository
    {
        private readonly ApplicationDbContext _db;
        public RecordRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<RecordConfig> UpdateAsync(RecordConfig entity)
        {
            entity.dateUpdate = DateTime.Now;
            _db.Records.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<List<RecordConfig>> GetRecordsByMessageIdAsync(int messageId)
        {
            // Eager load the Zones collection for each RecordEntity
            var records = await _db.Records.Where(m=>m.MessageTypeId == messageId).ToListAsync();
            return records;
        }

    }
}
