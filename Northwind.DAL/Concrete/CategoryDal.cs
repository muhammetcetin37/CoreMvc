using Northwind.DAL.Abstract;
using Northwind.Entities;

namespace Northwind.DAL.Concrete
{
    public class CategoryDal : RepositoryBase<Category>, ICategoryDal
    {
        public List<Product> GetProducts(string categoryName)
        {
            var category = base.GetAll(p => p.CategoryName == categoryName)
                .FirstOrDefault();

            var query = from p in base.db.Products
                        where p.CategoryId == category.CategoryId
                        select p;

            return query.ToList();
        }
    }
}
