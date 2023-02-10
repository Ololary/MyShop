using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext? _db;
        public CategoryController(ApplicationDbContext? db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
             IEnumerable<Category>? objList = _db.Category;
            return View(objList);
        }
        //Get create
        public IActionResult Create()
        {          
            return View();
        }

        //Post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            _db.Category.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
