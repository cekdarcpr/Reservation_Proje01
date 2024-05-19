using DataAccessLayer.Concrete;
using Reservation_Proje01.CQRS.Queries.DestinationQueries;
using Reservation_Proje01.CQRS.Results.DestinationResult;

namespace Reservation_Proje01.CQRS.Handlers.DestinationHandler
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                Daynight = values.DayNight,
                Capacity = values.Capacity,
                Price = values.Price
            };
        }
    }
}
