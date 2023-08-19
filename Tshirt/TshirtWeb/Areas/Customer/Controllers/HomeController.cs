namespace TshirtWeb.Areas.Customer.Controllers
{

    using Microsoft.AspNetCore.Authorization;

    using Microsoft.AspNetCore.Mvc;

    using System.Diagnostics;

    using System.Security.Claims;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    [Area("Customer")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;

        }
    

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            return View(productList);
           

        }

        public IActionResult Details(int productId)
        {
            var productFromDb = _unitOfWork.Product
                .GetFirstOrDefault(u => u.Id == productId, includeProperties: "Category");
            ShoppingCart cartObject = new ShoppingCart()
            {
     
                Product = productFromDb,
                ProductId = productFromDb.Id
     
            };
            return View(cartObject);
     
        }
     
        [HttpPost]
        [ValidateAntiForgeryToken]
   //     [Authorize]
     
        public IActionResult Details(ShoppingCart CartObject)
        {
     
            CartObject.Id = 0;
            if(ModelState.IsValid)
            {
                //then we will add to cart
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                CartObject.ApplicationUserId = claim.Value;
     
                ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.GetFirstOrDefault(
                    u => u.ApplicationUserId == CartObject.ApplicationUserId && u.ProductId == CartObject.ProductId,
                    includeProperties: "Product");
     
                if(cartFromDb == null)
                {
                    // no records exists in database for that product for that user
                    _unitOfWork.ShoppingCart.Add(CartObject);
                }
                else 
                { 
                    cartFromDb.Count += CartObject.Count;
                    //_unitOfWork.ShoppingCart.Update(cartFromDb);
                }
     
                _unitOfWork.Save();
     
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var productFromDb = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == CartObject.ProductId, includeProperties: "Category");
                ShoppingCart cartObject = new ShoppingCart()
                {
                    Product = productFromDb,
                    ProductId = productFromDb.Id
     
                };
                // return View(product);
                return View(cartObject);
            }
          
     
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