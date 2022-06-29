namespace Core6Mvc.Models.DTO.Employees
{
    public class EmployeeListDto
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public DateTime? HireDate { get; set; }
        public string? Title { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? HomePhone { get; set; }

        public byte[] Photo { get; set; }

    }
}