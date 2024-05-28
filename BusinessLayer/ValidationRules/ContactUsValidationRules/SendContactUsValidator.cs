using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUsValidationRules
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Boş Geçilemez");
        }
    }
}
