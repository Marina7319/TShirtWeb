using Microsoft.AspNetCore.Mvc.Rendering;
using T_shirt.Models.Models;

namespace T_shirt.Models.ViewModels
{
    public class RoleManagmentViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }
        public IEnumerable<SelectListItem> CompanyList { get; set; }
    }
}
