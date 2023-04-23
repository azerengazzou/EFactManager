using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 51,
                column: "startPosition",
                value: 205);

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 349,
                column: "startPosition",
                value: 293);

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 417,
                column: "startPosition",
                value: 293);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "update_date", "upload_date" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(5734), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7525), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7582), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7725), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7733), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 4, 21, 1, 11, 36, 885, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 51,
                column: "startPosition",
                value: 305);

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 349,
                column: "startPosition",
                value: 393);

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 417,
                column: "startPosition",
                value: 393);
        }
    }
}
