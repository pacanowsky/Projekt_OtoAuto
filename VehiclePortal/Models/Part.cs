namespace VehiclePortal.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public string Condition { get; set; } // e.g., New, Used, Refurbished

        // Foreign Key to Listing
        public int ListingId { get; set; }
        public Listing Listing { get; set; }
    }
}
