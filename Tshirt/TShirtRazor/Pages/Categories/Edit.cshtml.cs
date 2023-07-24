using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TShirtRazor.Data;
using TShirtRazor.Models;

namespace TShirtRazor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;

        }

        public Category Category {  get; set; }


        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {


                _db.Categories.Update(Category);

                _db.SaveChanges();
                TempData["success"] = "Category edited succeddsully";
                return RedirectToAction("Index");


            }
            return Page();
        }
    }
}
