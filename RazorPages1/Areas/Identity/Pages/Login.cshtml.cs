using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeIn2.Application.Identity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LifeIn2.RazorUI.Areas.Identity.Pages
{
    public class LoginModel : PageModel
    {
        public LoginVM LoginVM { get; set; }
        
        public void OnGet()
        {
        }
    }
}