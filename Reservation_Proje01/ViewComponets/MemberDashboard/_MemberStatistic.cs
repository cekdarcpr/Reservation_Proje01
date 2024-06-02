using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.MemberDashboard
{
    public class _MemberStatistic : ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
