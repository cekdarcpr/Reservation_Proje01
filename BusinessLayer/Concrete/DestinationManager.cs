﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManger : IDestinationService
    {
        IDestinaitonDal _destinaitonDal;

        public DestinationManger(IDestinaitonDal destinaitonDal)
        {
            _destinaitonDal = destinaitonDal;
        }

        public List<Destination> GetList()
        {
            return _destinaitonDal.GetList();
        }

        public void TAdd(Destination t)
        {
            _destinaitonDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinaitonDal.Delete(t);
        }

        public Destination TGetByID(int id)
        {
            return _destinaitonDal.GetByID(id);
        }

        public void TUpdate(Destination t)
        {
            _destinaitonDal.Update(t);
        }
    }
}
