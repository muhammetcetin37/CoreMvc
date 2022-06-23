using Northwind.BL.Abstract;
using Northwind.Entities;

namespace Northwind.BL.Concrete
{
    public class ProductManager : ManagerBase<Product>, IProductManager
    {
    }
}
