using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataTodbInitV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    size = table.Column<float>(type: "real", nullable: false),
                    fileUploadedContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    upload_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    messageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recordNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recordLength = table.Column<int>(type: "int", nullable: false),
                    recordPlacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.id);
                    table.ForeignKey(
                        name: "FK_Records_Messages_MessageTypeId",
                        column: x => x.MessageTypeId,
                        principalTable: "Messages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zonelength = table.Column<int>(type: "int", nullable: false),
                    startPosition = table.Column<int>(type: "int", nullable: false),
                    zoneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordConfigId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Zones_Records_RecordConfigId",
                        column: x => x.RecordConfigId,
                        principalTable: "Records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    ZoneConfigId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.id);
                    table.ForeignKey(
                        name: "FK_Fields_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fields_Zones_ZoneConfigId",
                        column: x => x.ZoneConfigId,
                        principalTable: "Zones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZoneErrors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codeError = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descriptionError = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZoneConfigId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneErrors", x => x.id);
                    table.ForeignKey(
                        name: "FK_ZoneErrors_Zones_ZoneConfigId",
                        column: x => x.ZoneConfigId,
                        principalTable: "Zones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileContent",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FieldId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileContent", x => x.id);
                    table.ForeignKey(
                        name: "FK_FileContent_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "id", "Description", "fileName", "fileUploadedContent", "size", "update_date", "upload_date" },
                values: new object[] { 1, "Test", "Test File", "testtes", 1.5f, new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "id", "dateCreation", "dateUpdate", "description", "messageCode" },
                values: new object[] { 1, new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9342), new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9344), "message contenant le fichier de facturation transmis par le prestataire", "920000" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "id", "MessageTypeId", "dateCreation", "dateUpdate", "description", "recordLength", "recordNumber", "recordPlacement" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9384), new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9386), "Enregistrement de type 10", 350, "10", "body" },
                    { 2, 1, new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9392), "Identification du patient", 350, "20", "body" },
                    { 4, 1, new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9395), new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9396), "Données sur la prestation", 350, "50", "body" },
                    { 5, 1, new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9399), new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9399), "enregistrement de type 51", 350, "51", "body" },
                    { 6, 1, new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9402), "enregistrement de type 52", 350, "52", "body" },
                    { 7, 1, new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9405), new DateTime(2023, 4, 18, 0, 0, 48, 619, DateTimeKind.Local).AddTicks(9405), "enregistrement de type 80", 350, "58", "body" }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "id", "RecordConfigId", "dateCreation", "dateUpdate", "description", "startPosition", "zoneNumber", "zoneType", "zonelength" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregist. de type 10", 1, "1", "n", 2 },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code indice", 9, "3", "n", 1 },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "version fichier", 10, "4", "n", 7 },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° compte financier a", 17, "5", "n", 8 },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 29, "6b", "n", 4 },
                    { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregist. de type 10", 33, "7", "n", 3 },
                    { 8, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° compte financier b ", 36, "8a", "n", 12 },
                    { 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de l'envoi  ", 48, "8b", "n", 1 },
                    { 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code s.f.p ", 49, "9", "n", 1 },
                    { 11, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code fichier de decompte ", 50, "10", "n", 1 },
                    { 12, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 51, "11", "n", 1 },
                    { 13, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 52, "12", "n", 1 },
                    { 14, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "contenu facturation ", 53, "13", "n", 3 },
                    { 15, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° tiers payant 0", 56, "14", "n", 12 },
                    { 16, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° accreditation cin ", 68, "15", "n", 12 },
                    { 17, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 80, "16", "n", 1 },
                    { 18, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 81, "17", "n", 4 },
                    { 19, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 85, "18", "n", 3 },
                    { 20, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 88, "19", "n", 12 },
                    { 21, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 100, "20", "n", 7 },
                    { 22, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 107, "21", "n", 1 },
                    { 23, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "annee facturee ", 108, "22", "n", 5 },
                    { 24, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mois facture ", 113, "23", "n", 2 },
                    { 25, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 115, "24", "n", 5 },
                    { 26, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de creation ", 120, "25", "n", 7 },
                    { 27, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de creation ", 127, "26", "n", 1 },
                    { 28, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numéro BCE ", 128, "27", "n", 10 },
                    { 29, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ref. etablissement ", 138, "28", "n", 25 },
                    { 30, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 163, "29", "n", 2 },
                    { 31, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 165, "30", "n", 2 },
                    { 32, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 167, "31", "n", 8 },
                    { 33, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 175, "32", "n", 1 },
                    { 34, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 176, "33\r\n", "n", 1 },
                    { 35, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 177, "34\r\n", "n", 1 },
                    { 36, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 178, "35\r\n", "n", 1 },
                    { 37, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a\r\n ", 179, "36\r\n", "n", 1 },
                    { 38, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a\r\n ", 183, "38\r\n", "n", 12 },
                    { 39, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a\r\n", 195, "39\r\n", "n", 10 },
                    { 40, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a\r\n", 205, "40", "n", 2 },
                    { 41, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier a\r\n ", 207, "41\r\n", "n", 6 },
                    { 42, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 213, "42\r\n", "n", 6 },
                    { 43, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier b\r\n ", 219, "43a\r\n", "n", 11 },
                    { 44, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 230, "43b\r\n", "n", 1 },
                    { 45, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état)\r\n", 270, "48\r\n", "n", 1 },
                    { 46, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b\r\n ", 271, "49\r\n", "n", 12 },
                    { 47, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b\r\n ", 283, "50a\r\n", "n", 3 },
                    { 48, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b\r\n", 286, "50b\r\n", "n", 1 },
                    { 49, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b\r\n", 287, "51\r\n", "n", 6 },
                    { 50, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iban - compte financier b\r\n", 293, "52\r\n", "n", 12 },
                    { 51, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état)\r\n", 305, "53\r\n", "n", 8 },
                    { 52, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état)\r\n", 313, "54a\r\n", "n", 3 },
                    { 53, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "-- ", 316, "54b\r\n", "n", 1 },
                    { 54, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "-- ", 317, "54c\r\n", "n", 4 },
                    { 55, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 321, "55\r\n", "n", 8 },
                    { 56, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 329, "56\r\n", "n", 4 },
                    { 57, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 333, "57\r\n", "n", 4 },
                    { 58, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 337, "58\r\n", "n", 4 },
                    { 59, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 341, "59\r\n", "n", 6 },
                    { 60, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 347, "98\r\n", "n", 2 },
                    { 61, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 349, "99\r\n", "n", 2 },
                    { 62, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "enregistrement de type 20", 1, "1", "n", 2 },
                    { 63, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "n° ordre enregist", 3, "2", "n", 6 },
                    { 64, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "autorisation tiers payant", 9, "3", "n", 1 },
                    { 65, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "heure d'admission", 10, "4", "n", 7 },
                    { 66, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date d'admission", 17, "5", "n", 8 },
                    { 67, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de sortie (partie 1)", 25, "6a", "n", 4 },
                    { 68, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de sortie (partie 2)", 29, "6b", "n", 4 },
                    { 69, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite d'affiliation", 33, "7", "n", 3 },
                    { 70, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire (partie 1)", 36, "8a", "n", 12 },
                    { 71, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "identification beneficiaire (partie 2)\r\n", 48, "8b", "n", 1 },
                    { 72, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sexe beneficiaire", 49, "9", "a", 1 },
                    { 73, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "type facture", 50, "10", "n", 1 },
                    { 74, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "type de facturation", 51, "11", "n", 1 },
                    { 75, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 52, "12", "n", 1 },
                    { 76, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "service 721 bis", 53, "13", "n", 3 },
                    { 77, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de l'etablissement qui facture\r\n", 56, "14", "n", 12 },
                    { 78, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "etablissement de sejour", 68, "15", "n", 12 },
                    { 79, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code levee delai de prescription", 80, "16", "n", 1 },
                    { 80, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "causes du traitement", 81, "17", "n", 4 },
                    { 81, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite de destination", 85, "18", "n", 3 },
                    { 82, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero d'admission", 88, "19", "n", 12 },
                    { 83, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date accord traitement (partie 1)", 100, "20", "n", 7 },
                    { 84, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date accord traitement (partie 2)", 107, "21", "n", 1 },
                    { 85, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "heure de sortie", 108, "22", "n", 5 },
                    { 86, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 113, "23", "n", 2 },
                    { 87, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de la facture individuelle (partie 1)\r\n", 115, "24", "n", 5 },
                    { 88, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de la facture individuelle (partie 2)", 120, "25", "n", 7 },
                    { 89, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "application franchise sociale", 127, "26", "n", 1 },
                    { 90, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ct 1 + ct 2", 128, "27", "n", 10 },
                    { 91, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference de l'etablissement", 138, "28", "n", 25 },
                    { 92, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de facture precedente (partie 1)", 163, "29", "n", 2 },
                    { 93, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de facture precedente (partie 2)", 165, "30", "n", 2 },
                    { 94, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero de facture precedente (partie 3)", 167, "31", "n", 8 },
                    { 95, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "flag identification du beneficiaire", 175, "32\r\n", "n", 1 },
                    { 96, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 176, "33\r\n", "n", 1 },
                    { 97, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero envoi precedent (partie 1)", 177, "34\r\n", "n", 1 },
                    { 98, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero envoi precedent (partie 2)", 178, "35\r\n", "n", 1 },
                    { 99, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero envoi precedent (partie 3)", 179, "36\r\n", "n", 1 },
                    { 100, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numero mutualite facturation precedente", 180, "37\r\n", "n", 3 },
                    { 101, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero de compte financier a (partie 1)\r\n", 283, "38", "n", 12 },
                    { 102, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero de compte financier a (partie 2) ", 295, "39\r\n", "n", 10 },
                    { 103, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve", 205, "40\r\n", "n", 2 },
                    { 104, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "annee et mois de facturation precedente", 207, "41\r\n", "n", 6 },
                    { 105, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 1)\r\n", 213, "42\r\n", "a", 6 },
                    { 106, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 2)\r\n", 219, "43a\r\n", "n", 11 },
                    { 107, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 3)\r\n", 230, "43b\r\n", "n", 1 },
                    { 108, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 4)\r\n", 231, "44\r\n", "n", 4 },
                    { 109, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donnees de reference reseau ou carte sis (partie 5)\r\n", 235, "45\r\n", "n", 26 },
                    { 110, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 261, "46\r\n", "n", 1 },
                    { 111, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de facturation (partie 1)\r\n", 262, "47a\r\n", "n", 7 },
                    { 112, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date de facturation (partie 2) ", 269, "47b\r\n", "n", 1 },
                    { 113, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 270, "48\r\n", "n", 1 },
                    { 114, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero compte financier b (partie 1)", 271, "49\r\n", "n", 12 },
                    { 115, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero compte financier b (partie 2)", 283, "50a\r\n", "n", 3 },
                    { 116, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero compte financier b (partie 2 bis)", 286, "50b\r\n", "n", 1 },
                    { 117, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reference mutualite numero compte financier b (partie 3)", 387, "51\r\n", "n", 6 },
                    { 118, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "numéro d’admission de la mère", 393, "52\r\n", "n", 12 },
                    { 119, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date debut assurabilite", 305, "53\r\n", "n", 8 },
                    { 120, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date fin assurabilite (partie 1)\r\n", 313, "54a\r\n", "n", 3 },
                    { 121, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date fin assurabilite (partie 2)\r\n", 316, "54b\r\n", "n", 1 },
                    { 122, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date fin assurabilite (partie 3)\r\n", 317, "54c\r\n", "n", 4 },
                    { 123, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "date communication information", 321, "55\r\n", "n", 8 },
                    { 124, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maf annee en cours\r\n ", 329, "56\r\n", "n", 4 },
                    { 125, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maf annee en cours -1\r\n ", 333, "57\r\n", "n", 4 },
                    { 126, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maf annee en cours -2\r\n", 337, "58\r\n", "n", 4 },
                    { 127, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 341, "59\r\n", "n", 6 },
                    { 128, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reserve ", 347, "98\r\n", "n", 2 },
                    { 129, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiffres de controle de l'enregistrement", 349, "99\r\n", "n", 2 },
                    { 130, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 231, "44\r\n", "n", 4 },
                    { 131, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état)\r\n", 235, "45\r\n", "n", 26 },
                    { 132, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état)\r\n", 261, "46\r\n", "n", 1 },
                    { 133, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réservé (réforme de l’état)\r\n", 262, "47a\r\n", "n", 7 },
                    { 134, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0 ", 269, "47b\r\n", "n", 1 },
                    { 1000, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 25, "6a", "n", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fields_FileId",
                table: "Fields",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_ZoneConfigId",
                table: "Fields",
                column: "ZoneConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_FileContent_FieldId",
                table: "FileContent",
                column: "FieldId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Records_MessageTypeId",
                table: "Records",
                column: "MessageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ZoneErrors_ZoneConfigId",
                table: "ZoneErrors",
                column: "ZoneConfigId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zones_RecordConfigId",
                table: "Zones",
                column: "RecordConfigId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileContent");

            migrationBuilder.DropTable(
                name: "ZoneErrors");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
