namespace TshirtWeb.Areas.Admin.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.ViewModels;

    public class UserController : Controller
    {
        public readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("users")]
        public async Task<IActionResult> Index()
        {
            var users = await _userRepository.GetAllUsers();
            List<UserViewModel> result = new List<UserViewModel>();
            foreach (var user in users)
            {
                var userViewModel = new UserViewModel()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                };
                result.Add(userViewModel);
            }
            return View(result);
        }

        public async Task<IActionResult> Details(string id)
        {
            var user = await _userRepository.GetUserById(id);
            var userDetailViewModel = new UserDetailViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
            };
            return View(userDetailViewModel);
        }
    }
}
