using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IFieldRepository:IRepository<Field>
    {
        Task<List<Field>> GetFieldsByFileId(int fileid);
        //Task<List<Field>> GetAllFieldsWithAllElements();
        //Task<List<Field>> GetAllFieldsWithMessageID(int idmessage);
    }
}
