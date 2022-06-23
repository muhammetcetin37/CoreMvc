using Northwind.BL.Abstract;
using Northwind.Entities;

namespace Northwind.BL.Concrete
{
    public class CategoryManager : ManagerBase<Category>, ICategoryManager
    {
        public int AddWithName(string categoryName, string description)
        {
            if (categoryName == null)
            {
                throw new Exception("Kategory adi boş geçilemez");
            }
            if (categoryName.Length <= 3)
            {
                throw new Exception("bu kategory adi 3 den kucuk olamaz");
            }
            var result = base.GetAll(p => p.CategoryName == categoryName);
            if (result != null)
            {
                throw new Exception("bu kategory den daha önce tanımlanmıştır");
            }
            Category category = new Category();
            category.CategoryName = categoryName;
            category.Description = description;

            return base.Add(category);
        }
    }
}
