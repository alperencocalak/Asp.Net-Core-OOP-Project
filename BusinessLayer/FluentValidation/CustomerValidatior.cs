using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidatior : AbstractValidator<Customer>
    {
        public CustomerValidatior()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Adı Boş Geçilemez.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Boş Geçilemez.");
        }
    }
}
