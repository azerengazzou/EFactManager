using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFactManagerAPI.Repository
{
    public class RecordRepository : Repository<RecordEntity>, IRecordRepository
    {
        private readonly ApplicationDbContext _db;
        public RecordRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<RecordEntity> UpdateAsync(RecordEntity entity)
        {
            entity.dateUpdate = DateTime.Now;
            _db.Records.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //public async Task<List<RecordEntity>> GetAllRecordsWithZonesAsync()
        //{
        //    // Eager load the Zones collection for each RecordEntity
        //    var recordsWithZones = await _db.Records
        //        .Include(r => r.Zones)
        //        .ToListAsync();
        //    return recordsWithZones;
        //}

        //public Task<List<RecordEntity>> GetRecordsByMessageIdAsync(int msgId)
        //{
        //    // Eager load the Zones collection for each RecordEntity
        //    var recordsWithZones = _db.Records
        //        .Include(r => r.Zones).Where(m=>m.messageId==msgId)
        //        .ToListAsync();
        //    return recordsWithZones;
        //}
    }
}
