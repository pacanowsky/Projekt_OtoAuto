using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class SeedListingsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "IsActive", "IsFeatured", "IsSold", "PostedDate", "Price", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 12, 19, 54, 23, 72, DateTimeKind.Local).AddTicks(1126), "Wspaniały samochód w świetnym stanie.", true, true, false, new DateTime(2024, 11, 12, 19, 54, 23, 72, DateTimeKind.Local).AddTicks(1072), 30000m, "Toyota Camry 2015", null, 1 },
                    { 2, 2, new DateTime(2024, 11, 12, 19, 54, 23, 72, DateTimeKind.Local).AddTicks(1134), "Ciężarówka w bardzo dobrym stanie.", true, true, false, new DateTime(2024, 11, 12, 19, 54, 23, 72, DateTimeKind.Local).AddTicks(1133), 45000m, "Ford F-150 2018", null, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ListingId", "Url" },
                values: new object[,]
                {
                    { 3, 3, "/uploads/harley_davidson.jpg" },
                    { 4, 4, "/uploads/bmw_x5_tire.jpg" }
                });
        }
    }
}
