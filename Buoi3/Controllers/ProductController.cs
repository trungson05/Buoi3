using Buoi3.Data;
using Buoi3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buoi3.Controllers
{
    public class ProductController : Controller
    {
        
        // GET: ProductsController
        public ActionResult Index()
        {
            return View(DataSeeds.products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var item = DataSeeds.products.FirstOrDefault(p => p.ProductId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            product.ProductId = DataSeeds.products.Count + 1;
            DataSeeds.products.Add(product);
            return RedirectToAction(nameof(Index));
            
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            var EditProduct = DataSeeds.products.FirstOrDefault(p => p.ProductId == id);
            if (EditProduct == null)
            {
                return NotFound();
            }
            return View(EditProduct);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {

           
                var item = DataSeeds.products.FirstOrDefault(p => p.ProductId == product.ProductId);
                if (item == null)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));           
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = DataSeeds.products.FirstOrDefault(p => p.ProductId == id);
            return View(item);
        }

        // POST: ProductsController/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConFirm(int id)
        {
            var item = DataSeeds.products.FirstOrDefault(p => p.ProductId == id);
            if (item == null)
            {
                return NotFound();
            }
            DataSeeds.products.Remove(item);
            return RedirectToAction(nameof(Index));
        }
    }
}
