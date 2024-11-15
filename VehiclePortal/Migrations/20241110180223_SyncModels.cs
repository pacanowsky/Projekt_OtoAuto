using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class SyncModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5522), new DateTime(2024, 11, 5, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 11, 7, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5549), new DateTime(2024, 10, 31, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5562), new DateTime(2024, 11, 8, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5556) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 11, 5, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9248), new DateTime(2024, 11, 7, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 10, 31, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9263), new DateTime(2024, 11, 8, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9260) });
        }
    }
}
