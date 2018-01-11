﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace BookRentRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> All();

        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate, string includeProperties = "");

        T Find(params object[] keys);
        T Find(Expression<Func<T, bool>> predicate);
        T Find(Expression<Func<T, bool>> predicate, string includeProperties = "");

        T Create(T t);
        void Update(T t);

        void Delete(object id);
        void Delete(T t);
        void Save();
        int Count();

        DbContext DbContext { get;}
    }
}
