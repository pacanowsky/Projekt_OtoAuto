using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstRegistrationAndEngineCapacityToVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VIN",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Mileage",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "EngineCapacity",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstRegistration",
                table: "Vehicles",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineCapacity",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FirstRegistration",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VIN",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Mileage",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 19, 20, 0, 468, DateTimeKind.Local).AddTicks(7894), new DateTime(2024, 10, 24, 19, 20, 0, 468, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 19, 20, 0, 468, DateTimeKind.Local).AddTicks(7897), new DateTime(2024, 10, 26, 19, 20, 0, 468, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 20, 0, 468, DateTimeKind.Local).AddTicks(7899), new DateTime(2024, 10, 19, 19, 20, 0, 468, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 19, 20, 0, 468, DateTimeKind.Local).AddTicks(7901), new DateTime(2024, 10, 27, 19, 20, 0, 468, DateTimeKind.Local).AddTicks(7901) });
        }
    }
}
