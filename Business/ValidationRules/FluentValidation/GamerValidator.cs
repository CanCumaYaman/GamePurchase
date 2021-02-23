using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class GamerValidator:AbstractValidator<Gamer>
    {
        public GamerValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.IdentityNumber).NotEmpty();
            RuleFor(p => p.Dob).LessThan(DateTime.Now).WithMessage("DOB must be less than today");

        }
    }
}
