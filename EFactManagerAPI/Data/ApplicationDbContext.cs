using EFactManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFactManagerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        public DbSet<EfactFile> Files { get; set; }
        public DbSet<ZoneContent> FileContent{ get; set; }
        public DbSet<MessageType> Messages { get; set; }
        public DbSet<RecordConfig> Records { get; set; }
        public DbSet<ZoneConfig> Zones { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<ZoneError> ZoneErrors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EfactFile>().HasData(
                new EfactFile()
                {
                    id = 1,
                    fileName = "Test File",
                    Description = "Test",
                    size = 1.5f,
                    fileUploadedContent = "testtes",
                    update_date = DateTime.Now,
                    upload_date = DateTime.Now
                });

            modelBuilder.Entity<MessageType>().HasData(
                new MessageType()
                {
                    id = 1,
                    messageCode = "920000",
                    description = "message contenant le fichier de facturation transmis par le prestataire",
                    dateCreation = DateTime.Now,
                    dateUpdate = DateTime.Now,
                });

            modelBuilder.Entity<RecordConfig>().HasData(
                new RecordConfig() { id = 1, recordNumber = "10", description = "Enregistrement de type 10", recordLength = 350, recordPlacement = "body", dateCreation = DateTime.Now, dateUpdate = DateTime.Now,MessageTypeId=1},
                new RecordConfig() { id = 2, recordNumber = "20", description = "Identification du patient", recordLength = 350, recordPlacement = "body", dateCreation = DateTime.Now, dateUpdate = DateTime.Now, MessageTypeId = 1 },
                new RecordConfig() { id = 4, recordNumber = "50", description = "Données sur la prestation", recordLength = 350, recordPlacement = "body", dateCreation = DateTime.Now, dateUpdate = DateTime.Now, MessageTypeId = 1 },
                new RecordConfig() { id = 5, recordNumber = "51", description = "enregistrement de type 51", recordLength = 350, recordPlacement = "body", dateCreation = DateTime.Now, dateUpdate = DateTime.Now, MessageTypeId = 1 },
                new RecordConfig() { id = 6, recordNumber = "52", description = "enregistrement de type 52", recordLength = 350, recordPlacement = "body", dateCreation = DateTime.Now, dateUpdate = DateTime.Now, MessageTypeId = 1 },
                new RecordConfig() { id = 7, recordNumber = "58", description = "enregistrement de type 80", recordLength = 350, recordPlacement = "body", dateCreation = DateTime.Now, dateUpdate = DateTime.Now, MessageTypeId = 1,}
              );

            modelBuilder.Entity<ZoneConfig>().HasData(
                new ZoneConfig() { id = 1, zoneNumber = "1", zonelength = 2, startPosition = 1, description = "enregist. de type 10", zoneType = "n", RecordConfigId = 1, },
                 new ZoneConfig() { id = 2, zoneNumber = "2", zonelength = 6, startPosition = 3, description = "n° ordre enregist", zoneType = "n", RecordConfigId = 1},
                 new ZoneConfig() { id = 3, zoneNumber = "3", zonelength = 1, startPosition = 9, description = "code indice", zoneType = "n", RecordConfigId = 1},
                 new ZoneConfig() { id = 4, zoneNumber = "4", zonelength = 7, startPosition = 10, description = "version fichier", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 5, zoneNumber = "5", zonelength = 8, startPosition = 17, description = "n° compte financier a", zoneType = "n", RecordConfigId = 1},
                 new ZoneConfig() { id = 6, zoneNumber = "6b", zonelength = 4, startPosition = 29, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 7, zoneNumber = "7", zonelength = 3, startPosition = 33, description = "enregist. de type 10", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 8, zoneNumber = "8a", zonelength = 12, startPosition = 36, description = "n° compte financier b ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 9, zoneNumber = "8b", zonelength = 1, startPosition = 48, description = "numero de l'envoi  ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 10, zoneNumber = "9", zonelength = 1, startPosition = 49, description = "code s.f.p ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 11, zoneNumber = "10", zonelength = 1, startPosition = 50, description = "code fichier de decompte ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 12, zoneNumber = "11", zonelength = 1, startPosition = 51, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 13, zoneNumber = "12", zonelength = 1, startPosition = 52, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 14, zoneNumber = "13", zonelength = 3, startPosition = 53, description = "contenu facturation ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 15, zoneNumber = "14", zonelength = 12, startPosition = 56, description = "n° tiers payant 0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 16, zoneNumber = "15", zonelength = 12, startPosition = 68, description = "n° accreditation cin ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 17, zoneNumber = "16", zonelength = 1, startPosition = 80, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 18, zoneNumber = "17", zonelength = 4, startPosition = 81, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 19, zoneNumber = "18", zonelength = 3, startPosition = 85, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 20, zoneNumber = "19", zonelength = 12, startPosition = 88, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 21, zoneNumber = "20", zonelength = 7, startPosition = 100, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 22, zoneNumber = "21", zonelength = 1, startPosition = 107, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 23, zoneNumber = "22", zonelength = 5, startPosition = 108, description = "annee facturee ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 24, zoneNumber = "23", zonelength = 2, startPosition = 113, description = "mois facture ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 25, zoneNumber = "24", zonelength = 5, startPosition = 115, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 26, zoneNumber = "25", zonelength = 7, startPosition = 120, description = "date de creation ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 27, zoneNumber = "26", zonelength = 1, startPosition = 127, description = "date de creation ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 28, zoneNumber = "27", zonelength = 10, startPosition = 128, description = "Numéro BCE ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 29, zoneNumber = "28", zonelength = 25, startPosition = 138, description = "ref. etablissement ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 30, zoneNumber = "29", zonelength = 2, startPosition = 163, description = "0", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 31, zoneNumber = "30", zonelength = 2, startPosition = 165, description = "bic - compte financier A ", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 32, zoneNumber = "31", zonelength = 8, startPosition = 167, description = "bic - compte financier A ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 33, zoneNumber = "32", zonelength = 1, startPosition = 175, description = "bic - compte financier A ", zoneType = "n", RecordConfigId = 1 },

                  new ZoneConfig() { id = 34, zoneNumber = "33\r\n", zonelength = 1, startPosition = 176, description = "bic - compte financier A ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 35, zoneNumber = "34\r\n", zonelength = 1, startPosition = 177, description = "bic - compte financier A ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 36, zoneNumber = "35\r\n", zonelength = 1, startPosition = 178, description = "0", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 37, zoneNumber = "36\r\n", zonelength = 1, startPosition = 179, description = "iban - compte financier a\r\n ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 38, zoneNumber = "38\r\n", zonelength = 12,startPosition = 183, description = "iban - compte financier a\r\n ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 39, zoneNumber = "39\r\n", zonelength = 10, startPosition = 195, description = "iban - compte financier a\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 40, zoneNumber = "40", zonelength = 2, startPosition = 205, description = "iban - compte financier a\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 41, zoneNumber = "41\r\n", zonelength = 6, startPosition = 207, description = "iban - compte financier a\r\n ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 42, zoneNumber = "42\r\n", zonelength = 6, startPosition = 213, description = "0", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 43, zoneNumber = "43a\r\n", zonelength = 11, startPosition = 219, description = "bic - compte financier b\r\n ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 44, zoneNumber = "43b\r\n", zonelength = 1, startPosition = 230, description = "0 ", zoneType = "n", RecordConfigId = 1 },

                  new ZoneConfig() { id = 44, zoneNumber = "44\r\n", zonelength = 4, startPosition = 231, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 44, zoneNumber = "45\r\n", zonelength = 26, startPosition = 235, description = "Réservé (réforme de l’état)\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 44, zoneNumber = "46\r\n", zonelength = 1, startPosition = 261, description = "Réservé (réforme de l’état)\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 44, zoneNumber = "47a\r\n", zonelength = 7, startPosition = 262, description = "Réservé (réforme de l’état)\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 44, zoneNumber = "47b\r\n", zonelength = 1, startPosition = 269, description = "0 ", zoneType = "n", RecordConfigId = 1 },

                  new ZoneConfig() { id = 45, zoneNumber = "48\r\n", zonelength = 1, startPosition = 270, description = "Réservé (réforme de l’état)\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 46, zoneNumber = "49\r\n", zonelength = 12, startPosition = 271, description = "iban - compte financier b\r\n ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 47, zoneNumber = "50a\r\n", zonelength = 3, startPosition = 283, description = "iban - compte financier b\r\n ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 48, zoneNumber = "50b\r\n", zonelength = 1, startPosition = 286, description = "iban - compte financier b\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 49, zoneNumber = "51\r\n", zonelength = 6, startPosition = 287, description = "iban - compte financier b\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 50, zoneNumber = "52\r\n", zonelength = 12, startPosition = 293, description = "iban - compte financier b\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 51, zoneNumber = "53\r\n", zonelength = 8, startPosition = 305, description = "Réservé (réforme de l’état)\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 52, zoneNumber = "54a\r\n", zonelength = 3, startPosition = 313, description = "Réservé (réforme de l’état)\r\n", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 53, zoneNumber = "54b\r\n", zonelength = 1, startPosition = 316, description = "-- ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 54, zoneNumber = "54c\r\n", zonelength = 4, startPosition = 317, description = "-- ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 55, zoneNumber = "55\r\n", zonelength = 8, startPosition = 321, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 56, zoneNumber = "56\r\n", zonelength = 4, startPosition = 329, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 57, zoneNumber = "57\r\n", zonelength = 4, startPosition = 333, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 58, zoneNumber = "58\r\n", zonelength = 4, startPosition = 337, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 59, zoneNumber = "59\r\n", zonelength = 6, startPosition = 341, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                      new ZoneConfig() { id = 60, zoneNumber = "98\r\n", zonelength = 2, startPosition = 347, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                      new ZoneConfig() { id = 61, zoneNumber = "99\r\n", zonelength = 2, startPosition = 349, description = "0 ", zoneType = "n", RecordConfigId = 1 }

                );

            // configure one-to-many relationship between File and FieldAssignment
            modelBuilder.Entity<EfactFile>()
             .HasMany(f => f.Fields)
             .WithOne(fa => fa.File)
             .HasForeignKey(fa => fa.FileId)
             .OnDelete(DeleteBehavior.Cascade);

            // configure one-to-one relationship between Field and ZoneContent
            modelBuilder.Entity<Field>()
                .HasOne(f => f.ZoneContent)
                .WithOne(zc => zc.Field)
                .HasForeignKey<ZoneContent>(zc => zc.FieldId);

            // configure many-to-many relationship between ZoneConfig and Field
            modelBuilder.Entity<Field>()
                .HasOne(f => f.ZoneConfig)
                .WithMany(zc => zc.Fields)
                .HasForeignKey(f => f.ZoneConfigId);

            modelBuilder.Entity<ZoneConfig>()
                .HasMany(zc => zc.Fields)
                .WithOne(f => f.ZoneConfig)
                .HasForeignKey(f => f.ZoneConfigId);

            // configure one-to-many relationship between MessageType and RecordConfig
            modelBuilder.Entity<MessageType>()
                .HasMany(mt => mt.RecordConfigs)
                .WithOne(rc => rc.MessageType)
                .HasForeignKey(rc => rc.MessageTypeId);

            // configure many-to-one relationship between RecordConfig and ZoneConfig
            modelBuilder.Entity<RecordConfig>()
                .HasMany(rc => rc.ZoneConfigs)
                .WithOne(zc => zc.RecordConfig)
                .HasForeignKey(zc => zc.RecordConfigId);

            // configure one-to-one relationship between ZoneConfig and ZoneErrorConfig
            modelBuilder.Entity<ZoneConfig>()
              .HasOne(zc => zc.ZoneError)
              .WithOne(zec => zec.ZoneConfig)
              .HasForeignKey<ZoneError>(zec => zec.ZoneConfigId);
        }
    }
}
