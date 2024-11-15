using Microsoft.EntityFrameworkCore;
using VehiclePortal.Models;

namespace VehiclePortal.Data
{
    public class ClassifiedAdsDbContext : DbContext
    {
        public ClassifiedAdsDbContext(DbContextOptions<ClassifiedAdsDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

            modelBuilder.Entity<Image>()
                .ToTable("Image")  // Zmieniamy nazwę tabeli na ListingImages
                .HasOne(i => i.Listing)
                .WithMany(l => l.Images)
                .HasForeignKey(i => i.ListingId)
                .OnDelete(DeleteBehavior.Cascade);

            // Dodanie precyzji dla Price (w Listing) i Amount (w Transaction)
            modelBuilder.Entity<Listing>()
                .Property(l => l.Price)
                .HasColumnType("decimal(18,2)"); // Ustalamy precyzję i skalę dla ceny

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Amount)
                .HasColumnType("decimal(18,2)"); // Ustalamy precyzję i skalę dla kwoty

            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Listing>()
                .HasOne(l => l.User)
                .WithMany(u => u.Listings)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Listing)
                .WithOne(l => l.Vehicle)
                .HasForeignKey<Vehicle>(v => v.ListingId);

            modelBuilder.Entity<Part>()
                .HasOne(p => p.Listing)
                .WithOne(l => l.Part)
                .HasForeignKey<Part>(p => p.ListingId);

            modelBuilder.Entity<Listing>()
                .HasOne(l => l.Category)
                .WithMany(c => c.Listings)
                .HasForeignKey(l => l.CategoryId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Listing)
                .WithOne(l => l.Transaction)
                .HasForeignKey<Transaction>(t => t.ListingId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Buyer)
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.BuyerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
