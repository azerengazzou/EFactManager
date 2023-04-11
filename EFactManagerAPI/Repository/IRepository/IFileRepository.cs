using EFactManagerAPI.Models;
using System.Linq.Expressions;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IFileRepository : IRepository<FileEntity>
    {
        Task<FileEntity> UpdateAsync(FileEntity entity);
    }
}
