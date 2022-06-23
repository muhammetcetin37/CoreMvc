using Northwind.Entities;

namespace Northwind.BL.Abstract
{
    public interface ICategoryManager : IManagerBase<Category>
    {
        int AddWithName(string categoryName, string description);
    }
}
