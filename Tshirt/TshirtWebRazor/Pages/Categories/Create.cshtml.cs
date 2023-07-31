namespace TshirtWebRazor.Pages.Categories
{
    using Microsoft.AspNetCore.Mvc;

    using Microsoft.AspNetCore.Mvc.RazorPages;

    using TshirtWebRazor.Data;

    using TshirtWebRazor.Models;

    [BindProperties]

    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext database;

        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            database = db;
        }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            database.Categories.Add(Category);
            database.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
