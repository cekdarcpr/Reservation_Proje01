using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.Default
{
    public class _PopulerDestinations : ViewComponent
    {
        DestinationManger destinationManger = new DestinationManger(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            var values = destinationManger.GetList();
            
            return View(values);
        }
    }
}
