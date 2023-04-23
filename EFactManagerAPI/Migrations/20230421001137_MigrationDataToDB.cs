using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFactManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigrationDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 117,
                column: "startPosition",
                value: 287);

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 118,
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
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(4736), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5198), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5202), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5205), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5214), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5217), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5222), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5224), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "dateCreation", "dateUpdate" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5227), new DateTime(2023, 4, 21, 0, 57, 18, 357, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 117,
                column: "startPosition",
                value: 387);

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "id",
                keyValue: 118,
                column: "startPosition",
                value: 393);
        }
    }
}
