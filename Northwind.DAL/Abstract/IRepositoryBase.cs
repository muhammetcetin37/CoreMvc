using System.Linq.Expressions;

namespace Northwind.DAL.Abstract
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        int Add(T input);
        int Update(T input);
        int Delete(T input);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> GetInclude(Expression<Func<T, bool>> filter = null,
                           params Expression<Func<T, object>>[] include);
    }
}
