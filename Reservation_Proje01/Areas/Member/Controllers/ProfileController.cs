using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
