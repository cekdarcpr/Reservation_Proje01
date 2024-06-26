﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUS>, IContactUsDal
    {
        public void ContactUsStatusUsChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUS> GetListcontactUsByFalse()
        {
            using(var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }

        public List<ContactUS> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }
    }
}
