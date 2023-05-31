using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFactManagerAPI.Repository
{
    public class ZoneRepository : Repository<ZoneConfig>, IZoneRepository
    {
        private readonly ApplicationDbContext _db;
        public ZoneRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<ZoneConfig> UpdateAsync(ZoneConfig entity)
        {
            entity.dateUpdate = DateTime.Now;
            _db.Zones.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<List<ZoneConfig>> GetZonesByRecordIdAsync(int recordId)
        {
            // Eager load the Zones collection for each RecordEntity
            var zones = await _db.Zones.Where(r => r.RecordConfigId == recordId).ToListAsync();
            return zones;
        }
    }
}
