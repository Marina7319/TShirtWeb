﻿#nullable disable
namespace TshirtWeb.Areas.Identity.Pages.Account
{

    using Microsoft.AspNetCore.Authorization;

    using Microsoft.AspNetCore.Mvc.RazorPages;

    [AllowAnonymous]
    public class ForgotPasswordConfirmation : PageModel
    {

        public void OnGet()
        {
        }
    }
}
