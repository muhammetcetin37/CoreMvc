using Northwind.BL.Abstract;
using Northwind.Entities;

namespace Northwind.BL.Concrete
{
    public class CategoryManager : ManagerBase<Category>, ICategoryManager
    {
        public int AddWithName(string categoryName, string description)
        {
            if (categoryName == null)
                throw new Exception("Kategri Adi boş gecilemez.");
            if (categoryName.Length <= 3)
                throw new Exception("Bu kategori adi 3 den küçük olamaz.");
            var result = base.GetAll(p => p.CategoryName == categoryName);

            if (result != null)
            {
                throw new Exception("Bu kategori den daha önce tanimlanmistir.");
            }

            Category category = new Category();
            category.CategoryName = categoryName;
            category.Description = description;
            return base.Add(category);
        }
    }
}