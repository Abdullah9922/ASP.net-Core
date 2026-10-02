using Microsoft.AspNetCore.Mvc;
using First_Demo_MVC.Models;
namespace First_Demo_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProdectData(Product p)
        {
            ViewBag.Id = p.Id;
            ViewBag.Name = p.Name;
            ViewBag.Price = p.Price;
            return View(p);
        }
    }
}
