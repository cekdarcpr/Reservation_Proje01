using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationManger destinationManger = new DestinationManger(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManger.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            destinationManger.TAdd(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = destinationManger.TGetByID(id);
            destinationManger.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id) 
        {
            var values = destinationManger.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            destinationManger.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
