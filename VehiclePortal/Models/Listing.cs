using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VehiclePortal.Models
{
    public class Listing
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany.")]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana.")]
        public decimal Price { get; set; }

        public DateTime PostedDate { get; set; }
        public bool IsSold { get; set; }
        public bool IsFeatured { get; set; } = false;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [Required]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Required(ErrorMessage = "Kategoria jest wymagana.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public Vehicle? Vehicle { get; set; }
        public Part? Part { get; set; }
        public Transaction? Transaction { get; set; }

        // Lista zdjęć powiązanych z ogłoszeniem
        public ICollection<Image> Images { get; set; } = new List<Image>();

        // Statyczna ścieżka do obrazka przypisana na podstawie Id
        public string StaticImagePath => Id switch
        {
            1 => "/images/listings/toyota_camry.jpg",
            2 => "/images/listings/ford_f150.jpg",
            _ => "/images/listings/placeholder.jpg" // Domyślny obrazek dla innych ogłoszeń
        };
    }

    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public int ListingId { get; set; }
        public Listing Listing { get; set; } = null!;
    }
}
