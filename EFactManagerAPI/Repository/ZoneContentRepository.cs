using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;

namespace EFactManagerAPI.Repository
{
    public class ZoneContentRepository : Repository<ZoneContentEntity>, IZoneContentRepository
    {
        private readonly ApplicationDbContext _db;
        public ZoneContentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<ZoneContentEntity> UpdateAsync(ZoneContentEntity entity)
        {
            _db.ZoneContents.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
