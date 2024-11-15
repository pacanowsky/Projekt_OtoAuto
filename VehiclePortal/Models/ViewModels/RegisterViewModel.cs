namespace VehiclePortal.Models.ViewModels;

using System.ComponentModel.DataAnnotations;
using VehiclePortal.Models.Enums;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string? ConfirmPassword { get; set; }

    [Required]
    public UserType UserType { get; set; } // Either Buyer or Seller

    [Required]
    [Phone]
    [Display(Name = "Phone Number")]
    public string? PhoneNumber { get; set; }
}

