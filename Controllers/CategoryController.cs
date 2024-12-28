using Microsoft.AspNetCore.Mvc;

namespace WeApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
