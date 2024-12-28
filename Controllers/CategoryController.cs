using Microsoft.AspNetCore.Mvc;
using WeApp.Data;
using WeApp.Models;

namespace WeApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicatioDBContext _db;
        public CategoryController(ApplicatioDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}
