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
                 new ZoneConfig() { id = 3, zoneNumber = "3", zonelength = 1, startPosition = 9, description = "nombre numeros comptes financiers (code indice)", zoneType = "n", RecordConfigId = 1},
                 new ZoneConfig() { id = 4, zoneNumber = "4", zonelength = 7, startPosition = 10, description = "version fichier", zoneType = "n", RecordConfigId = 1 },
                 new ZoneConfig() { id = 5, zoneNumber = "5", zonelength = 8, startPosition = 17, description = "n° compte financier a", zoneType = "n", RecordConfigId = 1},

                 new ZoneConfig() { id = 1000, zoneNumber = "6a", zonelength = 4, startPosition = 25, description = "0", zoneType = "n", RecordConfigId = 1 },
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

                  new ZoneConfig() { id = 34, zoneNumber = "33 ", zonelength = 1, startPosition = 176, description = "bic - compte financier A ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 35, zoneNumber = "34 ", zonelength = 1, startPosition = 177, description = "bic - compte financier A ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 36, zoneNumber = "35 ", zonelength = 1, startPosition = 178, description = "0", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 37, zoneNumber = "36 ", zonelength = 1, startPosition = 179, description = "iban - compte financier a  ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 38, zoneNumber = "38 ", zonelength = 12,startPosition = 183, description = "iban - compte financier a  ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 39, zoneNumber = "39 ", zonelength = 10, startPosition = 195, description = "iban - compte financier a ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 40, zoneNumber = "40", zonelength = 2, startPosition = 205, description = "iban - compte financier a ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 41, zoneNumber = "41 ", zonelength = 6, startPosition = 207, description = "iban - compte financier a  ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 42, zoneNumber = "42 ", zonelength = 6, startPosition = 213, description = "0", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 43, zoneNumber = "43a ", zonelength = 11, startPosition = 219, description = "bic - compte financier b  ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 44, zoneNumber = "43b ", zonelength = 1, startPosition = 230, description = "0 ", zoneType = "n", RecordConfigId = 1 },

                  new ZoneConfig() { id= 130,zoneNumber = "44 ", zonelength = 4, startPosition = 231, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 131, zoneNumber = "45 ", zonelength = 26, startPosition = 235, description = "Réservé (réforme de l’état) ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 132, zoneNumber = "46 ", zonelength = 1, startPosition = 261, description = "Réservé (réforme de l’état) ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 133, zoneNumber = "47a ", zonelength = 7, startPosition = 262, description = "Réservé (réforme de l’état) ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 134, zoneNumber = "47b ", zonelength = 1, startPosition = 269, description = "0 ", zoneType = "n", RecordConfigId = 1 },

                  new ZoneConfig() { id = 45, zoneNumber = "48 ", zonelength = 1, startPosition = 270, description = "Réservé (réforme de l’état) ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 46, zoneNumber = "49 ", zonelength = 12, startPosition = 271, description = "iban - compte financier b  ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 47, zoneNumber = "50a ", zonelength = 3, startPosition = 283, description = "iban - compte financier b  ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 48, zoneNumber = "50b ", zonelength = 1, startPosition = 286, description = "iban - compte financier b ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 49, zoneNumber = "51 ", zonelength = 6, startPosition = 287, description = "iban - compte financier b ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 50, zoneNumber = "52 ", zonelength = 12, startPosition = 293, description = "iban - compte financier b ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 51, zoneNumber = "53 ", zonelength = 8, startPosition = 305, description = "Réservé (réforme de l’état) ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 52, zoneNumber = "54a ", zonelength = 3, startPosition = 313, description = "Réservé (réforme de l’état) ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 53, zoneNumber = "54b ", zonelength = 1, startPosition = 316, description = "-- ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 54, zoneNumber = "54c ", zonelength = 4, startPosition = 317, description = "-- ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 55, zoneNumber = "55 ", zonelength = 8, startPosition = 321, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 56, zoneNumber = "56 ", zonelength = 4, startPosition = 329, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 57, zoneNumber = "57 ", zonelength = 4, startPosition = 333, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 58, zoneNumber = "58 ", zonelength = 4, startPosition = 337, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                  new ZoneConfig() { id = 59, zoneNumber = "59 ", zonelength = 6, startPosition = 341, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                      new ZoneConfig() { id = 60, zoneNumber = "98 ", zonelength = 2, startPosition = 347, description = "0 ", zoneType = "n", RecordConfigId = 1 },
                      new ZoneConfig() { id = 61, zoneNumber = "99 ", zonelength = 2, startPosition = 349, description = "0 ", zoneType = "n", RecordConfigId = 1 },


                      //Zones de l'enregistrement  20
                       new ZoneConfig() { id = 62, zoneNumber = "1", zonelength = 2, startPosition = 1, description = "enregistrement de type 20", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 63, zoneNumber = "2", zonelength = 6, startPosition = 3, description = "n° ordre enregist", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 64, zoneNumber = "3", zonelength = 1, startPosition = 9, description = "autorisation tiers payant", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 65, zoneNumber = "4", zonelength = 7, startPosition = 10, description = "heure d'admission", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 66, zoneNumber = "5", zonelength = 8, startPosition = 17, description = "date d'admission", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 67, zoneNumber = "6a", zonelength = 4, startPosition = 25, description = "date de sortie (partie 1)", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 68, zoneNumber = "6b", zonelength = 4, startPosition = 29, description = "date de sortie (partie 2)", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 69, zoneNumber = "7", zonelength = 3, startPosition = 33, description = "numero mutualite d'affiliation", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 70, zoneNumber = "8a", zonelength = 12, startPosition = 36, description = "identification beneficiaire (partie 1)", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 71, zoneNumber = "8b", zonelength = 1, startPosition = 48, description = "identification beneficiaire (partie 2) ", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 72, zoneNumber = "9", zonelength = 1, startPosition = 49, description = "sexe beneficiaire", zoneType = "a", RecordConfigId = 2 },
                 new ZoneConfig() { id = 73, zoneNumber = "10", zonelength = 1, startPosition = 50, description = "type facture", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 74, zoneNumber = "11", zonelength = 1, startPosition = 51, description = "type de facturation", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 75, zoneNumber = "12", zonelength = 1, startPosition = 52, description = "reserve", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 76, zoneNumber = "13", zonelength = 3, startPosition = 53, description = "service 721 bis", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 77, zoneNumber = "14", zonelength = 12, startPosition = 56, description = "numero de l'etablissement qui facture ", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 78, zoneNumber = "15", zonelength = 12, startPosition = 68, description = "etablissement de sejour", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 79, zoneNumber = "16", zonelength = 1, startPosition = 80, description = "code levee delai de prescription", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 80, zoneNumber = "17", zonelength = 4, startPosition = 81, description = "causes du traitement", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 81, zoneNumber = "18", zonelength = 3, startPosition = 85, description = "numero mutualite de destination", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 82, zoneNumber = "19", zonelength = 12, startPosition = 88, description = "numero d'admission", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 83, zoneNumber = "20", zonelength = 7, startPosition = 100, description = "date accord traitement (partie 1)", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 84, zoneNumber = "21", zonelength = 1, startPosition = 107, description = "date accord traitement (partie 2)", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 85, zoneNumber = "22", zonelength = 5, startPosition = 108, description = "heure de sortie", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 86, zoneNumber = "23", zonelength = 2, startPosition = 113, description = "reserve", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 87, zoneNumber = "24", zonelength = 5, startPosition = 115, description = "numero de la facture individuelle (partie 1) ", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 88, zoneNumber = "25", zonelength = 7, startPosition = 120, description = "numero de la facture individuelle (partie 2)", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 89, zoneNumber = "26", zonelength = 1, startPosition = 127, description = "application franchise sociale", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 90, zoneNumber = "27", zonelength = 10, startPosition = 128, description = "ct 1 + ct 2", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 91, zoneNumber = "28", zonelength = 25, startPosition = 138, description = "reference de l'etablissement", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 92, zoneNumber = "29", zonelength = 2, startPosition = 163, description = "numero de facture precedente (partie 1)", zoneType = "n", RecordConfigId = 2 },
                 new ZoneConfig() { id = 93, zoneNumber = "30", zonelength = 2, startPosition = 165, description = "numero de facture precedente (partie 2)", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 94, zoneNumber = "31", zonelength = 8, startPosition = 167, description = "numero de facture precedente (partie 3)", zoneType = "n", RecordConfigId = 2 },

                  new ZoneConfig() { id = 95, zoneNumber = "32 ", zonelength = 1, startPosition = 175, description = "flag identification du beneficiaire", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 96, zoneNumber = "33 ", zonelength = 1, startPosition = 176, description = "reserve", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 97, zoneNumber = "34 ", zonelength = 1, startPosition = 177, description = "numero envoi precedent (partie 1)", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 98, zoneNumber = "35 ", zonelength = 1, startPosition = 178, description = "numero envoi precedent (partie 2)", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 99, zoneNumber = "36 ", zonelength = 1, startPosition = 179, description = "numero envoi precedent (partie 3)", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 100, zoneNumber = "37 ", zonelength = 3, startPosition = 180, description = "numero mutualite facturation precedente", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 101, zoneNumber = "38", zonelength = 12, startPosition = 283, description = "reference mutualite numero de compte financier a (partie 1) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 102, zoneNumber = "39 ", zonelength = 10, startPosition = 295, description = "reference mutualite numero de compte financier a (partie 2) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 103, zoneNumber = "40 ", zonelength = 2, startPosition = 205, description = "reserve", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 104, zoneNumber = "41 ", zonelength = 6, startPosition = 207, description = "annee et mois de facturation precedente", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 105, zoneNumber = "42 ", zonelength = 6, startPosition = 213, description = "donnees de reference reseau ou carte sis (partie 1) ", zoneType = "a", RecordConfigId = 2 },

                  new ZoneConfig() { id = 106, zoneNumber = "43a ", zonelength = 11, startPosition = 219, description = "donnees de reference reseau ou carte sis (partie 2) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 107, zoneNumber = "43b ", zonelength = 1, startPosition = 230, description = "donnees de reference reseau ou carte sis (partie 3) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 108, zoneNumber = "44 ", zonelength = 4, startPosition = 231, description = "donnees de reference reseau ou carte sis (partie 4) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 109, zoneNumber = "45 ", zonelength = 26, startPosition = 235, description = "donnees de reference reseau ou carte sis (partie 5) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 110, zoneNumber = "46 ", zonelength = 1, startPosition = 261, description = "reserve ", zoneType = "n", RecordConfigId = 2 },

                  new ZoneConfig() { id = 111, zoneNumber = "47a ", zonelength = 7, startPosition = 262, description = "date de facturation (partie 1) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 112, zoneNumber = "47b ", zonelength = 1, startPosition = 269, description = "date de facturation (partie 2) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 113, zoneNumber = "48 ", zonelength = 1, startPosition = 270, description = "reserve ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 114, zoneNumber = "49 ", zonelength = 12, startPosition = 271, description = "reference mutualite numero compte financier b (partie 1)", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 115, zoneNumber = "50a ", zonelength = 3, startPosition = 283, description = "reference mutualite numero compte financier b (partie 2)", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 116, zoneNumber = "50b ", zonelength = 1, startPosition = 286, description = "reference mutualite numero compte financier b (partie 2 bis)", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 117, zoneNumber = "51 ", zonelength = 6, startPosition = 387, description = "reference mutualite numero compte financier b (partie 3)", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 118, zoneNumber = "52 ", zonelength = 12, startPosition = 393, description = "numéro d’admission de la mère", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 119, zoneNumber = "53 ", zonelength = 8, startPosition = 305, description = "date debut assurabilite", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 120, zoneNumber = "54a ", zonelength = 3, startPosition = 313, description = "date fin assurabilite (partie 1) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 121, zoneNumber = "54b ", zonelength = 1, startPosition = 316, description = "date fin assurabilite (partie 2) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 122, zoneNumber = "54c ", zonelength = 4, startPosition = 317, description = "date fin assurabilite (partie 3) ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 123, zoneNumber = "55 ", zonelength = 8, startPosition = 321, description = "date communication information", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 124, zoneNumber = "56 ", zonelength = 4, startPosition = 329, description = "maf annee en cours  ", zoneType = "n", RecordConfigId = 2 },
                  new ZoneConfig() { id = 125, zoneNumber = "57 ", zonelength = 4, startPosition = 333, description = "maf annee en cours -1  ", zoneType = "n", RecordConfigId = 2 },
                      new ZoneConfig() { id = 126, zoneNumber = "58 ", zonelength = 4, startPosition = 337, description = "maf annee en cours -2 ", zoneType = "n", RecordConfigId = 2 },
                      new ZoneConfig() { id = 127, zoneNumber = "59 ", zonelength = 6, startPosition = 341, description = "reserve ", zoneType = "n", RecordConfigId = 2 },
                      new ZoneConfig() { id = 128, zoneNumber = "98 ", zonelength = 2, startPosition = 347, description = "reserve ", zoneType = "n", RecordConfigId = 2 },
                      new ZoneConfig() { id = 129, zoneNumber = "99 ", zonelength = 2, startPosition = 349, description = "chiffres de controle de l'enregistrement", zoneType = "n", RecordConfigId = 2 },



                       //Zones de l'enregistrement  50
                       new ZoneConfig() { id = 135, zoneNumber = "1", zonelength = 2, startPosition = 1, description = "enregistrement de type 50", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 136, zoneNumber = "2", zonelength = 6, startPosition = 3, description = "n° ordre enregist", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 137, zoneNumber = "3", zonelength = 1, startPosition = 9, description = "norme prestation (pourcentage)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 138, zoneNumber = "4", zonelength = 7, startPosition = 10, description = "code nomenclature ou pseudo-code nomenclature", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 139, zoneNumber = "5", zonelength = 8, startPosition = 17, description = "date premiere prestation effectuee", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 140, zoneNumber = "6a", zonelength = 4, startPosition = 25, description = "date derniere prestation effectuee (partie 1)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 141, zoneNumber = "6b", zonelength = 4, startPosition = 29, description = "date derniere prestation effectuee (partie 2)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 142, zoneNumber = "7", zonelength = 3, startPosition = 33, description = "numero mutualite d'affiliation", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 143, zoneNumber = "8a", zonelength = 12, startPosition = 36, description = "identification beneficiaire (partie 1)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 144, zoneNumber = "8b", zonelength = 1, startPosition = 48, description = "identification beneficiaire (partie 2) ", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 145, zoneNumber = "9", zonelength = 1, startPosition = 49, description = "sexe beneficiaire", zoneType = "a", RecordConfigId = 4 },
                 new ZoneConfig() { id = 146, zoneNumber = "10", zonelength = 1, startPosition = 50, description = "accouchement", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 147, zoneNumber = "11", zonelength = 1, startPosition = 51, description = "reference numero compte financie", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 148, zoneNumber = "12", zonelength = 1, startPosition = 52, description = "nuit, week-end, jour ferie", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 149, zoneNumber = "13", zonelength = 3, startPosition = 53, description = "code service", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 150, zoneNumber = "14", zonelength = 12, startPosition = 56, description = "lieu de prestation", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 151, zoneNumber = "15", zonelength = 12, startPosition = 68, description = "identification du dispensateur", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 152, zoneNumber = "16", zonelength = 1, startPosition = 80, description = "norme dispensateur", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 153, zoneNumber = "17", zonelength = 4, startPosition = 81, description = "prestation relative (partie 1)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 154, zoneNumber = "18", zonelength = 3, startPosition = 85, description = "prestation relative (partie 2) ", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 155, zoneNumber = "19", zonelength = 12, startPosition = 88, description = "signe + montant intervention de l'assurance", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 156, zoneNumber = "20", zonelength = 7, startPosition = 100, description = "date prescription (partie 1)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 157, zoneNumber = "21", zonelength = 1, startPosition = 107, description = "date prescription (partie 2)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 158, zoneNumber = "22", zonelength = 5, startPosition = 108, description = "signe + nombre d'unites", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 159, zoneNumber = "23", zonelength = 2, startPosition = 113, description = "dérogation nombre maximal ou prestation identique", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 160, zoneNumber = "24", zonelength = 5, startPosition = 115, description = "identification prescripteur (partie 1)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 161, zoneNumber = "25", zonelength = 7, startPosition = 120, description = "identification prescripteur (partie 2)", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 162, zoneNumber = "26", zonelength = 1, startPosition = 127, description = "norme prescripteur", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 163, zoneNumber = "27", zonelength = 10, startPosition = 128, description = "signe + intervention personnelle patient", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 164, zoneNumber = "28", zonelength = 25, startPosition = 138, description = "reference de l'etablissement", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 165, zoneNumber = "29", zonelength = 2, startPosition = 163, description = "dent traitee", zoneType = "n", RecordConfigId = 4 },
                 new ZoneConfig() { id = 166, zoneNumber = "30", zonelength = 2, startPosition = 165, description = "signe + montant supplement (partie 1)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 167, zoneNumber = "31", zonelength = 8, startPosition = 167, description = "montant supplement (partie 2)", zoneType = "n", RecordConfigId = 4 },

                  new ZoneConfig() { id = 168, zoneNumber = "32 ", zonelength = 1, startPosition = 175, description = "exception tiers payant", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 169, zoneNumber = "33 ", zonelength = 1, startPosition = 176, description = "code facturation intervention personnelle ou supplement", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 170, zoneNumber = "34 ", zonelength = 1, startPosition = 177, description = "membre traite", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 171, zoneNumber = "35 ", zonelength = 1, startPosition = 178, description = "prestataire conventionne", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 172, zoneNumber = "36 ", zonelength = 1, startPosition = 179, description = "heure de prestation(partie 1)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 173, zoneNumber = "37 ", zonelength = 3, startPosition = 180, description = "heure de prestation (partie 2)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 174, zoneNumber = "38", zonelength = 12, startPosition = 183, description = "identification administrateur du sang", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 175, zoneNumber = "39 ", zonelength = 10, startPosition = 195, description = "numero de l'attestation d'administration (partie 1)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 176, zoneNumber = "40 ", zonelength = 2, startPosition = 205, description = "numero de l'attestation d'administration (partie 2)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 177, zoneNumber = "41 ", zonelength = 6, startPosition = 207, description = "numero bon de delivrance ou sac (partie 1)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 178, zoneNumber = "42 ", zonelength = 6, startPosition = 213, description = "numero bon de delivrance ou sac (partie 2)", zoneType = "a", RecordConfigId = 4 },

                  new ZoneConfig() { id = 179, zoneNumber = "43a ", zonelength = 11, startPosition = 219, description = "code implant (partie 1) ", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 180, zoneNumber = "43b ", zonelength = 1, startPosition = 230, description = "code implant (partie 2)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 181, zoneNumber = "44 ", zonelength = 4, startPosition = 231, description = "libelle du produit (partie 1)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 182, zoneNumber = "45 ", zonelength = 26, startPosition = 235, description = "libelle du produit (partie 2) ", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 183, zoneNumber = "46 ", zonelength = 1, startPosition = 261, description = "norme plafond  ", zoneType = "n", RecordConfigId = 4 },

                  new ZoneConfig() { id = 184, zoneNumber = "47 ", zonelength = 8, startPosition = 262, description = "Valeur de base prestation", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 185, zoneNumber = "48 ", zonelength = 1, startPosition = 270, description = "transplantation", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 186, zoneNumber = "49 ", zonelength = 12, startPosition = 271, description = "identification du dispensateur auxiliaire", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 187, zoneNumber = "50a ", zonelength = 3, startPosition = 283, description = "pourcentage dans le forfait", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 188, zoneNumber = "50b ", zonelength = 1, startPosition = 286, description = "reserve", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 189, zoneNumber = "51 ", zonelength = 6, startPosition = 287, description = "site hospitalier", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 190, zoneNumber = "52 ", zonelength = 12, startPosition = 293, description = "identification association bassin de soins", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 191, zoneNumber = "53 ", zonelength = 8, startPosition = 305, description = "numero de course (partie 1)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 192, zoneNumber = "54a ", zonelength = 3, startPosition = 313, description = "numero de course (partie 2)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 193, zoneNumber = "54b ", zonelength = 1, startPosition = 316, description = "flag GPS ", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 194, zoneNumber = "54c ", zonelength = 4, startPosition = 317, description = "reserve", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 195, zoneNumber = "55 ", zonelength = 8, startPosition = 321, description = "code notification implant (partie 1)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 196, zoneNumber = "56 ", zonelength = 4, startPosition = 329, description = "code notification implant (partie 2)", zoneType = "n", RecordConfigId = 4 },
                  new ZoneConfig() { id = 197, zoneNumber = "57 ", zonelength = 4, startPosition = 333, description = "code d’enregistrement (partie 1)", zoneType = "n", RecordConfigId = 4},
                  new ZoneConfig() { id = 198, zoneNumber = "58 ", zonelength = 4, startPosition = 337, description = "code d’enregistrement (partie 2) ", zoneType = "n", RecordConfigId = 4 },
                      new ZoneConfig() { id = 199, zoneNumber = "59 ", zonelength = 6, startPosition = 341, description = "code d’enregistrement (partie 3) ", zoneType = "n", RecordConfigId = 4 },
                      new ZoneConfig() { id = 200, zoneNumber = "98 ", zonelength = 2, startPosition = 347, description = "flag TVA ", zoneType = "n", RecordConfigId = 4 },
                      new ZoneConfig() { id = 201, zoneNumber = "99 ", zonelength = 2, startPosition = 349, description = "chiffres de controle de l'enregistrement ", zoneType = "n", RecordConfigId = 4 },




                       //Zones de l'enregistrement  51
                       new ZoneConfig() { id = 202, zoneNumber = "1", zonelength = 2, startPosition = 1, description = "enregistrement de type 51", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 203, zoneNumber = "2", zonelength = 6, startPosition = 3, description = "n° ordre enregist", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 204, zoneNumber = "3", zonelength = 1, startPosition = 9, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 205, zoneNumber = "4", zonelength = 7, startPosition = 10, description = "code nomenclature ou pseudo-code nomenclature", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 206, zoneNumber = "5", zonelength = 8, startPosition = 17, description = "date prestation", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 207, zoneNumber = "6a", zonelength = 4, startPosition = 25, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 208, zoneNumber = "6b", zonelength = 4, startPosition = 29, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 209, zoneNumber = "7", zonelength = 3, startPosition = 33, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 210, zoneNumber = "8a", zonelength = 12, startPosition = 36, description = "identification beneficiaire", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 211, zoneNumber = "8b", zonelength = 1, startPosition = 48, description = "identification beneficiaire ", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 212, zoneNumber = "9", zonelength = 1, startPosition = 49, description = "reserve", zoneType = "a", RecordConfigId = 5},
                 new ZoneConfig() { id = 213, zoneNumber = "10", zonelength = 1, startPosition = 50, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 214, zoneNumber = "11", zonelength = 1, startPosition = 51, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 215, zoneNumber = "12", zonelength = 1, startPosition = 52, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 216, zoneNumber = "13", zonelength = 3, startPosition = 53, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 217, zoneNumber = "14", zonelength = 12, startPosition = 56, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 218, zoneNumber = "15", zonelength = 12, startPosition = 68, description = "identification du dispensateur", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 219, zoneNumber = "16", zonelength = 1, startPosition = 80, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 220, zoneNumber = "17", zonelength = 4, startPosition = 81, description = "prestation relative", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 221, zoneNumber = "18", zonelength = 3, startPosition = 85, description = "prestation relative ", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 222, zoneNumber = "19", zonelength = 12, startPosition = 88, description = "signe + montant intervention de l'assurance", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 223, zoneNumber = "20", zonelength = 7, startPosition = 100, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 224, zoneNumber = "21", zonelength = 1, startPosition = 107, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 225, zoneNumber = "22", zonelength = 5, startPosition = 108, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 226, zoneNumber = "23", zonelength = 2, startPosition = 113, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 227, zoneNumber = "24", zonelength = 5, startPosition = 115, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 228, zoneNumber = "25", zonelength = 7, startPosition = 120, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 229, zoneNumber = "26", zonelength = 1, startPosition = 127, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 230, zoneNumber = "27", zonelength = 10, startPosition = 128, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 231, zoneNumber = "28", zonelength = 25, startPosition = 138, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 232, zoneNumber = "29", zonelength = 2, startPosition = 163, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                 new ZoneConfig() { id = 233, zoneNumber = "30", zonelength = 2, startPosition = 165, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 234, zoneNumber = "31", zonelength = 8, startPosition = 167, description = "reserve", zoneType = "n", RecordConfigId = 5 },

                  new ZoneConfig() { id = 235, zoneNumber = "32 ", zonelength = 1, startPosition = 175, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 236, zoneNumber = "33 ", zonelength = 1, startPosition = 176, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 237, zoneNumber = "34 ", zonelength = 1, startPosition = 177, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 238, zoneNumber = "35 ", zonelength = 1, startPosition = 178, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 239, zoneNumber = "36 ", zonelength = 1, startPosition = 179, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 240, zoneNumber = "37 ", zonelength = 3, startPosition = 180, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 241, zoneNumber = "38", zonelength = 12, startPosition = 183, description = "identification administrateur du sang", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 242, zoneNumber = "39 ", zonelength = 10, startPosition = 195, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 243, zoneNumber = "40 ", zonelength = 2, startPosition = 205, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 244, zoneNumber = "41 ", zonelength = 6, startPosition = 207, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 245, zoneNumber = "42 ", zonelength = 6, startPosition = 213, description =" numéro d’agrément engagement de tarif", zoneType = "a", RecordConfigId = 5 },
                  new ZoneConfig() { id = 246, zoneNumber = "43a ", zonelength = 11, startPosition = 219, description = "numéro d’agrément engagement de tarif ", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 247, zoneNumber = "43b ", zonelength = 1, startPosition = 230, description = "numéro d’agrément engagement de tarif", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 248, zoneNumber = "44 ", zonelength = 4, startPosition = 231, description = "numéro d’agrément engagement de tarif", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 249, zoneNumber = "45 ", zonelength = 26, startPosition = 235, description = "numéro d’agrément engagement de tarif ", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 250, zoneNumber = "46 ", zonelength = 1, startPosition = 261, description = "reserve ", zoneType = "n", RecordConfigId = 5 },

                  new ZoneConfig() { id = 251, zoneNumber = "47a", zonelength = 7, startPosition = 262, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 252, zoneNumber = "47b", zonelength = 1, startPosition = 269, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 253, zoneNumber = "48 ", zonelength = 1, startPosition = 270, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 254, zoneNumber = "49 ", zonelength = 12, startPosition = 271, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 255, zoneNumber = "50a ", zonelength = 3, startPosition = 283, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 256, zoneNumber = "50b ", zonelength = 1, startPosition = 286, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 257, zoneNumber = "51 ", zonelength = 6, startPosition = 287, description = "reserve", zoneType = "n", RecordConfigId = 5},
                  new ZoneConfig() { id = 258, zoneNumber = "52 ", zonelength = 12, startPosition = 293, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 259, zoneNumber = "53 ", zonelength = 8, startPosition = 305, description = "reserve", zoneType = "n", RecordConfigId = 5},
                  new ZoneConfig() { id = 260, zoneNumber = "54a ", zonelength = 3, startPosition = 313, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 261, zoneNumber = "54b ", zonelength = 1, startPosition = 316, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 262, zoneNumber = "54c ", zonelength = 4, startPosition = 317, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 263, zoneNumber = "55 ", zonelength = 8, startPosition = 321, description = "date communication information", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 264, zoneNumber = "56 ", zonelength = 4, startPosition = 329, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                  new ZoneConfig() { id = 265, zoneNumber = "57 ", zonelength = 4, startPosition = 333, description = "reserve ", zoneType = "n", RecordConfigId = 5 },
                      new ZoneConfig() { id = 266, zoneNumber = "58 ", zonelength = 4, startPosition = 337, description = "reserve ", zoneType = "n", RecordConfigId = 5 },
                      new ZoneConfig() { id = 267, zoneNumber = "59 ", zonelength = 6, startPosition = 341, description = "reserve ", zoneType = "n", RecordConfigId = 5 },
                      new ZoneConfig() { id = 268, zoneNumber = "98 ", zonelength = 2, startPosition = 347, description = "reserve", zoneType = "n", RecordConfigId = 5 },
                      new ZoneConfig() { id = 269, zoneNumber = "99 ", zonelength = 2, startPosition = 349, description = "chiffres de contrôle de l’enregistrement ", zoneType = "n", RecordConfigId = 5 },


                       //Zones de l'enregistrement  52
                       new ZoneConfig() { id = 270, zoneNumber = "1", zonelength = 2, startPosition = 1, description = "Enregistrement de type 52", zoneType = "n", RecordConfigId = 6 },
                       new ZoneConfig() { id = 271, zoneNumber = "2", zonelength = 6, startPosition = 3, description = "Numéro d'ordre de l'enregistrement", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 272, zoneNumber = "3", zonelength = 1, startPosition = 9, description = "Raison encodage manuel", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 273, zoneNumber = "4", zonelength = 7, startPosition = 10, description = "Code nomenclature ", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 274, zoneNumber = "5", zonelength = 8, startPosition = 17, description = "Date de prestation", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 275, zoneNumber = "6a", zonelength = 4, startPosition = 25, description = "Date de lecture document identité", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 276, zoneNumber = "6b", zonelength = 4, startPosition = 29, description = "Date de lecture document identité", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 277, zoneNumber = "7", zonelength = 3, startPosition = 33, description = "reserve", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 278, zoneNumber = "8a", zonelength = 12, startPosition = 36, description = "Numéro NISS du patient sauf en cas de convention internationale ou nouveau né", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 279, zoneNumber = "8b", zonelength = 1, startPosition = 48, description = "Numéro NISS du patient sauf en cas de convention internationale ou nouveau né", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 280, zoneNumber = "9", zonelength = 1, startPosition = 49, description = "Type de saisie document identité", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 281, zoneNumber = "10", zonelength = 1, startPosition = 50, description = "Type de support document identité", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 282, zoneNumber = "11", zonelength = 1, startPosition = 51, description = "Raison utilisation vignette", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 283, zoneNumber = "12", zonelength = 1, startPosition = 52, description = "Heure de lecture document identité", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 284, zoneNumber = "13", zonelength = 3, startPosition = 53, description = "Heure de lecture document identité", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 285, zoneNumber = "14", zonelength = 12, startPosition = 56, description = "reserve", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 286, zoneNumber = "15", zonelength = 12, startPosition = 68, description = "Numéro INAMI", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 287, zoneNumber = "16", zonelength = 15, startPosition = 80, description = "Numéro de série du support", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 288, zoneNumber = "17", zonelength = 25, startPosition = 95, description = "Numéro document justificatif", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 289, zoneNumber = "18", zonelength = 12, startPosition = 120, description = "Numéro unique appareil imagerie médicale", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 290, zoneNumber = "19-98", zonelength = 217, startPosition = 132, description = "reserve", zoneType = "n", RecordConfigId = 6 },
                        new ZoneConfig() { id = 291, zoneNumber = "99", zonelength = 2, startPosition = 349, description = "Enregistrement chiffres de contrôle", zoneType = "n", RecordConfigId = 6 }

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
