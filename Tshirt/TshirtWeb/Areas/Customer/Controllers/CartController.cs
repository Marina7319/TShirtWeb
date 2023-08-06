using Microsoft.AspNetCore.Mvc;

namespace TshirtWeb.Areas.Customer.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
