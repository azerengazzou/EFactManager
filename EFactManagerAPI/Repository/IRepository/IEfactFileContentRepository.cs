using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IEfactFileContentRepository : IRepository<ZoneContent>
    {
        Task<ZoneContent> UpdateAsync(ZoneContent entity);
    }
}
