using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehiclePortal.Data;
using VehiclePortal.Models.ViewModels;

namespace VehiclePortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClassifiedAdsDbContext _context;

        public HomeController(ClassifiedAdsDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchTerm = "")
        {
            // Get featured ads with images and category included
            var featuredListings = string.IsNullOrEmpty(searchTerm)
              ? await _context.Listings
                .Where(l => l.IsSold == false && l.IsFeatured == true) // Dodajemy warunek IsFeatured == true
                .Include(l => l.Images) // Include images
                .Include(l => l.Category) // Include category
                .Take(10)
                .ToListAsync()
        :  await _context.Listings
                .Where(l => l.IsSold == false && l.IsFeatured == true && (l.Title.Contains(searchTerm) || l.Description.Contains(searchTerm))) // Dodajemy IsFeatured == true
                .Include(l => l.Images) // Include images
                .Include(l => l.Category) // Include category
                .Take(10)
                .ToListAsync();

            // Get all listings with images and category included, or filter by search term
            var listings = string.IsNullOrEmpty(searchTerm)
                ? await _context.Listings
                    .Where(l => l.IsSold == false)
                    .Include(l => l.Images) // Include images
                    .Include(l => l.Category) // Include category
                    .ToListAsync()
                : await _context.Listings
                    .Where(l => l.IsSold == false && (l.Title.Contains(searchTerm) || l.Description.Contains(searchTerm)))
                    .Include(l => l.Images) // Include images
                    .Include(l => l.Category) // Include category
                    .ToListAsync();

            var viewModel = new HomeViewModel
            {
                FeaturedListings = featuredListings,
                Listings = listings,
                SearchTerm = searchTerm
            };

            return View(viewModel);
        }

        // Details action to fetch a specific listing by Id
        public IActionResult Details(int id)
        {
            var listing = _context.Listings
                .Include(l => l.Images)       // Include images
                .Include(l => l.User)         // Include user details
                .Include(l => l.Category)     // Include category details
                .Include(l => l.Vehicle)      // Include vehicle details
                .FirstOrDefault(l => l.Id == id);

            if (listing == null)
            {
                return NotFound();
            }

            return View(listing);
        }

        public IActionResult BuyNow()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
