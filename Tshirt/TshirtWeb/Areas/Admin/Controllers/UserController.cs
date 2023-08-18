namespace TshirtWeb.Areas.Admin.Controllers
{

    using Microsoft.AspNetCore.Authorization;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using T_shirt.Data.Data;
    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    using T_shirtStore.Utility;

    [Area("Admin")]
    [Authorize(Roles = StaticDetails.roleAdmin)]

    public class UserController : Controller
    {

        private readonly TshirtStoreDbContext database;

        public UserController(TshirtStoreDbContext _database)
        {

            database = _database;

        }


        public IActionResult Index()
        {

            //  List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();

            //return View(objCategoryList);
            return View();
        }



        #region API CALLS

        [HttpGet]

        public IActionResult GetAll()
        {
            var userList = database.ApplicationUsers.Include(u => u.Company).ToList();
            var userRole = database.UserRoles.ToList();
            var roles = database.Roles.ToList();
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
