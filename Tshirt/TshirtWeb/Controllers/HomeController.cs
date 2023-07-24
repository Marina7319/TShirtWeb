using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using T_shirt.Models.Models;
using TshirtWeb.Services;

namespace TshirtWeb.Controllers
{
    public class HomeController : Controller
    {

        private readonly IScopedGuidService _scoped1;
        private readonly IScopedGuidService _scoped2;

        private readonly ISingletonGuidService _signleton1;
        private readonly ISingletonGuidService _signleton2;

        private readonly ITransientGuidService _transient1;
        private readonly ITransientGuidService _transient2;



        public HomeController(IScopedGuidService scopedGuid1,
            IScopedGuidService scopedGuid2,
            ISingletonGuidService signleton1,
            ISingletonGuidService signleton2, 
            ITransientGuidService transient1, 
            ITransientGuidService transient2)
        {
            _signleton1 = signleton1;
            _signleton2 = signleton2;
            _scoped1 = scopedGuid1;
            _scoped2 = scopedGuid2;
            _transient1 = transient1;
            _transient2 = transient2;
        }

        public IActionResult Index()
        {
            StringBuilder messages = new StringBuilder();
            messages.Append($"Transient 1 : {_transient1.GetGuid()}\n");
            messages.Append($"Transient 2 : {_transient2.GetGuid()}\n\n\n");
            messages.Append($"Scoped 1 : {_scoped1.GetGuid()}\n");
            messages.Append($"Scoped 2 : {_scoped2.GetGuid()}\n\n\n");
            messages.Append($"Singleton 1 : {_signleton1.GetGuid()}\n");
            messages.Append($"Singleton 2 : {_signleton2.GetGuid()}\n\n\n");

            return Ok(messages.ToString());

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}