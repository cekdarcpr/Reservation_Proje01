using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {

        List<Reservation> GetListWithvalReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPervious(int id);
    }
}
