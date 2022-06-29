namespace Core6Mvc.Models.DTO.Products
{
    public class ProductListDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; }
    }
}