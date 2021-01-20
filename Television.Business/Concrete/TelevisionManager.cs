using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Television.Business.Abstract;

using Television.DataAccess.Abstract;
using Television.Entities.Concrete;
namespace Television.Business.Concrete
{
    public class TelevisionManager : ITelevisionService
    {
        private ITelevisionDal _televisionDal;

        public TelevisionManager(ITelevisionDal televisionDal)
        {
            _televisionDal = televisionDal;
        }

        public void Add(Entities.Concrete.Television entity)
        {
            _televisionDal.Add(entity);
        }

        public void Delete(Entities.Concrete.Television entity)
        {
            _televisionDal.Delete(entity);
        }

        public Entities.Concrete.Television Get(Expression<Func<Entities.Concrete.Television, bool>> filter)
        {
            return _televisionDal.Get(filter);
        }

        public List<Entities.Concrete.Television> GetAll(Expression<Func<Entities.Concrete.Television, bool>> filter = null)
        {
            return _televisionDal.GetAll(filter);
        }

        public List<Entities.Concrete.Television> GetFilter(Expression<Func<Entities.Concrete.Television, bool>> filter)
        {
            return _televisionDal.GetFilter(filter);
        }

        public void Update(Entities.Concrete.Television entity)
        {
            _televisionDal.Update(entity);
        }
    }
}
