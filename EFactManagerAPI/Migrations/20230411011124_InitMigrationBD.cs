using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitMigrationBD : Migration
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
                    recordType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recordLength = table.Column<int>(type: "int", nullable: false),
                    recordPlacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ZoneContents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneContents", x => x.id);
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
                    isError = table.Column<bool>(type: "bit", nullable: false),
                    zoneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    messageId = table.Column<int>(type: "int", nullable: false),
                    recordId = table.Column<int>(type: "int", nullable: false),
                    zoneContentId = table.Column<int>(type: "int", nullable: false),
                    zoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.id);
                    table.ForeignKey(
                        name: "FK_Fields_Messages_messageId",
                        column: x => x.messageId,
                        principalTable: "Messages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fields_Records_recordId",
                        column: x => x.recordId,
                        principalTable: "Records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fields_ZoneContents_zoneContentId",
                        column: x => x.zoneContentId,
                        principalTable: "ZoneContents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fields_Zones_zoneId",
                        column: x => x.zoneId,
                        principalTable: "Zones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "id", "Description", "fileName", "fileUploadedContent", "size", "update_date", "upload_date" },
                values: new object[] { 1, "Test", "Test File", "testtes", 1.5f, new DateTime(2023, 4, 11, 2, 11, 24, 586, DateTimeKind.Local).AddTicks(1469), new DateTime(2023, 4, 11, 2, 11, 24, 586, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.CreateIndex(
                name: "IX_Fields_messageId",
                table: "Fields",
                column: "messageId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_recordId",
                table: "Fields",
                column: "recordId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_zoneContentId",
                table: "Fields",
                column: "zoneContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_zoneId",
                table: "Fields",
                column: "zoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "ZoneContents");

            migrationBuilder.DropTable(
                name: "Zones");
        }
    }
}
