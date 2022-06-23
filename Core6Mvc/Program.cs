using Core6Mvc.AutoMapper;
using Microsoft.EntityFrameworkCore;
using Northwind.BL.Abstract;
using Northwind.BL.Concrete;
using Northwind.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer("Server=.;Database=NorthWind;User Id=sa;Password=123"));
builder.Services.AddAutoMapper(typeof(NorthwindProfile));

builder.Services.AddScoped<ICategoryManager, CategoryManager>();
builder.Services.AddScoped<IProductManager, ProductManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();