using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Television.Business.Abstract;

using Television.DataAccess.Abstract;
using Television.DataAccess.Concrete.Entity;
using Television.Entities.Concrete;
namespace Television.Business.Concrete
{
    public class postManager : IpostService
    {
        private IpostDal _postDal;

        public postManager(IpostDal postDal)
        {
            _postDal = postDal;
        }
        public void Add(post entity)
        {
            _postDal.Add(entity);
        }

        public void Delete(post entity)
        {
            _postDal.Delete(entity);
        }

        public post Get(Expression<Func<post, bool>> filter)
        {
            return _postDal.Get(filter);
        }
        public List<post> GetAll(Expression<Func<post, bool>> filter = null)
        {
            return _postDal.GetAll(filter);
        }

        public List<post> GetFilter(Expression<Func<post, bool>> filter)
        {
            return _postDal.GetFilter(filter);
        }

        public void Update(post entity)
        {
            _postDal.Update(entity);
        }
    }
}
