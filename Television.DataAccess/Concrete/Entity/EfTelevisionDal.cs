using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Television.DataAccess.Abstract;

namespace Television.DataAccess.Concrete.Entity
{
    public class EfTelevisionDal : EfRepositoryBase<Entities.Concrete.Television, TelevisionContext>, ITelevisionDal
    {
       
    }
}
