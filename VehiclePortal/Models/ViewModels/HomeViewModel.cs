namespace VehiclePortal.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Listing> FeaturedListings { get; set; } 
        public List<Listing> Listings { get; set; }
        public string SearchTerm { get; set; }
    }

}
