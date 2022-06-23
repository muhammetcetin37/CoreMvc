using Northwind.DAL.Abstract;
using Northwind.Entities;

namespace Northwind.DAL.Concrete
{
    internal class ProductDal : RepositoryBase<Product>, IProductDal
    {
    }
}
