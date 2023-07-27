﻿namespace TshirtWeb.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using T_shirt.Data.Repository.IRepository;


    using T_shirt.Models.Models;
    using T_shirt.Models.ViewModels;

    [Area("Admin")]


    public class ProductController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public ProductController(IUnitOfWork db, IWebHostEnvironment webHostEnvironment)
        {

            _unitOfWork = db;
            _webHostEnvironment = webHostEnvironment;

        }


        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties:"Category").ToList();

            return View(objProductList);
        }

        public IActionResult Update(int? id)
        {

            ProductViewModel productViewModel = new()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Product = new Product()
            };

            if (id == null || id == 0)
            {
                return View(productViewModel);
            }
            else
            {
                //update
                productViewModel.Product = _unitOfWork.Product.Get(u => u.Id == id);
                return View(productViewModel);
            }

            // return View(productViewModel);
        }

        [HttpPost]

        public IActionResult Update(ProductViewModel productViewModel, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product");

                    if(!string.IsNullOrEmpty(productViewModel.Product.ImageUrl))
                    {
                        //delete the old image
                        var oldImagePath = Path.Combine(wwwRootPath, productViewModel.Product.ImageUrl.TrimStart('\\'));

                        if(System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    productViewModel.Product.ImageUrl = @"\images\product\" + fileName;
                }
                if(productViewModel.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(productViewModel.Product);
                }
                else
                {
                    _unitOfWork.Product.Update(productViewModel.Product);
                }
              //  _unitOfWork.Product.Add(productViewModel.Product);
                _unitOfWork.Save();
                TempData["success"] = "Product created succeddsully";
                return RedirectToAction("Index");
            }
            else
            {

                productViewModel.CategoryList = _unitOfWork.Category
               .GetAll().Select(u => new SelectListItem
               {
                   Text = u.Name,
                   Value = u.Id.ToString()


               });
                return View(productViewModel);
            }

        }



        //   public IActionResult Edit(int? id)
        //   {
        //       if (id == null || id == 0)
        //       {
        //           return NotFound();
        //       }
        //       Product? productFromDb = _unitOfWork.Product.Get(u => u.Id == id);
        //       // Product? categoryFromDb1 = _db.Categories.FirstOrDefault(u =>u.Id == id);
        //       // Product? categoryFromDb2 = _categoryRepository.Categories.Where(u => u.Id == id).FirstOrDefault();
        //
        //       if (productFromDb == null)
        //       {
        //           return NotFound();
        //       }
        //       return View(productFromDb);
        //   }
        //
        //   [HttpPost]
        //
        //   public IActionResult Edit(Product obj)
        //   {
        //       if (ModelState.IsValid)
        //       {
        //           _unitOfWork.Product.Update(obj);
        //           _unitOfWork.Save();
        //           TempData["success"] = "Product edited succeddsully";
        //           return RedirectToAction("Index");
        //       }
        //       return View();
        //   }

   

        [HttpPost, ActionName("Delete")]

        public IActionResult DeletePOST(int? id)
        {
            Product? obj = _unitOfWork.Product.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Product.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");
        }

        #region API CALLS

        [HttpGet]

        public IActionResult GetAll(int id)
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = objProductList });
        }

        [HttpDelete]

        public IActionResult Delete(int? id)
        {
            var productToDeleted = _unitOfWork.Product.Get(u => u.Id == id);
            if(productToDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            //delete the old image
            var oldImagePath = 
                Path.Combine(_webHostEnvironment.WebRootPath, 
                productToDeleted.ImageUrl.TrimStart('\\'));

            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Product.Remove(productToDeleted);
            _unitOfWork.Save();
      
            return Json(new { success = true, message = "Delete Successful" });
        }


        #endregion

    }
}
