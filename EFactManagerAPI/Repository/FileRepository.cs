using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Models.Dto.FilesDTO;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace EFactManagerAPI.Repository
{
    public class FileRepository : Repository<EfactFile>,IFileRepository
    {
        private readonly ApplicationDbContext _db;
        public FileRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<EfactFile> UpdateAsync(EfactFile entity)
        {
            entity.update_date = DateTime.Now;
            _db.Files.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<EfactFile> GetFileById(int id)
        {
            var filedata=await _db.Files.FirstOrDefaultAsync(fi => fi.id == id);
            if (filedata != null)
            {
                return filedata;
            }
            return null;
        }

    }
}
