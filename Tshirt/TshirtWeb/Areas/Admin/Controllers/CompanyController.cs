using Microsoft.AspNetCore.Mvc;
using T_shirt.Data.Data;
using T_shirt.Data.Repository.IRepository;
using T_shirt.Models.Models;

namespace TshirtWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
        private readonly TshirtStoreDbContext _database;

        public CompanyController(TshirtStoreDbContext database) 
        {
            _database = database;          
        }


        public IActionResult Index()
        {

           // List<Company> objCompanyList = _database.Company.GetAll().ToList();

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

    //    [HttpPost]
    //
    //    public IActionResult Create(Company obj)
    //    {
    //
    //        if (obj.Name == obj.DisplayOrder.ToString())
    //        {
    //            ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
    //        }
    //
    //        if (obj.Name != null && obj.Name.ToLower() == "test")
    //        {
    //            ModelState.AddModelError("", "Test is invalid value.");
    //        }
    //
    //        if (ModelState.IsValid)
    //        {
    //
    //            _database.Company.Add(obj);
    //            _database.Save();
    //            TempData["success"] = "Company created succeddsully";
    //            return RedirectToAction("Index");
    //
    //        }
    //        return View();
    //
    //    }
    //
    //    public IActionResult Edit(int? id)
    //    {
    //
    //        if (id == null || id == 0)
    //        {
    //            return NotFound();
    //        }
    //
    //        Company? CompanyFromDb = _database.Company.Get(u => u.Id == id);
    //
    //        if (CompanyFromDb == null)
    //        {
    //            return NotFound();
    //        }
    //
    //        return View(CompanyFromDb);
    //    }
    //
    //
    //
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //
    //
    //    public IActionResult Edit(Company obj)
    //    {
    //
    //        if (ModelState.IsValid)
    //        {
    //            _database.Company.Update(obj);
    //            _database.Save();
    //            TempData["success"] = "Company edited succeddsully";
    //            return RedirectToAction("Index");
    //        }
    //
    //        return View();
    //
    //    }
    //
    //    [HttpDelete]
    //
    //    public IActionResult Delete(int? id)
    //    {
    //
    //        if (id == null || id == 0)
    //        {
    //            return NotFound();
    //        }
    //
    //        Company? CompanyFromDb = _database.Company.Get(u => u.Id == id);
    //
    //        if (CompanyFromDb == null)
    //        {
    //            return NotFound();
    //        }
    //
    //        return View(CompanyFromDb);
    //    }
    //
    //    [HttpPost, ActionName("Delete")]
    //
    //    public IActionResult DeletePOST(int? id)
    //    {
    //        Company? obj = _database.Company.Get(u => u.Id == id);
    //
    //        if (obj == null)
    //        {
    //            return NotFound();
    //        }
    //
    //        _database.Company.Remove(obj);
    //        _database.Save();
    //        TempData["success"] = "Company deleted successfully";
    //        return RedirectToAction("Index");
    //
    //    }
    }
}
