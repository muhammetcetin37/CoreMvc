using AutoMapper;
using Core6Mvc.Models.DTO.Employees;
using Core6Mvc.Models.DTO.Products;
using Northwind.Entities;

namespace Core6Mvc.AutoMapper
{
    public class NorthwindProfile : Profile
    {

        public NorthwindProfile()
        {
            //ListDto icin gerekli cevirim
            CreateMap<Employee, EmployeeListDto>();

            //Create icin gerekli cevirim
            CreateMap<EmployeeCreateDto, Employee>();

            //EmployeeUpdateDto icin Gerekli cevirim
            CreateMap<Employee, EmployeeUpdateDto>();
            CreateMap<EmployeeUpdateDto, Employee>();


            //Product ile iligili cevirim tanimlamasi yapiyoruz
            //ProductListDto icerisindeki CategoryName alanina 
            // kaynak listedeki category'nin ismi eşleştirilecek

            //Ayni durum Supplier icerisindeki companyName icinde geçerlidir
            CreateMap<Product, ProductListDTO>()
                .ForMember(p => p.CategoryName, src => src.MapFrom(p => p.Category.CategoryName))
                .ForMember(p => p.CompanyName, src => src.MapFrom(p => p.Supplier.CompanyName));






        }
    }
}