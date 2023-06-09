﻿using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFactManagerAPI.Repository
{
    public class EfactFileContentRepository : Repository<ZoneContent>, IEfactFileContentRepository
    {
        private readonly ApplicationDbContext _db;
        public EfactFileContentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<ZoneContent> UpdateAsync(ZoneContent entity)
        {
            _db.FileContent.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task CreateZoneContentsAsync(IEnumerable<ZoneContent> contents)
        {
            await _db.FileContent.AddRangeAsync(contents);
            await _db.SaveChangesAsync();
        }

    }
}
