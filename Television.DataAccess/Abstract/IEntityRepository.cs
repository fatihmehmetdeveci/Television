﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Television.Entities.Abstract;

namespace Television.DataAccess.Abstract
{
    public interface IEntityRepository<T>
         where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> GetFilter(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
