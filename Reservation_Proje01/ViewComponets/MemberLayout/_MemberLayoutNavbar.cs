using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.MemberLayout
{
    public class _MemberLayoutNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
