using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 12, 22, 33, 29, 25, DateTimeKind.Local).AddTicks(8685), new DateTime(2024, 11, 12, 22, 33, 29, 25, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 12, 22, 33, 29, 25, DateTimeKind.Local).AddTicks(8695), new DateTime(2024, 11, 12, 22, 33, 29, 25, DateTimeKind.Local).AddTicks(8693) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
