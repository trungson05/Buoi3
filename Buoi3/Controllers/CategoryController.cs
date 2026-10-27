using Buoi3.Data;
using Buoi3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Buoi3.Controllers
{
    public class CategoryController : Controller
    {
        //Gia lap CSDL
       
        // GET: CategoryController1
        public ActionResult Index()
        {
            return View(DataSeeds.categories);
        }

        // GET: CategoryController1/Details/5
        public ActionResult Details(int id)
        {
            var item = DataSeeds.categories.FirstOrDefault(c => c.CategoryId == id);
            if(item == null){
                return NotFound();
            }
           
            return View(item);
        }

        // GET: CategoryController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                  
                    category.CategoryId = DataSeeds.categories.Count+1;
                    DataSeeds.categories.Add(category);
                    return RedirectToAction(nameof(Index));
                }
                return View(category);
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController1/Edit/5
        public ActionResult Edit(int id)
        {
            var EditCategory = DataSeeds.categories.FirstOrDefault(c => c.CategoryId == id);
            if (EditCategory == null)
            {
                return NotFound();
            }
            return View(EditCategory);
        }

        // POST: CategoryController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            try
            {
               var item = DataSeeds.categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
               if(item == null)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController1/Delete/5
        public ActionResult Delete(int id)
        {
            var DeleteCategory = DataSeeds.categories.FirstOrDefault(c => c.CategoryId == id);
            if (DeleteCategory == null)
            {
                return NotFound();
            }
            return View(DeleteCategory);
        }

        // POST: CategoryController1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                var item = DataSeeds.categories.FirstOrDefault(c => c.CategoryId == id);
                if (item != null)
                {
                    DataSeeds.categories.Remove(item);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
