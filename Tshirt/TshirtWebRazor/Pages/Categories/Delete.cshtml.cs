using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TshirtWebRazor.Data;
using TshirtWebRazor.Models;

namespace TshirtWebRazor.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext database;

        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            database = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = database.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            Category? obj = database.Categories.Find(Category.Id);

            if (obj == null)
            {
                return NotFound();
            }

            database.Categories.Remove(obj);
            database.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
        }
    }
}
