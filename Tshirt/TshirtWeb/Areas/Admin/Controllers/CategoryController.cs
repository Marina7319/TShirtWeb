﻿namespace TshirtWeb.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using T_shirt.Data.Repository.IRepository;


    using T_shirt.Models.Models;
    using T_shirtStore.Utility;

    [Area("Admin")]
    [Authorize(Roles = StaticDetails.roleAdmin)]

    public class CategoryController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;


        public CategoryController(IUnitOfWork db)
        {

            _unitOfWork = db;

        }


        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Category obj)
        {

            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }

            if (obj.Name != null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is invalid value.");
            }

            if (ModelState.IsValid)
            {


                _unitOfWork.Category.Add(obj);

                _unitOfWork.Save();
                TempData["success"] = "Category created succeddsully";
                return RedirectToAction("Index");


            }

            return View();

        }



        public IActionResult Edit(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            // Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u =>u.Id == id);
            // Category? categoryFromDb2 = _categoryRepository.Categories.Where(u => u.Id == id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost]

        public IActionResult Edit(Category obj)
        {


            if (ModelState.IsValid)
            {


                _unitOfWork.Category.Update(obj);

                _unitOfWork.Save();
                TempData["success"] = "Category edited succeddsully";
                return RedirectToAction("Index");


            }

            return View();

        }

        public IActionResult Delete(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u =>u.Id == id);
            // Category? categoryFromDb2 = _db.Categories.Where(u => u.Id == id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]

        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _unitOfWork.Category.Get(u => u.Id == id);

            if (obj == null)
            {
                return NotFound();
            }


            _unitOfWork.Category.Remove(obj);

            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");

        }

    }
}
