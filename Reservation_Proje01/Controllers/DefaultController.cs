using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
