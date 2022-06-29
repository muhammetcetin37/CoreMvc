namespace Core6Mvc.Models.DTO.Product
{
    public class ProductCreateDTO
    {
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitePrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
