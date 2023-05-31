using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedData900ToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "id", "dateCreation", "dateUpdate", "description", "messageCode" },
                values: new object[] { 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(8880), "Fichier décompte et rejets ", "920900" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9247), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9252), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9258), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9322), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9325), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9330), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9335), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9338), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9342), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9347), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9350), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9352), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9357), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9360), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9362), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9365), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9367), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "id", "MessageTypeId", "dateCreation", "dateUpdate", "description", "recordLength", "recordNumber", "recordPlacement" },
                values: new object[,]
                {
                    { 24, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9370), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9371), "Données sur la facture.", 800, "10", "body" },
                    { 25, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9373), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9373), "Informations du patient.", 800, "20", "body" },
                    { 26, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9377), "Informations du prestation.", 800, "50", "body" },
                    { 27, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9379), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9380), "Informations de eTar.", 800, "51", "body" },
                    { 28, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9382), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9383), "enregistrement de type 52.", 800, "52", "body" },
                    { 29, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9384), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9385), "Total des prestations.", 800, "80", "body" },
                    { 30, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9387), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9388), "Total de facture.", 800, "90", "footer" },
                    { 31, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9390), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9390), "Sous total par mutualité.", 800, "95", "footer" },
                    { 32, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9392), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9393), "Total général de la facture.", 800, "96", "footer" },
                    { 33, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9395), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9396), "Segment 200", 67, "200", "header" },
                    { 34, 3, new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9399), new DateTime(2023, 5, 24, 9, 47, 0, 324, DateTimeKind.Local).AddTicks(9400), "Segment 300", 160, "300", "header" }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "id", "RecordConfigId", "dateCreation", "dateUpdate", "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[,]
                {
                    { 1342, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregist. de type 10", 1, "1", "n", 2 },
                    { 1343, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 1344, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nombre numeros comptes financiers (code indice)", 9, "3", "n", 1 },
                    { 1345, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "version fichier", 10, "4", "n", 7 },
                    { 1346, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° compte financier a", 17, "5", "n", 8 },
                    { 1347, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 29, "6b", "n", 4 },
                    { 1348, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de l'envoi", 33, "7", "n", 3 },
                    { 1349, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° compte financier b ", 36, "8a", "n", 12 },
                    { 1350, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 48, "8b", "n", 1 },
                    { 1351, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code s.f.p ", 49, "9", "n", 1 },
                    { 1352, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code fichier de decompte ", 50, "10", "n", 1 },
                    { 1353, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 51, "11", "n", 1 },
                    { 1354, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 52, "12", "n", 1 },
                    { 1355, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "contenu facturation ", 53, "13", "n", 3 },
                    { 1356, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° tiers payant 0", 56, "14", "n", 12 },
                    { 1357, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° accreditation cin ", 68, "15", "n", 12 },
                    { 1358, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 80, "16", "n", 1 },
                    { 1359, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 81, "17", "n", 4 },
                    { 1360, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 85, "18", "n", 3 },
                    { 1361, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 88, "19", "n", 12 },
                    { 1362, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 100, "20", "n", 7 },
                    { 1363, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 107, "21", "n", 1 },
                    { 1364, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "annee facturee ", 108, "22", "n", 5 },
                    { 1365, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mois facture ", 113, "23", "n", 2 },
                    { 1366, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 115, "24", "n", 5 },
                    { 1367, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de creation ", 120, "25", "n", 7 },
                    { 1368, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de creation ", 127, "26", "n", 1 },
                    { 1369, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro BCE ", 128, "27", "n", 10 },
                    { 1370, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ref. etablissement ", 138, "28", "n", 25 },
                    { 1371, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 163, "29", "n", 2 },
                    { 1372, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 165, "30", "n", 2 },
                    { 1373, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 167, "31", "n", 8 },
                    { 1374, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 175, "32", "n", 1 },
                    { 1375, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 176, "33 ", "n", 1 },
                    { 1376, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 177, "34 ", "n", 1 },
                    { 1377, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 178, "35 ", "n", 1 },
                    { 1378, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a  ", 179, "36 ", "n", 1 },
                    { 1379, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a  ", 183, "38 ", "n", 12 },
                    { 1380, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a ", 195, "39 ", "n", 10 },
                    { 1381, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a ", 205, "40", "n", 2 },
                    { 1382, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a  ", 207, "41 ", "n", 6 },
                    { 1383, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 213, "42 ", "n", 6 },
                    { 1384, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier b  ", 219, "43a ", "n", 11 },
                    { 1385, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé ", 230, "43b ", "n", 1 },
                    { 1386, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 231, "44 ", "n", 4 },
                    { 1387, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 235, "45 ", "n", 26 },
                    { 1389, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 261, "46 ", "n", 1 },
                    { 1399, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 262, "47a ", "n", 7 },
                    { 1400, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 269, "47b ", "n", 1 },
                    { 1401, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 270, "48 ", "n", 1 },
                    { 1402, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b  ", 271, "49 ", "n", 12 },
                    { 1403, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b  ", 283, "50a ", "n", 3 },
                    { 1404, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b ", 286, "50b ", "n", 1 },
                    { 1405, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b ", 287, "51 ", "n", 6 },
                    { 1406, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b ", 293, "52 ", "n", 12 },
                    { 1407, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 205, "53 ", "n", 8 },
                    { 1408, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 313, "54a ", "n", 3 },
                    { 1409, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "-- ", 316, "54b ", "n", 1 },
                    { 1410, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "-- ", 317, "54c ", "n", 4 },
                    { 1411, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 321, "55 ", "n", 8 },
                    { 1412, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 329, "56 ", "n", 4 },
                    { 1413, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 333, "57 ", "n", 4 },
                    { 1414, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 337, "58 ", "n", 4 },
                    { 1415, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 341, "59 ", "n", 6 },
                    { 1416, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 347, "98 ", "n", 2 },
                    { 1417, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 349, "99 ", "n", 2 },
                    { 1418, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 1419, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création - OA", 354, "101", "n", 8 },
                    { 1420, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 362, "102", "n", 6 },
                    { 1421, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 368, "103", "n", 3 },
                    { 1422, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 371, "104", "n", 12 },
                    { 1423, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 383, "105", "n", 12 },
                    { 1424, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 395, "106", "n", 12 },
                    { 1425, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 407, "107", "n", 3 },
                    { 1426, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 410, "108", "n", 3 },
                    { 1427, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 413, "109", "n", 22 },
                    { 1428, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 435, "110", "n", 22 },
                    { 1429, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 1430, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 1431, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 1432, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 1433, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 1434, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 1435, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 478, "114", "n", 12 },
                    { 1436, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 490, "115", "n", 12 },
                    { 1437, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 502, "116", "n", 12 },
                    { 1438, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 514, "117", "n", 7 },
                    { 1439, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 521, "118", "n", 1 },
                    { 1440, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 522, "119", "n", 12 },
                    { 1441, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 534, "149", "n", 200 },
                    { 1442, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 734, "150a", "n", 12 },
                    { 1443, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 745, "150b", "n", 49 },
                    { 1444, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 795, "151", "n", 6 },
                    { 1445, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregistrement de type 20", 1, "1", "n", 2 },
                    { 1446, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 1447, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "autorisation tiers payant", 9, "3", "n", 1 },
                    { 1448, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "heure d'admission", 10, "4", "n", 7 },
                    { 1449, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date d'admission", 17, "5", "n", 8 },
                    { 1450, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de sortie (partie 1)", 25, "6a", "n", 4 },
                    { 1451, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de sortie (partie 2)", 29, "6b", "n", 4 },
                    { 1452, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite d'affiliation", 33, "7", "n", 3 },
                    { 1453, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire (partie 1)", 36, "8a", "n", 12 },
                    { 1454, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire (partie 2) ", 48, "8b", "n", 1 },
                    { 1455, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sexe beneficiaire", 49, "9", "a", 1 },
                    { 1456, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "type facture", 50, "10", "n", 1 },
                    { 1457, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "type de facturation", 51, "11", "n", 1 },
                    { 1458, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 52, "12", "n", 1 },
                    { 1459, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "service 721 bis", 53, "13", "n", 3 },
                    { 1460, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de l'etablissement qui facture ", 56, "14", "n", 12 },
                    { 1461, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "etablissement de sejour", 68, "15", "n", 12 },
                    { 1462, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code levee delai de prescription", 80, "16", "n", 1 },
                    { 1463, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "causes du traitement", 81, "17", "n", 4 },
                    { 1464, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite de destination", 85, "18", "n", 3 },
                    { 1465, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero d'admission", 88, "19", "n", 12 },
                    { 1466, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date accord traitement (partie 1)", 100, "20", "n", 7 },
                    { 1467, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date accord traitement (partie 2)", 107, "21", "n", 1 },
                    { 1468, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "heure de sortie", 108, "22", "n", 5 },
                    { 1469, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 113, "23", "n", 2 },
                    { 1470, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de la facture individuelle (partie 1) ", 115, "24", "n", 5 },
                    { 1471, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de la facture individuelle (partie 2)", 120, "25", "n", 7 },
                    { 1472, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "application franchise sociale", 127, "26", "n", 1 },
                    { 1473, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ct 1 + ct 2", 128, "27", "n", 10 },
                    { 1474, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference de l'etablissement", 138, "28", "n", 25 },
                    { 1475, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de facture precedente (partie 1)", 163, "29", "n", 2 },
                    { 1476, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de facture precedente (partie 2)", 165, "30", "n", 2 },
                    { 1477, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de facture precedente (partie 3)", 167, "31", "n", 8 },
                    { 1478, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "flag identification du beneficiaire", 175, "32 ", "n", 1 },
                    { 1479, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 176, "33 ", "n", 1 },
                    { 1480, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero envoi precedent (partie 1)", 177, "34 ", "n", 1 },
                    { 1481, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero envoi precedent (partie 2)", 178, "35 ", "n", 1 },
                    { 1482, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero envoi precedent (partie 3)", 179, "36 ", "n", 1 },
                    { 1483, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite facturation precedente", 180, "37 ", "n", 3 },
                    { 1484, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero de compte financier a (partie 1) ", 283, "38", "n", 12 },
                    { 1485, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero de compte financier a (partie 2) ", 295, "39 ", "n", 10 },
                    { 1486, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 205, "40 ", "n", 2 },
                    { 1487, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "annee et mois de facturation precedente", 207, "41 ", "n", 6 },
                    { 1488, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 1) ", 213, "42 ", "a", 6 },
                    { 1489, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 2) ", 219, "43a ", "n", 11 },
                    { 1490, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 3) ", 230, "43b ", "n", 1 },
                    { 1491, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 4) ", 231, "44 ", "n", 4 },
                    { 1492, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 5) ", 235, "45 ", "n", 26 },
                    { 1493, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 261, "46 ", "n", 1 },
                    { 1494, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de facturation (partie 1) ", 262, "47a ", "n", 7 },
                    { 1495, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de facturation (partie 2) ", 269, "47b ", "n", 1 },
                    { 1496, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 270, "48 ", "n", 1 },
                    { 1497, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero compte financier b (partie 1)", 271, "49 ", "n", 12 },
                    { 1498, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero compte financier b (partie 2)", 283, "50a ", "n", 3 },
                    { 1499, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero compte financier b (partie 2 bis)", 286, "50b ", "n", 1 },
                    { 1500, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero compte financier b (partie 3)", 287, "51 ", "n", 6 },
                    { 1501, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro d’admission de la mère", 293, "52 ", "n", 12 },
                    { 1502, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date debut assurabilite", 305, "53 ", "n", 8 },
                    { 1503, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date fin assurabilite (partie 1) ", 313, "54a ", "n", 3 },
                    { 1504, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date fin assurabilite (partie 2) ", 316, "54b ", "n", 1 },
                    { 1505, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date fin assurabilite (partie 3) ", 317, "54c ", "n", 4 },
                    { 1506, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date communication information", 321, "55 ", "n", 8 },
                    { 1507, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maf annee en cours  ", 329, "56 ", "n", 4 },
                    { 1508, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maf annee en cours -1  ", 333, "57 ", "n", 4 },
                    { 1509, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maf annee en cours -2 ", 337, "58 ", "n", 4 },
                    { 1510, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 341, "59 ", "n", 6 },
                    { 1511, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 347, "98 ", "n", 2 },
                    { 1512, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiffres de controle de l'enregistrement", 349, "99 ", "n", 2 },
                    { 1513, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 1514, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création Envoi", 354, "101", "n", 8 },
                    { 1515, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mois et année de facturation", 362, "102", "n", 6 },
                    { 1516, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mutualité", 368, "103", "n", 3 },
                    { 1517, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 371, "104", "n", 12 },
                    { 1518, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 383, "105", "n", 12 },
                    { 1519, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 395, "106", "n", 12 },
                    { 1520, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT1 ou 0", 407, "107", "n", 3 },
                    { 1521, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT2 ou 0", 410, "108", "n", 3 },
                    { 1522, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte A", 413, "109", "n", 22 },
                    { 1523, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte B", 435, "110", "n", 22 },
                    { 1524, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 1525, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 1526, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 1527, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 1528, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 1529, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 1530, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 478, "114", "n", 12 },
                    { 1531, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 490, "115", "n", 12 },
                    { 1532, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 502, "116", "n", 12 },
                    { 1533, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 514, "117", "n", 7 },
                    { 1534, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 521, "118", "n", 1 },
                    { 1535, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 522, "119", "n", 12 },
                    { 1536, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commentaire du code errer", 534, "149", "n", 200 },
                    { 1537, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 734, "150a", "n", 12 },
                    { 1538, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé", 745, "150b", "n", 49 },
                    { 1539, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Index", 795, "151", "n", 6 },
                    { 1540, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "type de record (95)", 1, "400", "n", 2 },
                    { 1541, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 3, "4001", "n", 2 },
                    { 1542, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro de mutualité", 5, "401", "n", 3 },
                    { 1543, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 8, "4011", "n", 2 },
                    { 1544, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro de facture récapitulative", 10, "402", "n", 12 },
                    { 1545, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 22, "4021", "n", 2 },
                    { 1546, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe montant demandé compte A", 24, "403", "a", 1 },
                    { 1547, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "montant demandé compte A", 25, "404", "n", 11 },
                    { 1548, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 36, "4041", "n", 2 },
                    { 1549, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe montant demandé compte B", 38, "405", "a", 1 },
                    { 1550, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "montant demandé compte B", 39, "406", "n", 11 },
                    { 1551, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 50, "4061", "n", 2 },
                    { 1552, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe montant demandé compte A + compte B + compte C", 52, "407", "a", 1 },
                    { 1553, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "total montants demandés compte A + compte B + compte C", 53, "408", "n", 11 },
                    { 1554, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 64, "4081", "n", 2 },
                    { 1555, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nombre d'enregistrements", 66, "409", "n", 8 },
                    { 1556, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 74, "4091", "n", 2 },
                    { 1557, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N° de contrôle par mutualité", 76, "410", "n", 2 },
                    { 1558, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 78, "4101", "n", 2 },
                    { 1559, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe montant demandé compte C", 80, "411", "a", 1 },
                    { 1560, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "montant demandé compte C", 81, "412", "n", 11 },
                    { 1561, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 92, "4121", "n", 2 },
                    { 1562, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 94, "413", "a-n", 257 },
                    { 1563, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 1564, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création Envoi", 354, "101", "n", 8 },
                    { 1565, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mois et année de facturation", 362, "102", "n", 6 },
                    { 1566, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mutualité", 368, "103", "n", 3 },
                    { 1567, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 371, "104", "n", 12 },
                    { 1568, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 383, "105", "n", 12 },
                    { 1569, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 395, "106", "n", 12 },
                    { 1570, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT1 ou 0", 407, "107", "n", 3 },
                    { 1571, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT2 ou 0", 410, "108", "n", 3 },
                    { 1572, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte A", 413, "109", "n", 22 },
                    { 1573, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte B", 435, "110", "n", 22 },
                    { 1574, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 1575, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 1576, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 1577, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 1578, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 1579, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 1580, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 478, "114", "n", 12 },
                    { 1581, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 490, "115", "n", 12 },
                    { 1582, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 502, "116", "n", 12 },
                    { 1583, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 514, "117", "n", 7 },
                    { 1584, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 521, "118", "n", 1 },
                    { 1585, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Résultat OA", 522, "119", "n", 12 },
                    { 1586, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commentaire du code errer", 534, "149", "n", 200 },
                    { 1587, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 734, "150a", "n", 12 },
                    { 1588, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé", 745, "150b", "n", 49 },
                    { 1589, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Index", 795, "151", "n", 6 },
                    { 1590, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregistrement de type 50", 1, "1", "n", 2 },
                    { 1591, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 1592, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "norme prestation (pourcentage)", 9, "3", "n", 1 },
                    { 1593, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code nomenclature ou pseudo-code nomenclature", 10, "4", "n", 7 },
                    { 1594, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date premiere prestation effectuee", 17, "5", "n", 8 },
                    { 1595, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date derniere prestation effectuee (partie 1)", 25, "6a", "n", 4 },
                    { 1596, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date derniere prestation effectuee (partie 2)", 29, "6b", "n", 4 },
                    { 1597, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite d'affiliation", 33, "7", "n", 3 },
                    { 1598, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire (partie 1)", 36, "8a", "n", 12 },
                    { 1599, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire (partie 2) ", 48, "8b", "n", 1 },
                    { 1600, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sexe beneficiaire", 49, "9", "a", 1 },
                    { 1601, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "accouchement", 50, "10", "n", 1 },
                    { 1602, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference numero compte financie", 51, "11", "n", 1 },
                    { 1603, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nuit, week-end, jour ferie", 52, "12", "n", 1 },
                    { 1604, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code service", 53, "13", "n", 3 },
                    { 1605, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lieu de prestation", 56, "14", "n", 12 },
                    { 1606, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification du dispensateur", 68, "15", "n", 12 },
                    { 1607, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "norme dispensateur", 80, "16", "n", 1 },
                    { 1608, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "prestation relative (partie 1)", 81, "17", "n", 4 },
                    { 1609, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "prestation relative (partie 2) ", 85, "18", "n", 3 },
                    { 1610, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + montant intervention de l'assurance", 88, "19", "n", 12 },
                    { 1611, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date prescription (partie 1)", 100, "20", "n", 7 },
                    { 1612, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date prescription (partie 2)", 107, "21", "n", 1 },
                    { 1613, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + nombre d'unites", 108, "22", "n", 5 },
                    { 1614, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dérogation nombre maximal ou prestation identique", 113, "23", "n", 2 },
                    { 1615, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification prescripteur (partie 1)", 115, "24", "n", 5 },
                    { 1616, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification prescripteur (partie 2)", 120, "25", "n", 7 },
                    { 1617, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "norme prescripteur", 127, "26", "n", 1 },
                    { 1618, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + intervention personnelle patient", 128, "27", "n", 10 },
                    { 1619, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference de l'etablissement", 138, "28", "n", 25 },
                    { 1620, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dent traitee", 163, "29", "n", 2 },
                    { 1621, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + montant supplement (partie 1)", 165, "30", "n", 2 },
                    { 1622, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "montant supplement (partie 2)", 167, "31", "n", 8 },
                    { 1623, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "exception tiers payant", 175, "32 ", "n", 1 },
                    { 1624, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code facturation intervention personnelle ou supplement", 176, "33 ", "n", 1 },
                    { 1625, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "membre traite", 177, "34 ", "n", 1 },
                    { 1626, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "prestataire conventionne", 178, "35 ", "n", 1 },
                    { 1627, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "heure de prestation(partie 1)", 179, "36 ", "n", 1 },
                    { 1628, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "heure de prestation (partie 2)", 180, "37 ", "n", 3 },
                    { 1629, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification administrateur du sang", 183, "38", "n", 12 },
                    { 1630, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de l'attestation d'administration (partie 1)", 195, "39 ", "n", 10 },
                    { 1631, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de l'attestation d'administration (partie 2)", 205, "40 ", "n", 2 },
                    { 1632, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero bon de delivrance ou sac (partie 1)", 207, "41 ", "n", 6 },
                    { 1633, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero bon de delivrance ou sac (partie 2)", 213, "42 ", "a", 6 },
                    { 1634, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code implant (partie 1) ", 219, "43a ", "n", 11 },
                    { 1635, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code implant (partie 2)", 230, "43b ", "n", 1 },
                    { 1636, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "libelle du produit (partie 1)", 231, "44 ", "n", 4 },
                    { 1637, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "libelle du produit (partie 2) ", 235, "45 ", "n", 26 },
                    { 1638, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "norme plafond  ", 261, "46 ", "n", 1 },
                    { 1639, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valeur de base prestation", 262, "47 ", "n", 8 },
                    { 1640, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "transplantation", 270, "48 ", "n", 1 },
                    { 1641, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification du dispensateur auxiliaire", 271, "49 ", "n", 12 },
                    { 1642, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "pourcentage dans le forfait", 283, "50a ", "n", 3 },
                    { 1643, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 286, "50b ", "n", 1 },
                    { 1644, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "site hospitalier", 287, "51 ", "n", 6 },
                    { 1645, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification association bassin de soins", 293, "52 ", "n", 12 },
                    { 1646, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de course (partie 1)", 305, "53 ", "n", 8 },
                    { 1647, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de course (partie 2)", 313, "54a ", "n", 3 },
                    { 1648, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "flag GPS ", 316, "54b ", "n", 1 },
                    { 1649, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 317, "54c ", "n", 4 },
                    { 1650, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code notification implant (partie 1)", 321, "55 ", "n", 8 },
                    { 1651, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code notification implant (partie 2)", 329, "56 ", "n", 4 },
                    { 1652, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code d’enregistrement (partie 1)", 333, "57 ", "n", 4 },
                    { 1653, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code d’enregistrement (partie 2) ", 337, "58 ", "n", 4 },
                    { 1654, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code d’enregistrement (partie 3) ", 341, "59 ", "n", 6 },
                    { 1655, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "flag TVA ", 347, "98 ", "n", 2 },
                    { 1656, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiffres de controle de l'enregistrement ", 349, "99 ", "n", 2 },
                    { 1657, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 1658, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création Envoi", 354, "101", "n", 8 },
                    { 1659, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mois et année de facturation", 362, "102", "n", 6 },
                    { 1660, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mutualité", 368, "103", "n", 3 },
                    { 1661, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 371, "104", "n", 12 },
                    { 1662, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 383, "105", "n", 12 },
                    { 1663, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 395, "106", "n", 12 },
                    { 1664, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT1", 407, "107", "n", 3 },
                    { 1665, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT2", 410, "108", "n", 3 },
                    { 1666, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte A", 413, "109", "n", 22 },
                    { 1667, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte B", 435, "110", "n", 22 },
                    { 1668, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 1669, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 1670, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 1671, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 1672, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 1673, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 1674, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 478, "114", "n", 12 },
                    { 1675, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 490, "115", "n", 12 },
                    { 1676, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 502, "116", "n", 12 },
                    { 1677, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code nomenclature corrigé", 514, "117", "n", 7 },
                    { 1678, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 521, "118", "n", 1 },
                    { 1679, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Résultat OA", 522, "119", "n", 12 },
                    { 1680, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commentaire du code errer", 534, "149", "n", 200 },
                    { 1681, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montant Tarifié Compte C", 734, "150a", "n", 12 },
                    { 1682, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé", 745, "150b", "n", 49 },
                    { 1683, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Index", 795, "151", "n", 6 },
                    { 1684, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregistrement de type 51", 1, "1", "n", 2 },
                    { 1685, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 1686, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 9, "3", "n", 1 },
                    { 1687, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code nomenclature ou pseudo-code nomenclature", 10, "4", "n", 7 },
                    { 1688, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date prestation", 17, "5", "n", 8 },
                    { 1689, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 25, "6a", "n", 4 },
                    { 1690, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 29, "6b", "n", 4 },
                    { 1691, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 33, "7", "n", 3 },
                    { 1692, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire", 36, "8a", "n", 12 },
                    { 1693, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire ", 48, "8b", "n", 1 },
                    { 1694, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 49, "9", "a", 1 },
                    { 1695, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 50, "10", "n", 1 },
                    { 1696, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 51, "11", "n", 1 },
                    { 1697, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 52, "12", "n", 1 },
                    { 1698, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 53, "13", "n", 3 },
                    { 1699, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 56, "14", "n", 12 },
                    { 1700, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification du dispensateur", 68, "15", "n", 12 },
                    { 1701, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 80, "16", "n", 1 },
                    { 1702, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "prestation relative", 81, "17", "n", 4 },
                    { 1703, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "prestation relative ", 85, "18", "n", 3 },
                    { 1704, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + montant intervention de l'assurance", 88, "19", "n", 12 },
                    { 1705, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 100, "20", "n", 7 },
                    { 1706, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 107, "21", "n", 1 },
                    { 1707, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 108, "22", "n", 5 },
                    { 1708, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 113, "23", "n", 2 },
                    { 1709, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 115, "24", "n", 5 },
                    { 1710, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 120, "25", "n", 7 },
                    { 1711, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 127, "26", "n", 1 },
                    { 1712, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 128, "27", "n", 10 },
                    { 1713, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 138, "28", "n", 25 },
                    { 1714, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 163, "29", "n", 2 },
                    { 1715, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 165, "30", "n", 2 },
                    { 1716, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 167, "31", "n", 8 },
                    { 1717, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 175, "32 ", "n", 1 },
                    { 1718, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 176, "33 ", "n", 1 },
                    { 1719, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 177, "34 ", "n", 1 },
                    { 1720, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 178, "35 ", "n", 1 },
                    { 1721, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 179, "36 ", "n", 1 },
                    { 1722, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 180, "37 ", "n", 3 },
                    { 1723, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification administrateur du sang", 183, "38", "n", 12 },
                    { 1724, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 195, "39 ", "n", 10 },
                    { 1725, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 205, "40 ", "n", 2 },
                    { 1726, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 207, "41 ", "n", 6 },
                    { 1727, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " numéro d’agrément engagement de tarif", 213, "42 ", "a", 6 },
                    { 1728, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro d’agrément engagement de tarif ", 219, "43a ", "n", 11 },
                    { 1729, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro d’agrément engagement de tarif", 230, "43b ", "n", 1 },
                    { 1730, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro d’agrément engagement de tarif", 231, "44 ", "n", 4 },
                    { 1731, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro d’agrément engagement de tarif ", 235, "45 ", "n", 26 },
                    { 1732, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 261, "46 ", "n", 1 },
                    { 1733, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 262, "47a", "n", 7 },
                    { 1734, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 269, "47b", "n", 1 },
                    { 1735, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 270, "48 ", "n", 1 },
                    { 1736, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 271, "49 ", "n", 12 },
                    { 1737, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 283, "50a ", "n", 3 },
                    { 1738, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 286, "50b ", "n", 1 },
                    { 1739, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 287, "51 ", "n", 6 },
                    { 1740, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 293, "52 ", "n", 12 },
                    { 1741, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 305, "53 ", "n", 8 },
                    { 1742, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 313, "54a ", "n", 3 },
                    { 1743, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 316, "54b ", "n", 1 },
                    { 1744, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 317, "54c ", "n", 4 },
                    { 1745, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date communication information", 321, "55 ", "n", 8 },
                    { 1746, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 329, "56 ", "n", 4 },
                    { 1747, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 333, "57 ", "n", 4 },
                    { 1748, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 337, "58 ", "n", 4 },
                    { 1749, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 341, "59 ", "n", 6 },
                    { 1750, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 347, "98 ", "n", 2 },
                    { 1751, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiffres de contrôle de l’enregistrement ", 349, "99 ", "n", 2 },
                    { 1752, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 1753, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création Envoi", 354, "101", "n", 8 },
                    { 1754, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mois et année de facturation", 362, "102", "n", 6 },
                    { 1755, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mutualité", 368, "103", "n", 3 },
                    { 1756, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 371, "104", "n", 12 },
                    { 1757, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 383, "105", "n", 12 },
                    { 1758, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 395, "106", "n", 12 },
                    { 1759, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT1 ou 0", 407, "107", "n", 3 },
                    { 1760, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT2 ou 0", 410, "108", "n", 3 },
                    { 1761, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte A", 413, "109", "n", 22 },
                    { 1762, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte B", 435, "110", "n", 22 },
                    { 1763, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 1764, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 1765, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 1766, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 1767, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 1768, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 1769, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 478, "114", "n", 12 },
                    { 1770, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 490, "115", "n", 12 },
                    { 1771, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 502, "116", "n", 12 },
                    { 1772, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 514, "117", "n", 7 },
                    { 1773, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 521, "118", "n", 1 },
                    { 1774, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Résultat OA", 522, "119", "n", 12 },
                    { 1775, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commentaire du code errer", 534, "149", "n", 200 },
                    { 1776, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 734, "150a", "n", 12 },
                    { 1777, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé", 745, "150b", "n", 49 },
                    { 1778, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Index", 795, "151", "n", 6 },
                    { 1779, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enregistrement de type 52", 1, "1", "n", 2 },
                    { 1780, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro d'ordre de l'enregistrement", 3, "2", "n", 6 },
                    { 1781, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raison encodage manuel", 9, "3", "n", 1 },
                    { 1782, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code nomenclature ", 10, "4", "n", 7 },
                    { 1783, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date de prestation", 17, "5", "n", 8 },
                    { 1784, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date de lecture document identité", 25, "6a", "n", 4 },
                    { 1785, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date de lecture document identité", 29, "6b", "n", 4 },
                    { 1786, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 33, "7", "n", 3 },
                    { 1787, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro NISS du patient sauf en cas de convention internationale ou nouveau né", 36, "8a", "n", 12 },
                    { 1788, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro NISS du patient sauf en cas de convention internationale ou nouveau né", 48, "8b", "n", 1 },
                    { 1789, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type de saisie document identité", 49, "9", "n", 1 },
                    { 1790, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type de support document identité", 50, "10", "n", 1 },
                    { 1791, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raison utilisation vignette", 51, "11", "n", 1 },
                    { 1792, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heure de lecture document identité", 52, "12", "n", 1 },
                    { 1793, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heure de lecture document identité", 53, "13", "n", 3 },
                    { 1794, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 56, "14", "n", 12 },
                    { 1795, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro INAMI", 68, "15", "n", 12 },
                    { 1796, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro de série du support", 80, "16", "n", 15 },
                    { 1797, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro document justificatif", 95, "17", "n", 25 },
                    { 1798, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro unique appareil imagerie médicale", 120, "18", "n", 12 },
                    { 1799, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 132, "19-98", "n", 217 },
                    { 1800, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enregistrement chiffres de contrôle", 349, "99", "n", 2 },
                    { 1801, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 1802, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création Envoi", 354, "101", "n", 8 },
                    { 1803, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mois et année de facturation", 362, "102", "n", 6 },
                    { 1804, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mutualité", 368, "103", "n", 3 },
                    { 1805, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 371, "104", "n", 12 },
                    { 1806, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 383, "105", "n", 12 },
                    { 1807, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 395, "106", "n", 12 },
                    { 1809, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT1 ou 0", 407, "107", "n", 3 },
                    { 1810, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT2 ou 0", 410, "108", "n", 3 },
                    { 1811, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte A", 413, "109", "n", 22 },
                    { 1812, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte B", 435, "110", "n", 22 },
                    { 1813, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 1814, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 1815, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 1816, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 1817, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 1819, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 1820, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 478, "114", "n", 12 },
                    { 1821, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 490, "115", "n", 12 },
                    { 1822, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 502, "116", "n", 12 },
                    { 1823, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 514, "117", "n", 7 },
                    { 1824, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 521, "118", "n", 1 },
                    { 1825, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Résultat OA", 522, "119", "n", 12 },
                    { 1826, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commentaire du code errer", 534, "149", "n", 200 },
                    { 1827, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 734, "150a", "n", 12 },
                    { 1828, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé", 745, "150b", "n", 49 },
                    { 1829, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Index", 795, "151", "n", 6 },
                    { 1830, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregistrement de type 80", 1, "1", "n", 2 },
                    { 1831, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 1832, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 9, "3", "n", 1 },
                    { 1833, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "heure d'admission", 10, "4", "n", 7 },
                    { 1834, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date d'admission", 17, "5", "n", 8 },
                    { 1835, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de sortie (partie 1)", 25, "6a", "n", 4 },
                    { 1836, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de sortie (partie 2)", 29, "6b", "n", 4 },
                    { 1837, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite d'affiliation", 33, "7", "n", 3 },
                    { 1838, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire (partie 1)", 36, "8a", "n", 12 },
                    { 1839, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire (partie 2) ", 48, "8b", "n", 1 },
                    { 1840, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sexe beneficiaire", 49, "9", "a", 1 },
                    { 1841, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "accouchement", 50, "10", "n", 1 },
                    { 1842, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 51, "11", "n", 1 },
                    { 1843, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 52, "12", "n", 1 },
                    { 1844, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "service 721 bis", 53, "13", "n", 3 },
                    { 1845, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de l'etablissement qui facture", 56, "14", "n", 12 },
                    { 1846, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + montant numero de compte financier b", 68, "15", "n", 12 },
                    { 1847, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 80, "16", "n", 1 },
                    { 1848, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "causes du traitement", 81, "17", "n", 4 },
                    { 1849, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite de destination ", 85, "18", "n", 3 },
                    { 1850, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + montant numero de compte financier a", 88, "19", "n", 12 },
                    { 1851, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de la facture (partie 1)", 100, "20", "n", 7 },
                    { 1852, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date prescription (partie 2)", 107, "21", "n", 1 },
                    { 1853, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "heure de sortie\r\n", 108, "22", "n", 5 },
                    { 1854, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 113, "23", "n", 2 },
                    { 1855, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification prescripteur (partie 1)", 115, "24", "n", 5 },
                    { 1856, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification prescripteur (partie 2)", 120, "25", "n", 7 },
                    { 1857, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 127, "26", "n", 1 },
                    { 1858, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + intervention personnelle patient", 128, "27", "n", 10 },
                    { 1859, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference de l'etablissement", 138, "28", "n", 25 },
                    { 1860, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 163, "29", "n", 2 },
                    { 1861, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + montant supplement (partie 1)", 165, "30", "n", 2 },
                    { 1862, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "montant supplement (partie 2)", 167, "31", "n", 8 },
                    { 1863, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "flag identification du beneficiaire", 175, "32 ", "n", 1 },
                    { 1864, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 176, "33 ", "n", 1 },
                    { 1865, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 177, "34 ", "n", 1 },
                    { 1866, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 178, "35 ", "n", 1 },
                    { 1867, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 179, "36 ", "n", 1 },
                    { 1868, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 180, "37 ", "n", 3 },
                    { 1869, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + acompte numero compte financier a", 183, "38", "n", 12 },
                    { 1870, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 195, "39 ", "n", 10 },
                    { 1871, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 205, "40 ", "n", 2 },
                    { 1872, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 207, "41 ", "n", 6 },
                    { 1873, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 213, "42 ", "a", 6 },
                    { 1874, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 219, "43a ", "n", 11 },
                    { 1875, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 230, "43b ", "n", 1 },
                    { 1876, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 231, "44 ", "n", 4 },
                    { 1877, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 235, "45 ", "n", 26 },
                    { 1878, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 261, "46 ", "n", 1 },
                    { 1879, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 262, "47a ", "n", 7 },
                    { 1880, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 269, "47b ", "n", 1 },
                    { 1881, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 270, "48 ", "n", 1 },
                    { 1882, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 271, "49 ", "n", 12 },
                    { 1883, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 283, "50a ", "n", 3 },
                    { 1884, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 286, "50b ", "n", 1 },
                    { 1885, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 287, "51 ", "n", 6 },
                    { 1886, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 293, "52 ", "n", 12 },
                    { 1887, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 305, "53 ", "n", 8 },
                    { 1888, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 313, "54a ", "n", 3 },
                    { 1889, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 316, "54b ", "n", 1 },
                    { 1890, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 317, "54c ", "n", 4 },
                    { 1891, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé (réforme de l’état)", 321, "55 ", "n", 8 },
                    { 1892, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé (réforme de l’état)", 329, "56 ", "n", 4 },
                    { 1893, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 333, "57 ", "n", 4 },
                    { 1894, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 337, "58 ", "n", 4 },
                    { 1895, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 341, "59 ", "n", 6 },
                    { 1896, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiffres de controle de la facture", 347, "98 ", "n", 2 },
                    { 1897, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiffres de controle de l'enregistrement", 349, "99 ", "n", 2 },
                    { 1898, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 1899, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création Envoi", 354, "101", "n", 8 },
                    { 1900, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mois et année de facturation", 362, "102", "n", 6 },
                    { 1901, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mutualité", 368, "103", "n", 3 },
                    { 1902, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 371, "104", "n", 12 },
                    { 1903, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 383, "105", "n", 12 },
                    { 1904, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 395, "106", "n", 12 },
                    { 1905, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT1 ou 0", 407, "107", "n", 3 },
                    { 1906, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT2 ou 0", 410, "108", "n", 3 },
                    { 1907, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte A", 413, "109", "n", 22 },
                    { 1908, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte B", 435, "110", "n", 22 },
                    { 1909, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 2000, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 2001, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 2002, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 2003, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 2004, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 2005, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 478, "114", "n", 12 },
                    { 2006, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 490, "115", "n", 12 },
                    { 2007, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 502, "116", "n", 12 },
                    { 2008, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 514, "117", "n", 7 },
                    { 2009, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 521, "118", "n", 1 },
                    { 2010, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Résultat OA", 522, "119", "n", 12 },
                    { 2011, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commentaire du code errer", 534, "149", "n", 200 },
                    { 2012, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 734, "150a", "n", 12 },
                    { 2013, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé", 745, "150b", "n", 49 },
                    { 2014, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Index", 795, "151", "n", 6 },
                    { 2015, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregistrement de type 90", 1, "1", "n", 2 },
                    { 2016, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 2017, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 9, "3", "n", 1 },
                    { 2018, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 10, "4", "n", 7 },
                    { 2019, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero compte financier a (partie 1)", 17, "5", "n", 8 },
                    { 2020, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero compte financier a (partie 2)", 25, "6a", "n", 4 },
                    { 2021, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 29, "6b", "n", 4 },
                    { 2022, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero d'envoi", 33, "7", "n", 3 },
                    { 2023, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero compte financier b", 36, "8a", "n", 12 },
                    { 2024, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 48, "8b", "n", 1 },
                    { 2025, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 49, "9", "a", 1 },
                    { 2026, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 50, "10", "n", 1 },
                    { 2027, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 51, "11", "n", 1 },
                    { 2028, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 52, "12", "n", 1 },
                    { 2029, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 53, "13", "n", 3 },
                    { 2030, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero tiers payant", 56, "14", "n", 12 },
                    { 2031, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + montant total numero compte financier b", 68, "15", "n", 12 },
                    { 2032, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 80, "16", "n", 1 },
                    { 2033, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 81, "17", "n", 4 },
                    { 2034, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 85, "18", "n", 3 },
                    { 2035, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "signe + montant numero de compte financier a", 88, "19", "n", 12 },
                    { 2036, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 100, "20", "n", 7 },
                    { 2037, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 107, "21", "n", 1 },
                    { 2038, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "annee facturee", 108, "22", "n", 5 },
                    { 2039, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mois facture", 113, "23", "n", 2 },
                    { 2040, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 115, "24", "n", 5 },
                    { 2041, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 120, "25", "n", 7 },
                    { 2042, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 127, "26", "n", 1 },
                    { 2043, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro BCE", 128, "27", "n", 10 },
                    { 2044, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference de l'etablissement", 138, "28", "n", 25 },
                    { 2045, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 163, "29", "n", 2 },
                    { 2046, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 165, "30", "n", 2 },
                    { 2047, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier a (partie 1)", 167, "31", "n", 8 },
                    { 2048, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier a (partie 2)", 175, "32 ", "n", 1 },
                    { 2049, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier a (partie 3)", 176, "33 ", "n", 1 },
                    { 2050, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier a (partie 4)", 177, "34 ", "n", 1 },
                    { 2051, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 178, "35 ", "n", 1 },
                    { 2052, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a (partie 1)", 179, "36 ", "n", 1 },
                    { 2053, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a (partie 2)", 180, "37 ", "n", 3 },
                    { 2054, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a (partie 3)", 183, "38", "n", 12 },
                    { 2055, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a (partie 4)", 195, "39 ", "n", 10 },
                    { 2056, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a (partie 5)", 205, "40 ", "n", 2 },
                    { 2057, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a (partie 6)", 207, "41 ", "n", 6 },
                    { 2058, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 213, "42 ", "a", 6 },
                    { 2059, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier b", 219, "43a ", "n", 11 },
                    { 2060, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 230, "43b ", "n", 1 },
                    { 2061, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 231, "44 ", "n", 4 },
                    { 2062, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 235, "45 ", "n", 26 },
                    { 2063, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 261, "46 ", "n", 1 },
                    { 2064, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 262, "47a ", "n", 7 },
                    { 2065, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 269, "47b ", "n", 1 },
                    { 2066, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé (réforme de l’état)", 270, "48 ", "n", 1 },
                    { 2067, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé (réforme de l’état)", 271, "49 ", "n", 12 },
                    { 2068, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé (réforme de l’état)", 283, "50a ", "n", 3 },
                    { 2069, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 286, "50b ", "n", 1 },
                    { 2070, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 287, "51 ", "n", 6 },
                    { 2071, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b (partie 1)", 293, "52 ", "n", 12 },
                    { 2072, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b (partie 2)", 305, "53 ", "n", 8 },
                    { 2073, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b (partie 2 bis) ", 313, "54a ", "n", 3 },
                    { 2074, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b (partie 3)", 316, "54b ", "n", 1 },
                    { 2075, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b (partie 4)", 317, "54c ", "n", 4 },
                    { 2076, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé (réforme de l’état)", 321, "55 ", "n", 8 },
                    { 2077, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé (réforme de l’état)", 329, "56 ", "n", 4 },
                    { 2078, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 333, "57 ", "n", 4 },
                    { 2079, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 337, "58 ", "n", 4 },
                    { 2080, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 341, "59 ", "n", 6 },
                    { 2081, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiffres de controle de l'envoi", 347, "98 ", "n", 2 },
                    { 2082, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiffres de controle de l'enregistrement", 349, "99 ", "n", 2 },
                    { 2083, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 2084, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création Envoi", 354, "101", "n", 8 },
                    { 2085, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mois et année de facturation", 362, "102", "n", 6 },
                    { 2086, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mutualité", 368, "103", "n", 3 },
                    { 2087, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 371, "104", "n", 12 },
                    { 2089, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 383, "105", "n", 12 },
                    { 2090, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 395, "106", "n", 12 },
                    { 2091, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT1 ou 0", 407, "107", "n", 3 },
                    { 2092, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CT2 ou 0", 410, "108", "n", 3 },
                    { 2093, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte A", 413, "109", "n", 22 },
                    { 2094, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence OA Compte B", 435, "110", "n", 22 },
                    { 2095, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 2096, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 2097, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 2098, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 2099, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 2100, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 2101, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 478, "114", "n", 12 },
                    { 2102, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 490, "115", "n", 12 },
                    { 2103, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 502, "116", "n", 12 },
                    { 2104, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 514, "117", "n", 7 },
                    { 2105, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 521, "118", "n", 1 },
                    { 2106, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Résultat OA", 522, "119", "n", 12 },
                    { 2107, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commentaire du code errer", 534, "149", "n", 200 },
                    { 2108, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 734, "150a", "n", 12 },
                    { 2109, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "réservé", 745, "150b", "n", 49 },
                    { 2110, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Index", 795, "151", "n", 6 },
                    { 2111, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nom du message", 124, "200", "n", 6 },
                    { 2112, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 130, "2001", "n", 2 },
                    { 2113, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N° version du format du message", 132, "201", "n", 2 },
                    { 2114, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 134, "2011", "n", 2 },
                    { 2115, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type de message", 136, "202", "n", 2 },
                    { 2116, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 138, "2021", "n", 2 },
                    { 2117, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Statut du message", 140, "203", "a", 2 },
                    { 2118, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 142, "2031", "n", 2 },
                    { 2119, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence du message ( prestataire ou institution)", 144, "204", "n", 14 },
                    { 2120, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 158, "2041", "a", 2 },
                    { 2121, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence message OA", 160, "205", "n", 14 },
                    { 2122, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 174, "2051", "n", 2 },
                    { 2123, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réserve", 176, "206", "a-n", 15 },
                    { 2124, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Année et mois de facturation", 191, "300", "n", 6 },
                    { 2125, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 197, "3001", "n", 2 },
                    { 2126, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro d’envois ", 199, "301", "n", 3 },
                    { 2127, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 202, "3011", "n", 2 },
                    { 2128, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date de création de la facture", 204, "302", "n", 8 },
                    { 2129, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 212, "3021", "n", 2 },
                    { 2130, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référence facture (not used pour les hôpitaux)", 214, "303", "a-n", 13 },
                    { 2131, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 227, "3031", "n", 2 },
                    { 2132, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro de version des instructions", 229, "304", "n", 7 },
                    { 2133, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 236, "3041", "n", 2 },
                    { 2134, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nom de la personne de contact", 238, "305", "n", 45 },
                    { 2135, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 283, "3051", "n", 2 },
                    { 2136, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prénom de la personne de contact", 285, "306", "n", 24 },
                    { 2137, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur( not used)", 309, "3061", "n", 2 },
                    { 2138, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro de téléphone de la personne de contact", 311, "307", "n", 10 },
                    { 2139, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 321, "3071", "n", 2 },
                    { 2140, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type de facture", 323, "308", "n", 2 },
                    { 2141, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 325, "3081", "n", 2 },
                    { 2142, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Type facturation", 327, "309", "n", 2 },
                    { 2143, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code erreur", 329, "3091", "n", 2 },
                    { 2144, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réserve", 331, "310", "a-n", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 3);

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
        }
    }
}
