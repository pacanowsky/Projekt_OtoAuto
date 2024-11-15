using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Listings");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Samochody");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Ciężarówki");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Motocykle");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Części");

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ListingId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "/images/listings/toyota_camry.jpg" },
                    { 2, 2, "/images/listings/ford_f150.jpg" },
                    { 3, 3, "/images/listings/harley_davidson.jpg" },
                    { 4, 4, "/images/listings/bmw_x5_tire.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 5, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9236), "Samochód w doskonałym stanie, niski przebieg, idealny dla rodziny.", new DateTime(2024, 11, 5, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9170), 60000m, "Toyota Camry 2015" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 7, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9248), "Mocna ciężarówka, idealna do pracy i rekreacji.", new DateTime(2024, 11, 7, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9244), 95000m, "Ford F-150 2018" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9255), "Klasyczny motocykl, w świetnym stanie, gotowy do jazdy.", new DateTime(2024, 10, 31, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9252), 45000m, "Motocykl Harley Davidson" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 8, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9263), "Nowa opona zapasowa do BMW X5.", new DateTime(2024, 11, 8, 18, 50, 44, 928, DateTimeKind.Local).AddTicks(9260), 1200m, "Opona zapasowa BMW X5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "jankowalski@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "annaszulc@example.com");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ListingId",
                table: "Image",
                column: "ListingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Cars");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Trucks");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Motorcycles");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Parts");

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "PostedDate", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9652), "Excellent condition, low mileage, great family car.", "/images/listings/toyota_camry.jpg", new DateTime(2024, 10, 29, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9636), 15000m, "2015 Toyota Camry" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "PostedDate", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9656), "Powerful truck, perfect for work and leisure.", "/images/listings/ford_f150.jpg", new DateTime(2024, 10, 31, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9655), 25000m, "2018 Ford F-150" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "PostedDate", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9683), "Classic bike, in great shape, ready to ride.", "/images/listings/harley_davidson.jpg", new DateTime(2024, 10, 24, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9682), 12000m, "Harley Davidson Motorcycle" });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "PostedDate", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 1, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9685), "Brand new spare tire for BMW X5.", "/images/listings/bmw_x5_tire.jpg", new DateTime(2024, 11, 1, 15, 24, 41, 840, DateTimeKind.Local).AddTicks(9684), 300m, "BMW X5 Spare Tire" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "johndoe@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "janesmith@example.com");
        }
    }
}
