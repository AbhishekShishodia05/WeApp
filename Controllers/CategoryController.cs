using Microsoft.AspNetCore.Mvc;
using WeApp.DataAccess.Data;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                TempData["success"] = "Category has been added successfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryDb = _db.Categories.Find(id);
            if (categoryDb == null)
            {
                return NotFound();
            }
            return View(categoryDb);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                TempData["success"] = "Category has been updated successfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryDb = _db.Categories.Find(id);
            if (categoryDb == null)
            {
                return NotFound();
            }
            return View(categoryDb);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult Deleterecord(Category category)
        {
            Category? obj = _db.Categories.Find(category.Id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category has been deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
