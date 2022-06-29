using Northwind.Entities;

namespace Northwind.DAL.Abstract
{
    public interface ICategoryDal : IRepositoryBase<Category>
    {
        List<Product> GetProducts(string categoryName);

    }
}