using DataAccessLayer.Concrete;
using Reservation_Proje01.CQRS.Commands.DestinationCommands;

namespace Reservation_Proje01.CQRS.Handlers.DestinationHandler
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationID);
            values.City = command.City;
            values.DayNight = command.Daynight;
            values.Capacity = command.Capacity;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}
