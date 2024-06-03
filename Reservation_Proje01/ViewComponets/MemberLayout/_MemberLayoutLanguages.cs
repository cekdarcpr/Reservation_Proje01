using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.MemberLayout
{
    public class _MemberLayoutLanguages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
