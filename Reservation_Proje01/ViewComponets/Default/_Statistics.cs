using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.Default
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            using var _context = new Context();
            ViewBag.v1 = _context.Destinations.Count();
            ViewBag.v2 = _context.Guides.Count();
            ViewBag.v3 = "285";
            return View(); 
        
        }
    }
}
