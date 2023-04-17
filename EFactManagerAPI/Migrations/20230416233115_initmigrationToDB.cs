using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class initmigrationToDB : Migration
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
                values: new object[] { 1, "Test", "Test File", "testtes", 1.5f, new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6583), new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "id", "dateCreation", "dateUpdate", "description", "messageCode" },
                values: new object[] { 1, new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6878), "message contenant le fichier de facturation transmis par le prestataire", "920000" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "id", "MessageTypeId", "dateCreation", "dateUpdate", "description", "recordLength", "recordNumber", "recordPlacement" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6908), "Enregistrement de type 10", 350, "10", "body" },
                    { 2, 1, new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6911), "Identification du patient", 350, "20", "body" },
                    { 4, 1, new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6914), "Données sur la prestation", 350, "50", "body" },
                    { 5, 1, new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6916), new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6917), "enregistrement de type 51", 350, "51", "body" },
                    { 6, 1, new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6919), new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6920), "enregistrement de type 52", 350, "52", "body" },
                    { 7, 1, new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6921), new DateTime(2023, 4, 17, 0, 31, 15, 278, DateTimeKind.Local).AddTicks(6922), "enregistrement de type 80", 350, "58", "body" }
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
                    { 32, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bic - compte financier A ", 167, "31", "n", 8 }
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
