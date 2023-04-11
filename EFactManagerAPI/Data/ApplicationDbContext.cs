using EFactManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFactManagerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        public DbSet<FileEntity> Files { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<RecordEntity> Records { get; set; }
        public DbSet<ZoneEntity> Zones { get; set; }
        public DbSet<FieldEntity> Fields { get; set; }

        public DbSet<ZoneContentEntity> ZoneContents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileEntity>().HasData(
                new FileEntity()
                {
                    id = 1,
                    fileName = "Test File",
                    Description = "Test",
                    size = 1.5f,
                    fileUploadedContent ="testtes",
                    update_date = DateTime.Now,
                    upload_date = DateTime.Now
                });


            modelBuilder.Entity<FieldEntity>()
                .HasOne(f => f.Message)
                .WithMany(m => m.Fields)
                .HasForeignKey(f => f.messageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FieldEntity>()
                .HasOne(f => f.Record)
                .WithMany(r => r.Fields)
                .HasForeignKey(f => f.recordId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FieldEntity>()
                .HasOne(f => f.ZoneContent)
                .WithMany(zc => zc.Fields)
                .HasForeignKey(f => f.zoneContentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FieldEntity>()
                .HasOne(f => f.Zone)
                .WithMany(zco => zco.Fields)
                .HasForeignKey(f => f.zoneId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
