using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IZoneContentRepository : IRepository<ZoneContentEntity>
    {
        Task<ZoneContentEntity> UpdateAsync(ZoneContentEntity entity);
    }
}
