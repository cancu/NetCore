using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeIn2.Application.Identity.Models;
using LifeIn2.Domain.Entities.Security;
using LifeIn2.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LifeIn2.RazorUI.Areas.Identity.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly NorthwindContext context;

        [BindProperty]
        public RegisterUserViewModel ViewModel { get; set; }

        public RegisterModel(NorthwindContext context)
        {
            this.context = context;
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var checkUser = context.User.FirstOrDefault(u => u.UserName == ViewModel.UserName);

            if (checkUser != null)
            {
                ModelState.AddModelError("", "Bu kullan?c? ad? kullan?mda");
                return Page();
            }

            var newUser = new User();
            newUser.UserName = ViewModel.UserName;
            newUser.Email = ViewModel.Email;
            newUser.Password= ViewModel.Password;

            context.Add(newUser);

            context.SaveChanges();

            return RedirectToPage("/Login", new { area = "Identity" });
        }
    }
}