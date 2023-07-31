using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TshirtWebRazor.Data;
using TshirtWebRazor.Models;

namespace TshirtWebRazor.Pages.Products
{


    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext database;
        public List<Product> ProductList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            database = db;
        }
        public void OnGet()
        {
            ProductList = database.Products.ToList();
        }
    }
}
