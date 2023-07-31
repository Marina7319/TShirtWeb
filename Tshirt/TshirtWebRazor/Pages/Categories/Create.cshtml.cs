using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TshirtWebRazor.Data;
using TshirtWebRazor.Models;

namespace TshirtWebRazor.Pages.Categories
{
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
    }
}
