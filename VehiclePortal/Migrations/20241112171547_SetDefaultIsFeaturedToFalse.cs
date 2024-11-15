using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class SetDefaultIsFeaturedToFalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstRegistration",
                table: "Vehicles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

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
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "/uploads/harley_davidson.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "/uploads/bmw_x5_tire.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "/images/listings/harley_davidson.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "/images/listings/bmw_x5_tire.jpg");

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "IsActive", "IsFeatured", "IsSold", "PostedDate", "Price", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 5, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5522), "Samochód w doskonałym stanie, niski przebieg, idealny dla rodziny.", true, true, false, new DateTime(2024, 11, 5, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5451), 60000m, "Toyota Camry 2015", null, 1 },
                    { 2, 2, new DateTime(2024, 11, 7, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5537), "Mocna ciężarówka, idealna do pracy i rekreacji.", true, true, false, new DateTime(2024, 11, 7, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5532), 95000m, "Ford F-150 2018", null, 1 },
                    { 3, 3, new DateTime(2024, 10, 31, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5549), "Klasyczny motocykl, w świetnym stanie, gotowy do jazdy.", false, false, true, new DateTime(2024, 10, 31, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5544), 45000m, "Motocykl Harley Davidson", null, 1 },
                    { 4, 4, new DateTime(2024, 11, 8, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5562), "Nowa opona zapasowa do BMW X5.", true, false, false, new DateTime(2024, 11, 8, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5556), 1200m, "Opona zapasowa BMW X5", null, 1 }
                });
        }
    }
}
