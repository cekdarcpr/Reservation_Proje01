using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.MemberLayout
{
    public class _MemberLayoutHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
