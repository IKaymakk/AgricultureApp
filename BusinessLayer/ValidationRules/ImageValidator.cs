using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel Adı Boş Bırakılamaz")
               .MinimumLength(3).WithMessage("Görsel Adı En Az 3 Karakter Olabilir")
               .MaximumLength(20).WithMessage("Görsel Adı En Fazla 20 Karakter Olabilir");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel Açıklamasını Boş Bırakılamaz")
               .MinimumLength(10).WithMessage("Görsel Açıklaması En Az 10 Karakter Olabilir")
               .MaximumLength(50).WithMessage("Görsel Açıklaması En Fazla 50 Karakter Olabilir");
        }
    }
}
