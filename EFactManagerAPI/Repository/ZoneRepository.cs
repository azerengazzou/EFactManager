using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;

namespace EFactManagerAPI.Repository
{
    public class ZoneRepository : Repository<ZoneEntity>, IZoneRepository
    {
        private readonly ApplicationDbContext _db;
        public ZoneRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<ZoneEntity> UpdateAsync(ZoneEntity entity)
        {
            entity.dateUpdate = DateTime.Now;
            _db.Zones.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}
