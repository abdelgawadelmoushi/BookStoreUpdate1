using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
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

        // ✅ عرض صفحة إضافة المنتج
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        // ✅ استقبال البيانات بعد الضغط على "Save"
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                Repository.addProduct(product);
                return View("ProductAdded", Repository.GetProducts());
            }

            // في حالة وجود خطأ، يرجع لنفس الصفحة مع البيانات
            return View(product);
        }

        // ✅ عرض جميع المنتجات
        public IActionResult AllProducts()
        {
            return View(Repository.GetProducts());
        }
    
    }
}
