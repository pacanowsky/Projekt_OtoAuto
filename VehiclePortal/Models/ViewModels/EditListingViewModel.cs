using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VehiclePortal.Models.ViewModels
{
    public class EditListingViewModel
    {
        public int Id { get; set; }

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

        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsSold { get; set; }

        [Display(Name = "Pojemność silnika (w cc)")]
        public int? EngineCapacity { get; set; }

        [Display(Name = "Pierwsza rejestracja")]
        [DataType(DataType.Date)]
        public DateOnly? FirstRegistration { get; set; }

        [Display(Name = "Przebieg (w km)")]
        public int? Mileage { get; set; }

        [Display(Name = "VIN")]
        public string VIN { get; set; } = string.Empty;

        [Display(Name = "Rok produkcji")]
        [Range(1886, 2100, ErrorMessage = "Proszę podać prawidłowy rok.")]
        public int? Year { get; set; }

        // Obecne obrazy (URL)
        public List<string> Images { get; set; } = new List<string>();

        // Nowe obrazy do dodania
        public List<IFormFile> NewImages { get; set; } = new List<IFormFile>();

        // Zmiana na IEnumerable<SelectListItem> dla poprawnej obsługi w widokach
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    }
}
