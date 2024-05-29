using Microsoft.AspNetCore.Mvc;

using WebApp4ByNishan.Controllers.Repository;
using WebApp4ByNishan.Models;

namespace WebApp4ByNishan.Controllers
{
    public class ProductController : Controller
    {
        // ****** Dependency Injection of ProductRepo using Interface(IRepository) ******
        private readonly IRepository<Product> _repo = null;
        public ProductController(IRepository<Product> repo)
        {
            _repo = repo;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            // ****** Use ProductRepo to get all records ******
            return View(_repo.GetAllRecords());
            //return View();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            // ****** Use ProductRepo to get single record ******
            return View(_repo.GetSingleRecord(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product prod)
        {
            try
            {
                if (ModelState.IsValid)    // Check validity of model before performing operation 
                {
                    // ****** Use ProductRepo to add record ******
                    _repo.AddRecord(prod);
                    // 'TempData[]' is globally accessible in ASP.NET. We set it to non-null
                    TempData["success_on_insert"] = "Inserted";
                    // Go back to index page by setting 'TempData[]'
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(prod);
                }
            }
            catch (Exception ex)
            {
                return Content("Something went wrong when inserting record: " + ex.Message);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            // ****** Use ProductRepo to edit single record ******
            return View(_repo.GetSingleRecord(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(int id, Product updatedProduct)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Retrieve the existing product from the repository
                    Product existingProduct = _repo.GetSingleRecord(id);

                    // Update the existing product with the values from the updated product
                    existingProduct.Name = updatedProduct.Name;
                    existingProduct.Price = updatedProduct.Price;
                    existingProduct.Description = updatedProduct.Description;

                    // Use ProductRepo to update the record
                    _repo.UpdateRecord(existingProduct);

                    TempData["success_on_edit"] = "Edited";
                    return RedirectToAction("Index");
                }
                else
                {
                    // If ModelState is not valid, return the Edit view with the updatedProduct model
                    return View(updatedProduct);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong when updating record: " + ex.Message);
                return View(updatedProduct);
            }
        }



        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            // ****** Use ProductRepo to delete single record ******
            return View(_repo.GetSingleRecord(id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormFileCollection collection)
        {
            // Simply, get the product object using ProductRepo method
            Product prod = _repo.GetSingleRecord(id);
            try
            {
                if (ModelState.IsValid)
                {
                    // ****** Use ProductRepo to delete record ******
                    _repo.DeleteRecord(prod);
                    TempData["success_on_delete"] = "Deleted";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(prod);
                }
            }
            catch (Exception ex)
            {
                return Content("Something went wrong when deleting record: " + ex.Message);
            }
        }
    }
}