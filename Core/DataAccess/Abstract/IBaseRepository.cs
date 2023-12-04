﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity, new() 
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T,bool>> predicate);
        IEnumerable<T> GetAll(Expression<Func<T,bool>> predicate=null);

    }
}
