using Microsoft.AspNetCore.Mvc;

namespace TshirtWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
