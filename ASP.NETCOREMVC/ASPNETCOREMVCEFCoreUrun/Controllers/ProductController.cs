using ASPNETCOREMVCEFCoreUrun.Data;
using ASPNETCOREMVCEFCoreUrun.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCOREMVCEFCoreUrun.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _productContext;

        public ProductController(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public IActionResult Index()
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.Category).OrderBy(x=>x.ProductID).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            var viewModel = new ProductViewModel
            {
                Brands = new SelectList(_productContext.Brands, "BrandID", "Name"),
                Categories = new SelectList(_productContext.Categories, "CategoryID", "Name")
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel viewModel, IFormFile image)
        {
                if (image != null && image.Length > 0)
                {
                    string guid = Guid.NewGuid().ToString() + "_" + image.FileName;
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", guid);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        image.CopyToAsync(fileStream);
                    }

                    viewModel.Product.ImagePath = $"~/images/{guid}";
                }

            _productContext.Products.Add(viewModel.Product);
            _productContext.SaveChangesAsync();

            viewModel.Brands = new SelectList(_productContext.Brands, "BrandID", "Name", viewModel.Product.BrandID);
            viewModel.Categories = new SelectList(_productContext.Categories, "CategoryID", "Name", viewModel.Product.CategoryID);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = _productContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductViewModel
            {
                Product = product,
                Brands = new SelectList(_productContext.Brands, "BrandID", "Name", product.BrandID),
                Categories = new SelectList(_productContext.Categories, "CategoryID", "Name", product.CategoryID)
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, ProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _productContext.Update(viewModel.Product);
                _productContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            viewModel.Brands = new SelectList(_productContext.Brands, "BrandID", "Name", viewModel.Product.BrandID);
            viewModel.Categories = new SelectList(_productContext.Categories, "CategoryID", "Name", viewModel.Product.CategoryID);
            return View(viewModel);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _productContext.Products
                .FirstOrDefault(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _productContext.Products.Find(id);
            _productContext.Products.Remove(product);
            _productContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
