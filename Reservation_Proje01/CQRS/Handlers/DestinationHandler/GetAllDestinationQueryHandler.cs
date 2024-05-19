using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Reservation_Proje01.CQRS.Queries.DestinationQueries;
using Reservation_Proje01.CQRS.Results.DestinationResult;

namespace Reservation_Proje01.CQRS.Handlers.DestinationHandler
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle() 
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult{
                id = x.DestinationID,
                city = x.City,
                capacity = x.Capacity,
                dayNight = x.DayNight,
                price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
