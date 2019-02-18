using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CancuNetCore.RazorUI.Areas.Identity.Pages
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            try
            {
                var authenticationManager = Request.HttpContext;
                await authenticationManager.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToPage("/Login", new { area = "Identity" });
        }
    }
}