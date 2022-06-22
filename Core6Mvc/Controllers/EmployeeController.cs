using Core6Mvc.Models.DTO.Employees;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entities;

namespace Core6Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly NorthwindContext context;
        public EmployeeController(NorthwindContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            //ekranda görünecek modelimizi oluşturuyoruz
            List<EmployeeListDto> listDtos = new List<EmployeeListDto>();

            //datebase den calısanları çekiyoruz
            var EmployeeList = context.Employees.ToList();

            //database den gelen verileri listDto ya teker teker ekliyoruz
            foreach (var employee in EmployeeList)
            {
                EmployeeListDto listDto = new();
                listDto.Id = employee.EmployeeId;
                listDto.FirstName = employee.FirstName;
                listDto.LastName = employee.LastName;
                listDto.HireDate = employee.HireDate;
                listDto.Country = employee.Country;
                listDto.City = employee.City;
                listDto.HomePhone = employee.HomePhone;

                //listeye ekliyoruz
                listDtos.Add(listDto);

            }

            return View(listDtos);
        }
    }
}
