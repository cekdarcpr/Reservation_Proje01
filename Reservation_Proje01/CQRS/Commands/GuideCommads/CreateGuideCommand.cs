using MediatR;

namespace Reservation_Proje01.CQRS.Commands.GuideCommads
{
    public class CreateGuideCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
