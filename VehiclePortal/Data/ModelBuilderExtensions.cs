using Microsoft.EntityFrameworkCore;
using VehiclePortal.Models.Enums;
using VehiclePortal.Models;

namespace VehiclePortal.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seedowanie użytkowników
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Email = "jankowalski@example.com",
                    UserType = UserType.Seller,
                    PasswordHash = "hashed_password"
                },
                new User
                {
                    Id = 2,
                    Email = "annaszulc@example.com",
                    UserType = UserType.Buyer,
                    PasswordHash = "hashed_password"
                }
            );

            // Seedowanie kategorii
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Samochody" },
                new Category { Id = 2, Name = "Ciężarówki" },
                new Category { Id = 3, Name = "Motocykle" },
                new Category { Id = 4, Name = "Części" }
            );

            // Seedowanie ogłoszeń
            modelBuilder.Entity<Listing>().HasData(
                new Listing
                {
                    Id = 1,
                    Title = "Toyota Camry 2015",
                    Description = "Wspaniały samochód w świetnym stanie.",
                    Price = 30000,
                    IsFeatured = true,
                    IsSold = false,
                    IsActive = true,
                    PostedDate = new DateTime(2022, 1, 1),
                    CreatedAt = new DateTime(2022, 1, 1),
                    CategoryId = 1,
                    UserId = 1
                },
                new Listing
                {
                    Id = 2,
                    Title = "Ford F-150 2018",
                    Description = "Ciężarówka w bardzo dobrym stanie.",
                    Price = 45000,
                    IsFeatured = true,
                    IsSold = false,
                    IsActive = true,
                    PostedDate = new DateTime(2022, 1, 1),
                    CreatedAt = new DateTime(2022, 1, 1),
                    CategoryId = 2,
                    UserId = 1
                }
            );

            // Seedowanie obrazów
            modelBuilder.Entity<Image>().HasData(
                new Image { Id = 1, Url = "/images/listings/toyota_camry.jpg", ListingId = 1 },
                new Image { Id = 2, Url = "/images/listings/ford_f150.jpg", ListingId = 2 }
            );
        }
    }
}
