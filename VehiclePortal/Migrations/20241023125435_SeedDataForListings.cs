using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehiclePortal.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForListings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Listings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Listings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Listings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Listings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cars" },
                    { 2, "Trucks" },
                    { 3, "Motorcycles" },
                    { 4, "Parts" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "PhoneNumber", "UserType", "Username" },
                values: new object[,]
                {
                    { 1, "johndoe@example.com", "hashed_password", null, 1, null },
                    { 2, "janesmith@example.com", "hashed_password", null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "ImageUrl", "IsActive", "IsFeatured", "IsSold", "PostedDate", "Price", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 18, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2871), "Excellent condition, low mileage, great family car.", "/images/listings/toyota_camry.jpg", true, true, false, new DateTime(2024, 10, 18, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2855), 15000m, "2015 Toyota Camry", null, 1 },
                    { 2, 2, new DateTime(2024, 10, 20, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2874), "Powerful truck, perfect for work and leisure.", "/images/listings/ford_f150.jpg", true, true, false, new DateTime(2024, 10, 20, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2873), 25000m, "2018 Ford F-150", null, 1 },
                    { 3, 3, new DateTime(2024, 10, 13, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2877), "Classic bike, in great shape, ready to ride.", "/images/listings/harley_davidson.jpg", false, false, true, new DateTime(2024, 10, 13, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2876), 12000m, "Harley Davidson Motorcycle", null, 1 },
                    { 4, 4, new DateTime(2024, 10, 21, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2879), "Brand new spare tire for BMW X5.", "/images/listings/bmw_x5_tire.jpg", true, false, false, new DateTime(2024, 10, 21, 17, 54, 34, 778, DateTimeKind.Local).AddTicks(2878), 300m, "BMW X5 Spare Tire", null, 1 }
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

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Listings");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    AltText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ListingId",
                table: "Images",
                column: "ListingId");
        }
    }
}
