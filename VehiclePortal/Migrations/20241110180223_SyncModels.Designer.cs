﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehiclePortal.Data;

#nullable disable

namespace VehiclePortal.Migrations
{
    [DbContext(typeof(ClassifiedAdsDbContext))]
    [Migration("20241110180223_SyncModels")]
    partial class SyncModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VehiclePortal.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samochody"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ciężarówki"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Motocykle"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Części"
                        });
                });

            modelBuilder.Entity("VehiclePortal.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ListingId = 1,
                            Url = "/images/listings/toyota_camry.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ListingId = 2,
                            Url = "/images/listings/ford_f150.jpg"
                        },
                        new
                        {
                            Id = 3,
                            ListingId = 3,
                            Url = "/images/listings/harley_davidson.jpg"
                        },
                        new
                        {
                            Id = 4,
                            ListingId = 4,
                            Url = "/images/listings/bmw_x5_tire.jpg"
                        });
                });

            modelBuilder.Entity("VehiclePortal.Models.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSold")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Listings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 5, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5522),
                            Description = "Samochód w doskonałym stanie, niski przebieg, idealny dla rodziny.",
                            IsActive = true,
                            IsFeatured = true,
                            IsSold = false,
                            PostedDate = new DateTime(2024, 11, 5, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5451),
                            Price = 60000m,
                            Title = "Toyota Camry 2015",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 7, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5537),
                            Description = "Mocna ciężarówka, idealna do pracy i rekreacji.",
                            IsActive = true,
                            IsFeatured = true,
                            IsSold = false,
                            PostedDate = new DateTime(2024, 11, 7, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5532),
                            Price = 95000m,
                            Title = "Ford F-150 2018",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 10, 31, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5549),
                            Description = "Klasyczny motocykl, w świetnym stanie, gotowy do jazdy.",
                            IsActive = false,
                            IsFeatured = false,
                            IsSold = true,
                            PostedDate = new DateTime(2024, 10, 31, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5544),
                            Price = 45000m,
                            Title = "Motocykl Harley Davidson",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2024, 11, 8, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5562),
                            Description = "Nowa opona zapasowa do BMW X5.",
                            IsActive = true,
                            IsFeatured = false,
                            IsSold = false,
                            PostedDate = new DateTime(2024, 11, 8, 19, 2, 21, 21, DateTimeKind.Local).AddTicks(5556),
                            Price = 1200m,
                            Title = "Opona zapasowa BMW X5",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("VehiclePortal.Models.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ListingId")
                        .IsUnique();

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("VehiclePortal.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ListingId")
                        .IsUnique();

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("VehiclePortal.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "jankowalski@example.com",
                            PasswordHash = "hashed_password",
                            UserType = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "annaszulc@example.com",
                            PasswordHash = "hashed_password",
                            UserType = 0
                        });
                });

            modelBuilder.Entity("VehiclePortal.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EngineCapacity")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("FirstRegistration")
                        .HasColumnType("date");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListingId")
                        .IsUnique();

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("VehiclePortal.Models.Image", b =>
                {
                    b.HasOne("VehiclePortal.Models.Listing", "Listing")
                        .WithMany("Images")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("VehiclePortal.Models.Listing", b =>
                {
                    b.HasOne("VehiclePortal.Models.Category", "Category")
                        .WithMany("Listings")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehiclePortal.Models.User", "User")
                        .WithMany("Listings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VehiclePortal.Models.Part", b =>
                {
                    b.HasOne("VehiclePortal.Models.Listing", "Listing")
                        .WithOne("Part")
                        .HasForeignKey("VehiclePortal.Models.Part", "ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("VehiclePortal.Models.Transaction", b =>
                {
                    b.HasOne("VehiclePortal.Models.User", "Buyer")
                        .WithMany("Transactions")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VehiclePortal.Models.Listing", "Listing")
                        .WithOne("Transaction")
                        .HasForeignKey("VehiclePortal.Models.Transaction", "ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("VehiclePortal.Models.Vehicle", b =>
                {
                    b.HasOne("VehiclePortal.Models.Listing", "Listing")
                        .WithOne("Vehicle")
                        .HasForeignKey("VehiclePortal.Models.Vehicle", "ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("VehiclePortal.Models.Category", b =>
                {
                    b.Navigation("Listings");
                });

            modelBuilder.Entity("VehiclePortal.Models.Listing", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Part");

                    b.Navigation("Transaction");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehiclePortal.Models.User", b =>
                {
                    b.Navigation("Listings");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
