using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VehiclePortal.Data;
using VehiclePortal.Models;
using Microsoft.EntityFrameworkCore;
using VehiclePortal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace VehiclePortal.Controllers
{
    [Authorize(Roles = "Seller")]
    public class SellingController : Controller
    {
        private readonly ClassifiedAdsDbContext _context;

        public SellingController(ClassifiedAdsDbContext context)
        {
            _context = context;
        }

        // GET: Selling
        public IActionResult Index()
        {
            return View();
        }


        // GET: Selling/MyListings
        public IActionResult MyListings()
        {
            var userId = int.Parse(GetUserId());
            var listings = _context.Listings
                .Where(l => l.UserId == userId)
                .Include(l => l.Category)
                .Include(l => l.Vehicle)
                .Include(l => l.Images)
                .ToList();

            return View(listings);
        }

        // GET: Selling/Create
        [HttpGet]
        public IActionResult Create()
        {
            var model = new CreateListingViewModel
            {
                Categories = _context.Categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList()
            };
            return View(model);
        }

        // POST: Selling/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateListingViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _context.Categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList();
                return View(model);
            }

            var userId = int.Parse(GetUserId());

            var listing = new Listing
            {
                Title = model.Title,
                Description = model.Description,
                Price = model.Price,
                PostedDate = DateTime.Now,
                IsSold = false,
                IsFeatured = model.IsFeatured,
                IsActive = true,
                CreatedAt = DateTime.Now,
                UserId = userId,
                CategoryId = model.CategoryId,
                Images = new List<Image>(),
                Vehicle = new Vehicle
                {
                    Year = model.Year,
                    VIN = model.VIN,
                    Mileage = model.Mileage,
                    FirstRegistration = model.FirstRegistration.HasValue
                        ? new DateTime(model.FirstRegistration.Value.Year, model.FirstRegistration.Value.Month, model.FirstRegistration.Value.Day)
                        : (DateTime?)null,
                    EngineCapacity = model.EngineCapacity
                }
            };

            if (model.Images != null && model.Images.Count > 0)
            {
                var uploadsFolder = Path.Combine("wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);

                foreach (var imageFile in model.Images.Take(10))
                {
                    var uniqueFileName = $"{Guid.NewGuid()}_{imageFile.FileName}";
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    var imageUrl = $"/uploads/{uniqueFileName}";

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(fileStream);
                    }

                    listing.Images.Add(new Image { Url = imageUrl });
                }
            }

            _context.Listings.Add(listing);
            _context.SaveChanges();

            return RedirectToAction("MyListings");
        }

        // GET: Selling/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var listing = _context.Listings
                .Include(l => l.Images)
                .Include(l => l.Vehicle)
                .FirstOrDefault(l => l.Id == id && l.UserId == int.Parse(GetUserId()));

            if (listing == null)
            {
                return NotFound();
            }

            var model = new EditListingViewModel
            {
                Id = listing.Id,
                Title = listing.Title,
                Description = listing.Description,
                Price = listing.Price,
                CategoryId = listing.CategoryId,
                IsFeatured = listing.IsFeatured,
                IsSold = listing.IsSold,
                EngineCapacity = listing.Vehicle?.EngineCapacity,
                FirstRegistration = listing.Vehicle?.FirstRegistration.HasValue == true
                    ? DateOnly.FromDateTime(listing.Vehicle.FirstRegistration.Value)
                    : (DateOnly?)null,
                Mileage = listing.Vehicle?.Mileage,
                VIN = listing.Vehicle?.VIN,
                Year = listing.Vehicle?.Year,
                Images = listing.Images.Select(i => i.Url).ToList(),
                Categories = _context.Categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList()
            };

            return View(model);
        }

        // POST: Selling/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EditListingViewModel model, List<int> imagesToDelete)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _context.Categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList();
                return View(model);
            }

            var listing = _context.Listings
                .Include(l => l.Images)
                .Include(l => l.Vehicle)
                .FirstOrDefault(l => l.Id == id && l.UserId == int.Parse(GetUserId()));

            if (listing == null)
            {
                return NotFound();
            }

            listing.Title = model.Title;
            listing.Description = model.Description;
            listing.Price = model.Price;
            listing.CategoryId = model.CategoryId;
            listing.IsFeatured = model.IsFeatured;
            listing.IsSold = model.IsSold;

            if (listing.Vehicle == null)
            {
                listing.Vehicle = new Vehicle();
            }

            listing.Vehicle.Year = model.Year;
            listing.Vehicle.VIN = model.VIN;
            listing.Vehicle.Mileage = model.Mileage;
            listing.Vehicle.FirstRegistration = model.FirstRegistration.HasValue
                ? new DateTime(model.FirstRegistration.Value.Year, model.FirstRegistration.Value.Month, model.FirstRegistration.Value.Day)
                : (DateTime?)null;
            listing.Vehicle.EngineCapacity = model.EngineCapacity;

            // Remove old images if marked for deletion
            if (imagesToDelete != null && imagesToDelete.Any())
            {
                foreach (var imageId in imagesToDelete)
                {
                    var image = listing.Images.ElementAtOrDefault(imageId);
                    if (image != null)
                    {
                        var oldFilePath = Path.Combine("wwwroot", image.Url.TrimStart('/'));
                        if (System.IO.File.Exists(oldFilePath))
                        {
                            System.IO.File.Delete(oldFilePath);
                        }
                        _context.Images.Remove(image);
                    }
                }
            }

            // Add new images
            if (model.NewImages != null && model.NewImages.Count > 0)
            {
                var uploadsFolder = Path.Combine("wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);

                foreach (var imageFile in model.NewImages.Take(10))
                {
                    var uniqueFileName = $"{Guid.NewGuid()}_{imageFile.FileName}";
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    var imageUrl = $"/uploads/{uniqueFileName}";

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(fileStream);
                    }

                    listing.Images.Add(new Image { Url = imageUrl });
                }
            }

            _context.SaveChanges();
            return RedirectToAction("MyListings");
        }

        // GET: Selling/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var listing = _context.Listings
                .Include(l => l.Category)
                .FirstOrDefault(l => l.Id == id && l.UserId == int.Parse(GetUserId()));

            if (listing == null)
            {
                return NotFound();
            }

            return View(listing);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var listing = _context.Listings
                .Include(l => l.Images)
                .Include(l => l.Vehicle)
                .FirstOrDefault(l => l.Id == id && l.UserId == int.Parse(GetUserId()));

            if (listing != null)
            {
                foreach (var image in listing.Images)
                {
                    var filePath = Path.Combine("wwwroot", image.Url.TrimStart('/'));
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }

                _context.Listings.Remove(listing);
                _context.SaveChanges();
            }

            return RedirectToAction("MyListings");
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
