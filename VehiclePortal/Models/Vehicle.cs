using System;
using System.ComponentModel.DataAnnotations;

namespace VehiclePortal.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? VIN { get; set; } // Vehicle Identification Number
        public int? Mileage { get; set; }

        // Zmiana na DateTime? zamiast DateOnly?
        public DateTime? FirstRegistration { get; set; } // Date of first registration

        public int? EngineCapacity { get; set; } // Engine capacity in cc
        public int ListingId { get; set; }
        public Listing Listing { get; set; }
    }
}
