using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Application.Identity.Models
{
    public class RegisterUserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
