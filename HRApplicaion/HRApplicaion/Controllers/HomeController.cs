using System.Diagnostics;

using HRApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Employees()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Employees(Employee employee)
        {
            Repository.addEmployee(employee);
            return View("confirmPage",employee);
        }

        public ViewResult AllEmployees()
        {
            return View(Repository.GetEmployees()); ;
        }

    }
}
