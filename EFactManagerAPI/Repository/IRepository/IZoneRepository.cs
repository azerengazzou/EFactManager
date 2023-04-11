using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IZoneRepository : IRepository<ZoneEntity>
    {
        Task<ZoneEntity> UpdateAsync(ZoneEntity entity);
    }
}
