using System.Diagnostics;
using adminMangementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace adminMangementSystem.Controllers
{
    [Area ("Admin")]   
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult appointment()
        {
            return View();
        }
        public IActionResult BookAppointment()
        {
            return View();
        }
        public IActionResult CompleteAppointment()
        {
            return View();
        }
        public IActionResult departmentdetails()
        {
            return View();
        }
        public IActionResult departments()
        {
            return View();
        }
        public IActionResult admins()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult ReservationsManagement()
        {
            return View();
        }
        public IActionResult services()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
