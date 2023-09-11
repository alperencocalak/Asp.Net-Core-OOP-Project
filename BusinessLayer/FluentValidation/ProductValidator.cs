using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Product>
    {
        public CustomerValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ürün Adını Boş Geçemezsiniz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün Adı Üç Karakterden Küçük Olamaz.");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok Sayısı Boş Geçilemez.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün Fiyatı Boş Geçilemez.");
        }

        public ValidationResult Validate(Customer p)
        {
            throw new NotImplementedException();
        }
    }
}
