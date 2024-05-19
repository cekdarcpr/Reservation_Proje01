using Microsoft.AspNetCore.Mvc;
using Reservation_Proje01.CQRS.Commands.DestinationCommands;
using Reservation_Proje01.CQRS.Handlers.DestinationHandler;
using Reservation_Proje01.CQRS.Queries.DestinationQueries;

namespace Reservation_Proje01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _handler;
        private readonly GetDestinationByIdQueryHandler _IdHandler;
        private readonly CreateDestinationCommandHandler _CreateDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _RemoveDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _UpdateDestinationCommandHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler handler, GetDestinationByIdQueryHandler ıdHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _handler = handler;
            _IdHandler = ıdHandler;
            _CreateDestinationCommandHandler = createDestinationCommandHandler;
            _RemoveDestinationCommandHandler = removeDestinationCommandHandler;
            _UpdateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _IdHandler.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _UpdateDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _CreateDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            _RemoveDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }
    }
}

