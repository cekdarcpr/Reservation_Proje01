using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetDastinationById(id);
            return View(values); 
        }
    }
}
