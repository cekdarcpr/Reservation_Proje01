using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
