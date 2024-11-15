using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFirstREgistraionDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "FirstRegistration",
                table: "Vehicles",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9652), new DateTime(2024, 10, 29, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 10, 31, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 10, 24, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9685), new DateTime(2024, 11, 1, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9684) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstRegistration",
                table: "Vehicles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 29, 1, 47, 29, 982, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 10, 29, 1, 47, 29, 982, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 1, 47, 29, 982, DateTimeKind.Local).AddTicks(7897), new DateTime(2024, 10, 31, 1, 47, 29, 982, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 1, 47, 29, 982, DateTimeKind.Local).AddTicks(7900), new DateTime(2024, 10, 24, 1, 47, 29, 982, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 1, 47, 29, 982, DateTimeKind.Local).AddTicks(7902), new DateTime(2024, 11, 1, 1, 47, 29, 982, DateTimeKind.Local).AddTicks(7901) });
        }
    }
}
