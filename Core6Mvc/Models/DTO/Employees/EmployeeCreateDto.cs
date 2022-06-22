using System.ComponentModel.DataAnnotations;

namespace Core6Mvc.Models.DTO.Employees
{
    public class EmployeeCreateDto
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Ad Alani  Boş Geçilemez.")]
        [StringLength(50, ErrorMessage = "Ad Alani 50 Karakterden Büyük Olamaz.")]
        [MinLength(2, ErrorMessage = "Ad Alani 2 den az olamaz.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Soyad Alani  Boş Geçilemez.")]
        [StringLength(50, ErrorMessage = "Soyad Alani 50 Karakterden Büyük Olamaz.")]
        [MinLength(2, ErrorMessage = "Ad Alani 2 den az olamaz.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Tarih Alani Zorunludur.")]
        public DateTime? HireDate { get; set; }
        public string? Title { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? HomePhone { get; set; }
    }
}
