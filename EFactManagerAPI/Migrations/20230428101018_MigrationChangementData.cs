using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigrationChangementData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9473), "Message contenant le fichier de facturation transmis par le prestataire" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "id", "dateCreation", "dateUpdate", "description", "messageCode" },
                values: new object[] { 2, new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9475), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9476), "Fichier rejets (erreurs bloquantes ou nombre d’erreurs > 5 %)", "920099" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9767), "Données sur la facture." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9771), "Informations du patient." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9774), "Informations du prestation." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9776), "Informations de eTar." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9779), "enregistrement de type 52." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9781), "Total des prestations." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9784), "Total de facture." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9786), "Sous total par mutualité." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9834), "Total général de la facture." });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9837), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9839), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 6,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 7,
                column: "description",
                value: "numero de l'envoi");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 9,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 12,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 13,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 17,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 18,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 19,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 20,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 21,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 22,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 25,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 30,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 36,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 42,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 44,
                column: "description",
                value: "0 - réservé ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 55,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 56,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 57,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 58,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 59,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 60,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 61,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 130,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 134,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "description", "startPosition", "zoneNumber" },
                values: new object[] { "Année et mois de facturation", 191, "300" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 197, "3001" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "description", "startPosition", "zoneNumber", "zonelength" },
                values: new object[] { "Numéro d’envois ", 199, "301", 3 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 202, "3011" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "description", "startPosition", "zoneNumber", "zonelength" },
                values: new object[] { "Date de création de la facture", 204, "302", 8 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 212, "3021" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[] { "Référence facture (not used pour les hôpitaux)", 214, "303", "a-n", 13 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 227, "3031" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "description", "startPosition", "zoneNumber", "zonelength" },
                values: new object[] { "numéro de version des instructions", 229, "304", 7 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "startPosition", "zoneNumber", "zoneType" },
                values: new object[] { 236, "3041", "n" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "description", "startPosition", "zoneNumber", "zonelength" },
                values: new object[] { "Nom de la personne de contact", 238, "305", 45 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 283, "3051" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[] { "Prénom de la personne de contact", 285, "306", "n", 24 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1000,
                column: "description",
                value: "0 - réservé");

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "id", "RecordConfigId", "dateCreation", "dateUpdate", "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[,]
                {
                    { 572, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur( not used)", 309, "3061", "n", 2 },
                    { 573, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro de téléphone de la personne de contact", 311, "307", "n", 10 },
                    { 574, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 321, "3071", "n", 2 },
                    { 575, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type de facture", 323, "308", "n", 2 },
                    { 576, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 325, "3081", "n", 2 },
                    { 577, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type facturation", 327, "309", "n", 2 },
                    { 578, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 329, "3091", "n", 2 },
                    { 579, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réserve", 331, "310", "a-n", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 579);

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "id", "Description", "fileName", "fileUploadedContent", "size", "update_date", "upload_date" },
                values: new object[] { 1, "Test", "Test File", "testtes", 1.5f, new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8276), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8277), "message contenant le fichier de facturation transmis par le prestataire" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8301), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8302), "Enregistrement de type 10" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8305), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8306), "Identification du patient" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8308), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8309), "Données sur la prestation" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8311), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8312), "enregistrement de type 51" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8314), "enregistrement de type 52" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8316), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8316), "enregistrement de type 80" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8319), "enregistrement de type 90" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8322), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8322), "enregistrement de type 95" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate", "description" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8325), "enregistrement de type 96" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8326), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 6,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 7,
                column: "description",
                value: "enregist. de type 10");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 9,
                column: "description",
                value: "numero de l'envoi  ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 12,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 13,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 17,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 18,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 19,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 20,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 21,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 22,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 25,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 30,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 36,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 42,
                column: "description",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 44,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 55,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 56,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 57,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 58,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 59,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 60,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 61,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 130,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 134,
                column: "description",
                value: "0 ");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "description", "startPosition", "zoneNumber" },
                values: new object[] { "Nom du message", 124, "200" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 130, "2001" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "description", "startPosition", "zoneNumber", "zonelength" },
                values: new object[] { "N° version du format du message", 132, "201", 2 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 134, "2011" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "description", "startPosition", "zoneNumber", "zonelength" },
                values: new object[] { "Type de message", 136, "202", 2 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 138, "2021" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[] { "Statut du message", 140, "203", "a", 2 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 142, "2031" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "description", "startPosition", "zoneNumber", "zonelength" },
                values: new object[] { "Référence du message ( prestataire ou institution)", 144, "204", 14 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "startPosition", "zoneNumber", "zoneType" },
                values: new object[] { 158, "2041", "a" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "description", "startPosition", "zoneNumber", "zonelength" },
                values: new object[] { "Référence message OA", 160, "205", 14 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "startPosition", "zoneNumber" },
                values: new object[] { 174, "2051" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[] { "Réserve", 176, "206", "a-n", 15 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1000,
                column: "description",
                value: "0");
        }
    }
}
