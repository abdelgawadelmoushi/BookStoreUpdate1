using ECommerce522.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce522.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        //ApplicationDbContext _context = new();
        Repository<Brand> _brandRepository = new();

        public async Task<IActionResult> Index()
        {
            var brands = await _brandRepository.GetAsync(tracked: false);

            // Add Filter

            return View(brands.AsEnumerable());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Brand brand, IFormFile Img)
        {
            if (Img is not null && Img.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(Img.FileName);

                // Save Img in wwwroot
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\brand_images", fileName);

                using(var stream = System.IO.File.Create(filePath))
                {
                    Img.CopyTo(stream);
                }

                // Save Img in Db
                brand.Img = fileName;
            }

            await _brandRepository.CreateAsync(brand);
            await _brandRepository.CommitAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit([FromRoute] int id)
        {
            var brand = await _brandRepository.GetOneAsync(e => e.Id == id);

            if (brand is null)
                return RedirectToAction(nameof(HomeController.NotFoundPage), "Home");

            return View(brand);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Brand brand, IFormFile? Img)
        {
            var brandInDb = await _brandRepository.GetOneAsync(e => e.Id == brand.Id, tracked: false);

            if (brandInDb is null)
                return RedirectToAction(nameof(HomeController.NotFoundPage), "Home");

            if (Img is not null && Img.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(Img.FileName);

                // Save Img in wwwroot
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\brand_images", fileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    Img.CopyTo(stream);
                }

                // Delete Old Img from wwwroot
                var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\brand_images", brandInDb.Img);

                if (System.IO.File.Exists(oldFilePath))
                {
                    System.IO.File.Delete(oldFilePath);
                }

                // Save Img in Db
                brand.Img = fileName;
            }
            else
            {
                brand.Img = brandInDb.Img;
            }

            _brandRepository.Update(brand);
            await _brandRepository.CommitAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var brand = await _brandRepository.GetOneAsync(e => e.Id == id);

            if (brand is null)
                return RedirectToAction(nameof(HomeController.NotFoundPage), "Home");

            // Delete Old Img from wwwroot
            var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\brand_images", brand.Img);

            if (System.IO.File.Exists(oldFilePath))
            {
                System.IO.File.Delete(oldFilePath);
            }

            _brandRepository.Delete(brand);
            await _brandRepository.CommitAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
