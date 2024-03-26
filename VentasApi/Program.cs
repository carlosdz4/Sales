using Microsoft.EntityFrameworkCore;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;
using Ventas.IOC.NegocioDependencies;
using Ventas.IOC.VentasDependencies;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SalesContex>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("VentasConectionDb")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IProductoDB, ProductoDB>();

builder.Services.AddNegocioDependecy();
builder.Services.AddVentasDependency();

//builder.Services.AddScoped<IVentaDB, VentaDB>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
