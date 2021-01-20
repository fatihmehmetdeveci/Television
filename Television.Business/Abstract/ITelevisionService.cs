using System;
using System.Collections.Generic;
using System.Text;

namespace Television.Business.Abstract
{
    public interface ITelevisionService : IServiceRepository<Entities.Concrete.Television>
    {
    }
}
