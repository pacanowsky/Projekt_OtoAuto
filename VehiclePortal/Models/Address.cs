namespace VehiclePortal.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        // Foreign Key to User or Listing (optional based on use case)
        public int? UserId { get; set; }
        public User? User { get; set; }

        public int? ListingId { get; set; }
        public Listing? Listing { get; set; }
    }

}
