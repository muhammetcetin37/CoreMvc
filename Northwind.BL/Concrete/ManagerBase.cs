using Northwind.BL.Abstract;
using Northwind.DAL.Abstract;
using Northwind.DAL.Concrete;
using System.Linq.Expressions;

namespace Northwind.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : class, new()
    {
        protected IRepositoryBase<T> repository;

        public ManagerBase()
        {
            repository = new RepositoryBase<T>();
        }
        public int Add(T input)
        {
            return repository.Add(input);
        }

        public int Delete(T input)
        {
            return repository.Delete(input);
        }

        public T Find(int id)
        {
            return repository.Find(id);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            return repository.GetAllInclude(filter, include);
        }

        public int Update(T input)
        {
            return repository.Update(input);
        }
    }
}