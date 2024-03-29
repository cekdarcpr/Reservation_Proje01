using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
