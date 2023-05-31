
using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFactManagerAPI.Repository
{
    public class ZoneErrorRepository : Repository<ZoneError>, IZoneErrorRepository
    {
        private readonly ApplicationDbContext _db;
        public ZoneErrorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task AddErrorsFromFileAsync(IEnumerable<ZoneError> listFromFile)
        {
            await DbSet.AddRangeAsync(listFromFile);
            await Save();
        }

        public async Task<ZoneError> GetErrorWithCode(string codeError)
        {
            var errorDetails = await _db.ZoneErrors.FirstOrDefaultAsync(z => z.codeError.Equals(codeError));
            return errorDetails;
        }
    }
}
