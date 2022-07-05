using System.ComponentModel.DataAnnotations;

namespace Core6Mvc.Models.DTO.Employees
{
    public class EmployeeCreateDto
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Ad alani Boş Geçilemez")]
        [StringLength(maximumLength: 50, ErrorMessage = "Ad Alani 50 karakterden büyük olamaz")]
        [MinLength(2, ErrorMessage = "Ad alani 2'den az olamaz")]
        public string? FirstName { get; set; }


        [Required(ErrorMessage = "Soyad alani Boş Geçilemez")]
        [StringLength(50, ErrorMessage = "Soyad Alani 50 karakterden büyük olamaz")]
        [MinLength(2, ErrorMessage = "Soyad alani 2'den az olamaz")]
        public string? LastName { get; set; }
        public string? Title { get; set; }

        [Required]
        public DateTime? HireDate { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? HomePhone { get; set; }
    }
}