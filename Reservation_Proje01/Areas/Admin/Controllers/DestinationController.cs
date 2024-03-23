using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Areas.Admin.Controllers
{
    public class DestinationController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
