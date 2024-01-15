using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManger destinationManger = new DestinationManger(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManger.GetList();

            return View(values);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values= destinationManger.TGetByID(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
