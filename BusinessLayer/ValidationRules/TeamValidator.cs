using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Personel Adı Boş Bırakılamaz")
                .MinimumLength(3).WithMessage("Personel Adı En Az 3 Karakter Olabilir")
                .MaximumLength(50).WithMessage("Personel Adı En Fazla 50 Karakter Olabilir");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Personel Görevi Boş Bırakılamaz")
              .MinimumLength(10).WithMessage("Personel görevi En Az 10 Karakter Olabilir")
              .MaximumLength(150).WithMessage("Personel Adı En Fazla 150 Karakter Olabilir");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Personel Resmi Boş Bırakılamaz");
        }
    }
}
