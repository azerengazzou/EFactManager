using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFactManagerAPI.Repository
{
    public class MessageRepository : Repository<MessageType>, IMessageRepository
    {
        private readonly ApplicationDbContext _db;
        public MessageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<MessageType> UpdateAsync(MessageType entity)
        {
            entity.dateUpdate = DateTime.Now;
            _db.Messages.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public MessageType GetMessageByCode(string code)
        {
            var message= _db.Messages.FirstOrDefault(x=>x.messageCode == code);
            if (message == null)
            {
                 return null;
            }
            return message;
        }

        public async Task<MessageType> GetMessageByIdWithRecords(int messageId)
        {
            // Eager load the Zones collection for each RecordEntity
            var messagesWithRecords = await _db.Messages
                .Include(r => r.RecordConfigs)
                .FirstOrDefaultAsync(m => m.id == messageId);
            return messagesWithRecords;
        }

    }
}
