using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IZoneErrorRepository: IRepository<ZoneError>
    {
        Task AddErrorsFromFileAsync(IEnumerable<ZoneError> listFromFile);
        Task<ZoneError> GetErrorWithCode(string codeError);
    }
}
