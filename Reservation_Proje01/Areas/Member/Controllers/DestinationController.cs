using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class DestinationController : Controller
    {
        DestinationManger destinationManger = new DestinationManger(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManger.GetList();
            return View(values);
        }
    }
}
