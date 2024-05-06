using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Bırakılamaz...");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Duyuru Boş Bırakılamaz...");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 Karakter olmalıdır...");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("En az 20 Karakter olmalıdır...");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("En Fazla 20 Karakter olmalıdır...");
            RuleFor(x => x.Content).MaximumLength(200).WithMessage("En Fazla 200 Karakter olmalıdır...");
        }
    }
}
