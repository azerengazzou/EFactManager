using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IMessageRepository : IRepository<MessageEntity>
    {
        Task<MessageEntity> UpdateAsync(MessageEntity entity);
        MessageEntity GetMessageByCode(string code);
    }
}
