using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TshirtWebRazor.Data;
using TshirtWebRazor.Models;

namespace TshirtWebRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext database;
        public List<Category> CategoryList {  get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            database = db;
        }
        public void OnGet()
        {
            CategoryList = database.Categories.ToList();
        }
    }
}
