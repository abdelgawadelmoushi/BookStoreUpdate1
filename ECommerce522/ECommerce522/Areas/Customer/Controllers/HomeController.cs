using System.Diagnostics;
using ECommerce522.Models;
using ECommerce522.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace ECommerce522.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Repository<Product> _productRepository = new();

        public int Id { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        ApplicationDbContext _context = new();

        public async Task<IActionResult> Index()
        {
         var products = await _productRepository.GetAsync();
          
            return View(products.AsEnumerable());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult Welcome () {

            return View();
        
        }
        public ViewResult ProductAdded()
        {

            return View();

        }

      
        public IActionResult viewAllProducts()
        {
            return View();
        }

        public ViewResult PersonInfo()
        {
            List<PersonInfo> persons = [
                new PersonInfo() {
      Id = 1, Name = "Ahmed", Age = 25 ,Skills = ["C#" , "CSS"]
        },
                    new PersonInfo() {
      Id = 1, Name = "Amr", Age = 35 ,Skills = ["C#" , ".net"]
        }

                ];
                ;
            return View(persons);

        }
        [HttpGet]
        public IActionResult AddProducts()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> AddProducts(Product product)
        {

            await _productRepository.CreateAsync(product);
            await _productRepository.CommitAsync();

            return RedirectToAction(nameof(Index));
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
