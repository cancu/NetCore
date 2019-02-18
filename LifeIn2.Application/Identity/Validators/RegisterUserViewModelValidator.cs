using FluentValidation;
using CancuNetCore.Application.Identity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CancuNetCore.Application.Identity.Validators
{
    public class RegisterUserViewModelValidator : AbstractValidator<RegisterUserViewModel>
    {
        public RegisterUserViewModelValidator()
        {
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.Password).NotNull().Equal(x => x.ConfirmPassword).WithMessage("Şifre uyumsuz");

        }
    }
}
