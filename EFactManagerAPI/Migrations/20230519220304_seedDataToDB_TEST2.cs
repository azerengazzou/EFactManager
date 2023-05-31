using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedDataToDB_TEST2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(5955), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6659), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6663), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6666), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6673), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6677), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6680), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6684), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6687), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6693), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6728), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6732), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6738), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6753), new DateTime(2023, 5, 19, 23, 2, 59, 521, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "id", "RecordConfigId", "dateCreation", "dateUpdate", "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[,]
                {
                    { 1308, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nom du message", 124, "200", "n", 6 },
                    { 1309, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 130, "2001", "n", 2 },
                    { 1310, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N° version du format du message", 132, "201", "n", 2 },
                    { 1311, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 134, "2011", "n", 2 },
                    { 1312, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type de message", 136, "202", "n", 2 },
                    { 1313, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 138, "2021", "n", 2 },
                    { 1314, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Statut du message", 140, "203", "a", 2 },
                    { 1315, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 142, "2031", "n", 2 },
                    { 1316, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence du message ( prestataire ou institution)", 144, "204", "n", 14 },
                    { 1317, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 158, "2041", "a", 2 },
                    { 1318, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence message OA", 160, "205", "n", 14 },
                    { 1319, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 174, "2051", "n", 2 },
                    { 1320, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réserve", 176, "206", "a-n", 15 },
                    { 1321, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Année et mois de facturation", 191, "300", "n", 6 },
                    { 1322, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 197, "3001", "n", 2 },
                    { 1323, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro d’envois ", 199, "301", "n", 3 },
                    { 1324, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 202, "3011", "n", 2 },
                    { 1325, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date de création de la facture", 204, "302", "n", 8 },
                    { 1326, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 212, "3021", "n", 2 },
                    { 1327, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence facture (not used pour les hôpitaux)", 214, "303", "a-n", 13 },
                    { 1328, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 227, "3031", "n", 2 },
                    { 1329, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro de version des instructions", 229, "304", "n", 7 },
                    { 1330, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 236, "3041", "n", 2 },
                    { 1331, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nom de la personne de contact", 238, "305", "n", 45 },
                    { 1332, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 283, "3051", "n", 2 },
                    { 1333, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prénom de la personne de contact", 285, "306", "n", 24 },
                    { 1334, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur( not used)", 309, "3061", "n", 2 },
                    { 1335, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro de téléphone de la personne de contact", 311, "307", "n", 10 },
                    { 1336, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 321, "3071", "n", 2 },
                    { 1337, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type de facture", 323, "308", "n", 2 },
                    { 1338, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 325, "3081", "n", 2 },
                    { 1339, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type facturation", 327, "309", "n", 2 },
                    { 1340, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 329, "3091", "n", 2 },
                    { 1341, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réserve", 331, "310", "a-n", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1341);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4165), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4547), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4552), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4573), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4583), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4598), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 5, 19, 20, 18, 37, 235, DateTimeKind.Local).AddTicks(4605) });
        }
    }
}
