using EFactManagerAPI.Models;
using System.Linq.Expressions;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IFileRepository : IRepository<EfactFile>
    {
        Task<EfactFile> UpdateAsync(EfactFile entity);
    }
}
