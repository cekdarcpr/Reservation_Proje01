using MediatR;
using Reservation_Proje01.CQRS.Results.GuideResult;

namespace Reservation_Proje01.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
