using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
