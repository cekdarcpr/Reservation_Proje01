using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
