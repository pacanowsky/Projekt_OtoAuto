using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImagesPaths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "/images/listings/toyota_camry.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "/images/listings/ford_f150.jpg");

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 12, 21, 4, 32, 559, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 11, 12, 21, 4, 32, 559, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 12, 21, 4, 32, 559, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 11, 12, 21, 4, 32, 559, DateTimeKind.Local).AddTicks(3358) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "/uploads/toyota_camry.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "/uploads/ford_f150.jpg");

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 12, 19, 54, 23, 72, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 11, 12, 19, 54, 23, 72, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 12, 19, 54, 23, 72, DateTimeKind.Local).AddTicks(1134), new DateTime(2024, 11, 12, 19, 54, 23, 72, DateTimeKind.Local).AddTicks(1133) });
        }
    }
}
