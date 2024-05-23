using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using Reservation_Proje01.CQRS.Commands.GuideCommads;

namespace Reservation_Proje01.CQRS.Handlers.GuideHandler
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Image = request.Image,
                Status = true

            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
