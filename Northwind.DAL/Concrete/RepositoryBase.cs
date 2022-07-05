using Microsoft.EntityFrameworkCore;
using Northwind.DAL.Abstract;
using Northwind.Entities;
using System.Linq.Expressions;

namespace Northwind.DAL.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        protected NorthwindContext db;
        public RepositoryBase()
        {
            db = new NorthwindContext();
        }


        public virtual int Add(T input)
        {
            db.Set<T>().Add(input);
            return db.SaveChanges();
        }
        public virtual int Update(T input)
        {
            db.Set<T>().Update(input);
            return db.SaveChanges();
        }
        public virtual int Delete(T input)
        {
            db.Set<T>().Remove(input);
            return db.SaveChanges();
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<T>().ToList();
            }
            else
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {

            var query = db.Set<T>().Where(filter);


            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public virtual T Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}