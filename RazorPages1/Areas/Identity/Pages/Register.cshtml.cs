using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CancuNetCore.Application.Identity.Models;
using CancuNetCore.Application.Interfaces;
using CancuNetCore.Domain.Entities.Security;
using CancuNetCore.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CancuNetCore.RazorUI.Areas.Identity.Pages
{
    public class RegisterModel : PageModel
    {
        //private readonly NorthwindContext context;
        private readonly IRepositoryWrapper _repositoryWrapper;

        [BindProperty]
        public RegisterUserViewModel ViewModel { get; set; }

        public RegisterModel(IRepositoryWrapper repositoryWrapper)
        {
            this._repositoryWrapper = repositoryWrapper;
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var checkUser = _repositoryWrapper.User.Get(u => u.UserName == ViewModel.UserName).FirstOrDefault();

            if (checkUser != null)
            {
                ModelState.AddModelError("", "Bu kullanici adi kullanimda");
                return Page();
            }

            var newUser = new User();
            newUser.UserName = ViewModel.UserName;
            newUser.Email = ViewModel.Email;
            newUser.Password= ViewModel.Password;

            _repositoryWrapper.User.Add(newUser);

            _repositoryWrapper.User.Save();

            return RedirectToPage("/Login", new { area = "Identity" });
        }
    }
}