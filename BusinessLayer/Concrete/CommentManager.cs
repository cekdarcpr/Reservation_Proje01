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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetList();
        }

        public List<Comment> TGetDastinationById(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationID == id);
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetCommentDestination()
        {
            return _commentDal.GetCommentDestination();
        }

        public List<Comment> TGetCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetCommentWithDestinationAndUser(id);
        }
    }
}
