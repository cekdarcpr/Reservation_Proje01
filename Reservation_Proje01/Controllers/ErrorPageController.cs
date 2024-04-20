using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
