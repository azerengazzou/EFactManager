using EFactManagerAPI.Models;

namespace EFactManagerAPI.Repository.IRepository
{
    public interface IMessageRepository : IRepository<MessageType>
    {
        Task<MessageType> UpdateAsync(MessageType entity);
        MessageType GetMessageByCode(string code);
        Task<MessageType> GetMessageByIdWithRecords(int messageId);
    }
}
