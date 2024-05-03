using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public List<ContactUS> GetList()
        {
            return _contactUsDal.GetList();
        }

        public void TAdd(ContactUS t)
        {
            throw new NotImplementedException();
        }

        public void TContactUsStatusUsChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUS t)
        {
            throw new NotImplementedException();
        }

        public ContactUS TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUS> TGetListcontactUsByFalse()
        {
            return _contactUsDal.GetListcontactUsByFalse();
        }

        public List<ContactUS> TGetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public void TUpdate(ContactUS t)
        {
            throw new NotImplementedException();
        }
    }
}
