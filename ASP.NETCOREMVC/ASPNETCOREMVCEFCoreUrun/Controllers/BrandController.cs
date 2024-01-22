using ASPNETCOREMVCEFCoreUrun.Data;
using ASPNETCOREMVCEFCoreUrun.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNETCOREMVCEFCoreUrun.Controllers
{
    public class BrandController : Controller
    {
        /*
         * Aşağıdaki yöntem ile ProductContext sınıfını newlemeden kullanabiliriz.
         * Program.cs'te kullanacağımız nesneler IoC konteynırına bağlarız ve ihtiyaç
         * halinde class'ın instance'ı orada oluşur.
         */
        private readonly ProductContext _productContext;

        public BrandController(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public IActionResult Index()
        {
            // Artık böyle kullanılmamalı!
            //ProductContext context = new ProductContext();
            //return View(context.Brands);

            return View(_productContext.Brands.ToList());
        }


        // GET: Brand/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brand/Create
        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            _productContext.Brands.Add(brand);
            _productContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
