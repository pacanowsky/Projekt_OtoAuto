using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class AddListingsAndRelatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Listings",
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
                values: new object[] { new DateTime(2024, 10, 18, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2871), new DateTime(2024, 10, 18, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 20, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2874), new DateTime(2024, 10, 20, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 10, 13, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostedDate" },
                values: new object[] { new DateTime(2024, 10, 21, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2879), new DateTime(2024, 10, 21, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2878) });
        }
    }
}
