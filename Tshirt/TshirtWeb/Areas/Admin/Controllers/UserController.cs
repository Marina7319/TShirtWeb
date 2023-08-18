namespace TshirtWeb.Areas.Admin.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    using Microsoft.EntityFrameworkCore;

    using T_shirt.Data.Data;
    using T_shirt.Data.Repository.IRepository;
    using T_shirt.Models.Models;

    [Area("Admin")]
    public class UserController : Controller
    {

        private readonly TshirtStoreDbContext _database;
 
        public UserController(TshirtStoreDbContext database) 
        {

            _database = database;

        }


        public IActionResult Index()
        {
            return View();
        }



        #region API CALLS

        [HttpGet]

        public IActionResult GetAll()
        {
            var userList = _database.ApplicationUsers.Include(u => u.Company).ToList();
            var userRole = _database.UserRoles.ToList();
            var roles = _database.Roles.ToList();
            foreach (var user in userList)
            {
                var roleId = userRole.FirstOrDefault(u => u.UserId == user.Id).RoleId;
                user.Role = roles.FirstOrDefault(u => u.Id == roleId).Name;

                if(user.Company == null)
                {
                    user.Company = new Company()
                    {
                        Name = ""
                    };
                }

            }
            return Json(new { data = userList });
        }

        #endregion
    }
}
