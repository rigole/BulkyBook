using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Data;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryController (ApplicationDbContext db)
        {
            dbContext = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = dbContext.Categories;
            return View(objCategoryList);
        }
    }
}
