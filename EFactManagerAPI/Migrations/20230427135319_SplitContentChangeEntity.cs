using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class SplitContentChangeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numAttestation",
                table: "Fields",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "numPrestation",
                table: "Fields",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "update_date", "upload_date" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8276), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8301), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8305), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8308), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8311), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8316), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8322), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 4, 27, 14, 53, 18, 283, DateTimeKind.Local).AddTicks(8325) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numAttestation",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "numPrestation",
                table: "Fields");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "update_date", "upload_date" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3083), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3091), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3093), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3111), new DateTime(2023, 4, 21, 1, 15, 18, 319, DateTimeKind.Local).AddTicks(3112) });
        }
    }
}
