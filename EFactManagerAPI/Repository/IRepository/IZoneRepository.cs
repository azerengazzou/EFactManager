using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IZoneRepository : IRepository<ZoneConfig>
    {
        Task<ZoneConfig> UpdateAsync(ZoneConfig entity);
        Task<List<ZoneConfig>> GetZonesByRecordIdAsync(int recordId);
    }
}
