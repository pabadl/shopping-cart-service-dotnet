using ShoppingCart.Application.UseCases.Products;
using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Infrastructure.Persistence;
using ShoppingCart.Domain.Services.Products;
using ShoppingCart.Infrastructure.Services.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Registrar casos de uso (DI)
builder.Services.AddScoped<GetAllProductsUseCase>();
builder.Services.AddScoped<CreateProductUseCase>(); 

// Registrar servicios de dominio e infraestructura
builder.Services.AddScoped<IProductDomainService, ProductDomainServiceImpl>();
builder.Services.AddScoped<IProductDbService, ProductDbServiceImpl>();

// Registrar el DbContext con PostgreSQL
builder.Services.AddDbContext<ShoppingCartDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ShoppingCartDb"))
);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
