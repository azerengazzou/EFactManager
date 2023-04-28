using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFactManagerAPI.Repository
{
    public class FieldRepository : Repository<Field>, IFieldRepository
    {
        private readonly ApplicationDbContext _db;

        public FieldRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<Field>> GetFieldsByFileId(int fileid)
        {
            var fields = await _db.Fields
       .Where(f => f.FileId == fileid)
       .Include(f => f.ZoneContent) // Include FieldContent
       .Include(zc => zc.ZoneConfig)
           .ThenInclude(rc => rc.RecordConfig)
       .ToListAsync();

            return fields;
        }
    }
}
