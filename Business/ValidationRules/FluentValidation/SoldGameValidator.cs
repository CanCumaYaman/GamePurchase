using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class SoldGameValidator:AbstractValidator<SoldGame>
    {
        public SoldGameValidator()
        {
            RuleFor(p => p.GameName).NotEmpty();
            RuleFor(p => p.GameName).MinimumLength(2);
            RuleFor(p => p.GamerName).NotEmpty();
            RuleFor(p => p.GamerName).MinimumLength(2);
            RuleFor(p => p.GamerLastName).NotEmpty();
            RuleFor(p => p.GamerLastName).MinimumLength(2);
            RuleFor(p => p.SoldDate).GreaterThan(DateTime.Now).WithMessage("You can not sold this game for next date");
            
        }
    }
}
