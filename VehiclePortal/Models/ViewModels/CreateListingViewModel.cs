using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VehiclePortal.Models.ViewModels
{
    public class CreateListingViewModel
    {
        [Required]
        [Display(Name = "Tytuł ogłoszenia")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Opis ogłoszenia")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cena musi być większa niż 0.")]
        [Display(Name = "Cena (w PLN)")]
        public decimal Price { get; set; }

        public bool IsFeatured { get; set; }

        [Required(ErrorMessage = "Kategoria jest wymagana.")]
        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }

        public int UserId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        [Display(Name = "Dodaj zdjęcia")]
        public List<IFormFile> Images { get; set; } = new List<IFormFile>();

        [Display(Name = "Pojemność silnika (w cc)")]
        [Range(1, int.MaxValue, ErrorMessage = "Pojemność silnika musi być dodatnią liczbą.")]
        public int? EngineCapacity { get; set; }

        // Zmiana na DateTime?
        [Display(Name = "Pierwsza rejestracja")]
        [DataType(DataType.Date)]
        public DateTime? FirstRegistration { get; set; }

        [Display(Name = "Przebieg (w km)")]
        [Range(0, int.MaxValue, ErrorMessage = "Przebieg nie może być ujemny.")]
        public int? Mileage { get; set; }

        [Display(Name = "VIN")]
        public string? VIN { get; set; }

        [Display(Name = "Rok produkcji")]
        [Range(1886, 2100, ErrorMessage = "Proszę podać prawidłowy rok.")]
        public int? Year { get; set; }
    }
}
