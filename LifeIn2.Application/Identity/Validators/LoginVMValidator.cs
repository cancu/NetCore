using FluentValidation;
using CancuNetCore.Application.Identity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CancuNetCore.Application.Identity.Validators
{
    public class LoginVMValidator : AbstractValidator<LoginVM>
    {
        public LoginVMValidator()
        {
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.Password).NotNull();
        }
    }
}
