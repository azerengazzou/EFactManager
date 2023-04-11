using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFactManagerAPI.Repository
{
    public class MessageRepository : Repository<MessageEntity>, IMessageRepository
    {
        private readonly ApplicationDbContext _db;
        public MessageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<MessageEntity> UpdateAsync(MessageEntity entity)
        {
            entity.dateUpdate = DateTime.Now;
            _db.Messages.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public MessageEntity GetMessageByCode(string code)
        {
            var message= _db.Messages.FirstOrDefault(x=>x.messageCode == code);
            if (message == null)
            {
                 return null;
            }
            return message;
        }

    }
}
