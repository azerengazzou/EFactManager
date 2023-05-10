using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class newDataToDB_ErrorMSG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(7634), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8148), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8160), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8163), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8167), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8170), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8173), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8177), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8180), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8183), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8187), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "id", "MessageTypeId", "dateCreation", "dateUpdate", "description", "recordLength", "recordNumber", "recordPlacement" },
                values: new object[,]
                {
                    { 13, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8192), "Données sur la facture.", 800, "10", "body" },
                    { 14, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8195), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8196), "Informations du patient.", 800, "20", "body" },
                    { 15, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8198), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8199), "Informations du prestation.", 800, "50", "body" },
                    { 16, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8202), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8202), "Informations de eTar.", 800, "51", "body" },
                    { 17, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8205), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8206), "enregistrement de type 52.", 800, "52", "body" },
                    { 18, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8208), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8209), "Total des prestations.", 800, "80", "body" },
                    { 19, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8211), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8212), "Total de facture.", 800, "90", "footer" },
                    { 20, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8215), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8215), "Sous total par mutualité.", 800, "95", "footer" },
                    { 21, 2, new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8218), new DateTime(2023, 5, 2, 16, 35, 58, 372, DateTimeKind.Local).AddTicks(8219), "Total général de la facture.", 800, "96", "footer" }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "id", "RecordConfigId", "dateCreation", "dateUpdate", "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[,]
                {
                    { 580, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregist. de type 10", 1, "1", "n", 2 },
                    { 581, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 582, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nombre numeros comptes financiers (code indice)", 9, "3", "n", 1 },
                    { 583, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "version fichier", 10, "4", "n", 7 },
                    { 584, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° compte financier a", 17, "5", "n", 8 },
                    { 585, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 29, "6b", "n", 4 },
                    { 586, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de l'envoi", 33, "7", "n", 3 },
                    { 587, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° compte financier b ", 36, "8a", "n", 12 },
                    { 588, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 48, "8b", "n", 1 },
                    { 589, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code s.f.p ", 49, "9", "n", 1 },
                    { 590, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code fichier de decompte ", 50, "10", "n", 1 },
                    { 591, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 51, "11", "n", 1 },
                    { 592, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 52, "12", "n", 1 },
                    { 593, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "contenu facturation ", 53, "13", "n", 3 },
                    { 594, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° tiers payant 0", 56, "14", "n", 12 },
                    { 595, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° accreditation cin ", 68, "15", "n", 12 },
                    { 596, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 80, "16", "n", 1 },
                    { 597, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 81, "17", "n", 4 },
                    { 598, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 85, "18", "n", 3 },
                    { 599, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 88, "19", "n", 12 },
                    { 600, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 100, "20", "n", 7 },
                    { 601, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 107, "21", "n", 1 },
                    { 602, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "annee facturee ", 108, "22", "n", 5 },
                    { 603, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mois facture ", 113, "23", "n", 2 },
                    { 604, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 115, "24", "n", 5 },
                    { 605, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de creation ", 120, "25", "n", 7 },
                    { 606, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de creation ", 127, "26", "n", 1 },
                    { 607, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro BCE ", 128, "27", "n", 10 },
                    { 608, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ref. etablissement ", 138, "28", "n", 25 },
                    { 609, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 163, "29", "n", 2 },
                    { 610, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 165, "30", "n", 2 },
                    { 611, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 167, "31", "n", 8 },
                    { 612, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 175, "32", "n", 1 },
                    { 613, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 176, "33 ", "n", 1 },
                    { 614, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 177, "34 ", "n", 1 },
                    { 615, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 178, "35 ", "n", 1 },
                    { 616, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a  ", 179, "36 ", "n", 1 },
                    { 617, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a  ", 183, "38 ", "n", 12 },
                    { 618, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a ", 195, "39 ", "n", 10 },
                    { 619, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a ", 205, "40", "n", 2 },
                    { 620, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a  ", 207, "41 ", "n", 6 },
                    { 621, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 213, "42 ", "n", 6 },
                    { 622, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier b  ", 219, "43a ", "n", 11 },
                    { 623, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé ", 230, "43b ", "n", 1 },
                    { 624, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 231, "44 ", "n", 4 },
                    { 625, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 235, "45 ", "n", 26 },
                    { 626, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 261, "46 ", "n", 1 },
                    { 627, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 262, "47a ", "n", 7 },
                    { 628, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 269, "47b ", "n", 1 },
                    { 629, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 270, "48 ", "n", 1 },
                    { 630, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b  ", 271, "49 ", "n", 12 },
                    { 631, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b  ", 283, "50a ", "n", 3 },
                    { 632, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b ", 286, "50b ", "n", 1 },
                    { 633, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b ", 287, "51 ", "n", 6 },
                    { 634, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b ", 293, "52 ", "n", 12 },
                    { 635, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 205, "53 ", "n", 8 },
                    { 636, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état) ", 313, "54a ", "n", 3 },
                    { 637, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "-- ", 316, "54b ", "n", 1 },
                    { 638, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "-- ", 317, "54c ", "n", 4 },
                    { 639, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 321, "55 ", "n", 8 },
                    { 640, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 329, "56 ", "n", 4 },
                    { 641, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 333, "57 ", "n", 4 },
                    { 642, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 337, "58 ", "n", 4 },
                    { 643, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 341, "59 ", "n", 6 },
                    { 644, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 347, "98 ", "n", 2 },
                    { 645, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 349, "99 ", "n", 2 },
                    { 646, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identification d'envoi", 351, "100", "n", 3 },
                    { 647, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Date création - OA", 354, "101", "n", 8 },
                    { 648, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 362, "102", "n", 6 },
                    { 649, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 368, "103", "n", 3 },
                    { 650, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 371, "104", "n", 12 },
                    { 651, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 383, "105", "n", 12 },
                    { 652, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 395, "106", "n", 12 },
                    { 653, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 407, "107", "n", 3 },
                    { 654, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 410, "108", "n", 3 },
                    { 655, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 413, "109", "n", 22 },
                    { 656, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 435, "110", "n", 22 },
                    { 657, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 1", 457, "111a", "n", 1 },
                    { 658, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 1", 458, "111b", "n", 6 },
                    { 659, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 2", 464, "112a", "n", 1 },
                    { 660, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 2", 465, "112b", "n", 6 },
                    { 661, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lettre rejet 3", 471, "113a", "n", 1 },
                    { 662, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code rejet 3", 472, "113b", "n", 6 },
                    { 663, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 478, "114", "n", 12 },
                    { 664, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 490, "115", "n", 12 },
                    { 665, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 502, "116", "n", 12 },
                    { 666, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 514, "117", "n", 7 },
                    { 667, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 521, "118", "n", 1 },
                    { 668, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 522, "119", "n", 12 },
                    { 669, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 534, "149", "n", 200 },
                    { 670, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 734, "150a", "n", 12 },
                    { 671, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 745, "150b", "n", 49 },
                    { 672, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 795, "151", "n", 6 },
                    { 1001, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 - réservé", 25, "6a", "n", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9475), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 4, 28, 11, 10, 16, 977, DateTimeKind.Local).AddTicks(9834) });

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
        }
    }
}
