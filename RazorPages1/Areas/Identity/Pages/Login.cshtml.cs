using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LifeIn2.Application.Identity.Models;
using LifeIn2.Application.Repository;
using LifeIn2.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LifeIn2.RazorUI.Areas.Identity.Pages
{
    public class LoginModel : PageModel
    {
        //private readonly NorthwindContext context;
        private readonly IRepositoryWrapper _repoWrapper; 

        [BindProperty]
        public LoginVM LoginVM { get; set; }

        public LoginModel(IRepositoryWrapper repositoryWrapper)
        {
            this._repoWrapper = repositoryWrapper;
        }

        public ActionResult OnPostLogin()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //todo application a query nesnesi olarak yaz
            //var user = context.User.FirstOrDefault(u => u.UserName == LoginVM.UserName && u.Password == LoginVM.Password);

            var user = _repoWrapper.User.Get(u => u.UserName == LoginVM.UserName && u.Password == LoginVM.Password).FirstOrDefault();

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password");
                return Page();
            }

            this.SignInUser(LoginVM.UserName, user.Email, false);

            return RedirectToPage("Index");
        }

        private Task SignInUser(string username, string email, bool isPersistent)
        {
            // Initialization.  
            var claims = new List<Claim>();

            try
            {
                // Setting  
                claims.Add(new Claim(ClaimTypes.Name, username));
                claims.Add(new Claim(ClaimTypes.Email, email));
                var claimIdenties = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimPrincipal = new ClaimsPrincipal(claimIdenties);
                var authenticationManager = Request.HttpContext;

                // Sign In.  
                authenticationManager.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, new AuthenticationProperties() { IsPersistent = isPersistent });
            }
            catch (Exception ex)
            {
                // Info  
                throw ex;
            }

            return null;
        }
    }
}