using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() 
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş bırakılamaz...");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("En az 20 karakterli açıklama yazınız...");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("En fazla 1500 karakterli açıklama yazabilirsiniz");
        }

    }
}
