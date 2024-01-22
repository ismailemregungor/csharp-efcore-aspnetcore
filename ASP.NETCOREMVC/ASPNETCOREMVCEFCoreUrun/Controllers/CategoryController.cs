using ASPNETCOREMVCEFCoreUrun.Data;
using ASPNETCOREMVCEFCoreUrun.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCOREMVCEFCoreUrun.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProductContext _productContext;

        public CategoryController(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public IActionResult Index()
        {
            return View(_productContext.Categories.ToList());
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _productContext.Categories.Add(category);
            _productContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
