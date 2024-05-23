using MediatR;
using Reservation_Proje01.CQRS.Results.GuideResult;

namespace Reservation_Proje01.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery : IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
