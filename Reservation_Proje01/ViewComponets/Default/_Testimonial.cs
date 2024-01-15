using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;
using BusinessLayer.Concrete;

namespace Reservation_Proje01.ViewComponets.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.GetList();
            return View(values);
        }
    }
}
