namespace VehiclePortal.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }  // e.g., Car, Truck, Motorcycle, Part

        // Navigation property
        public ICollection<Listing> Listings { get; set; }  // Listings that belong to this category
    }
}
