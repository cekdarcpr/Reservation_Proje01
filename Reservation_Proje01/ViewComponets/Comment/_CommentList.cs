using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.ViewComponets.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new Context();

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.v = context.Comments.Where(x => x.DestinationID == id).Count();
            var values = commentManager.TGetCommentWithDestinationAndUser(id);
            return View(values); 
        }
    }
}
