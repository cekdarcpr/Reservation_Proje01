using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.AdminDashboard
{
    public class _AdminGuideList :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
