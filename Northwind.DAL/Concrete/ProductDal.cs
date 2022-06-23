using Northwind.DAL.Abstract;
using Northwind.Entities;

namespace Northwind.DAL.Concrete
{
    public class ProductDal : RepositoryBase<Product>, IProductDal
    {
    }
}
