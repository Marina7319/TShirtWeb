namespace TshirtWebRazor.Pages.Products
{

    using Microsoft.AspNetCore.Mvc;

    using Microsoft.AspNetCore.Mvc.RazorPages;

    using TshirtWebRazor.Data;

    using TshirtWebRazor.Models;

    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext database;

        public Product Product { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            database = db;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            database.Products.Add(Product);
            database.SaveChanges();
            //TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
