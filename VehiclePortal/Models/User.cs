using System.ComponentModel.DataAnnotations;
using VehiclePortal.Models.Enums;

namespace VehiclePortal.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string? PhoneNumber { get; set; }
        public UserType UserType { get; set; }  // Buyer, Seller, or Both

        // Navigation properties
        public ICollection<Listing>? Listings { get; set; }  // Listings the user has posted
        public ICollection<Transaction>? Transactions { get; set; }  // Transactions as a buyer
    }
}
