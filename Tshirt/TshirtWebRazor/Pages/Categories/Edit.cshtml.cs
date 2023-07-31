using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TshirtWebRazor.Data;
using TshirtWebRazor.Models;

namespace TshirtWebRazor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext database;

        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            database = db;
        }
        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                Category = database.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                database.Categories.Update(Category);
                database.SaveChanges();
                TempData["success"] = "Category edited succeddsully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
