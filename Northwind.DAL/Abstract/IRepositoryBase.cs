﻿using System.Linq.Expressions;

namespace Northwind.DAL.Abstract
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        int Add(T input);
        int Update(T input);
        int Delete(T input);

        T Find(int Id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetInclude(Expression<Func<T, bool>> filter = null,
                            params Expression<Func<T, object>>[] include);
        IQueryable<T> GetAllInclude<T>(Expression<Func<T, bool>> filter, Expression<Func<T, object>>[] include) where T : class, new();
    }
}
