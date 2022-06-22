using System.ComponentModel.DataAnnotations;

namespace Core6Mvc.Models.DTO.Employees
{
    public class EmployeeUpdateDto
    {

        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Ad Alani  Boş Geçilemez.")]
        [StringLength(50, ErrorMessage = "Ad Alani 50 Karakterden Büyük Olamaz.")]
        [MinLength(2, ErrorMessage = "Ad Alani 2 den az olamaz.")]
        public string? LastName { get; set; } = null!;

        [Required(ErrorMessage = "Soyad Alani  Boş Geçilemez.")]
        [StringLength(50, ErrorMessage = "Soyad Alani 50 Karakterden Büyük Olamaz.")]
        [MinLength(2, ErrorMessage = "Ad Alani 2 den az olamaz.")]
        public string? FirstName { get; set; } = null!;
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }

        [Required(ErrorMessage = "Dogum Tarihi Boş Geçilemez")]
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? HomePhone { get; set; }
        public string? Extension { get; set; }
        public byte[]? Photo { get; set; }
        public string? Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string? PhotoPath { get; set; }
    }
}
