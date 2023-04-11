using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;

namespace EFactManagerAPI.Repository
{
    public class FieldRepository : Repository<FieldEntity>, IFieldRepository
    {
        private readonly ApplicationDbContext _db;
        public FieldRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
