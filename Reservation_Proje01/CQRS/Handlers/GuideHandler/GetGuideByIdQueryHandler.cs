using DataAccessLayer.Concrete;
using MediatR;
using Reservation_Proje01.CQRS.Queries.GuideQueries;
using Reservation_Proje01.CQRS.Results.GuideResult;
using System.ComponentModel.DataAnnotations;

namespace Reservation_Proje01.CQRS.Handlers.GuideHandler
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
