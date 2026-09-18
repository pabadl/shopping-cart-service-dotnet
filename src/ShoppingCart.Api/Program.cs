using ShoppingCart.Application.UseCases.Products;
using ShoppingCart.Application.UseCases.PaymentMethods;
using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Infrastructure.Persistence;
using ShoppingCart.Domain.Services.Products;
using ShoppingCart.Domain.Services.PaymentMethods;
using ShoppingCart.Infrastructure.Services.Products;
using ShoppingCart.Infrastructure.Services.PaymentMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Registrar casos de uso (DI)
builder.Services.AddScoped<GetAllProductsUseCase>();
builder.Services.AddScoped<CreateProductUseCase>(); 

// Registrar servicios de dominio e infraestructura - Product
builder.Services.AddScoped<IProductDomainService, ProductDomainServiceImpl>();
builder.Services.AddScoped<IProductDbService, ProductDbServiceImpl>();

// Registrar casos de uso - PaymentMethod
builder.Services.AddScoped<GetAllPaymentMethodsUseCase>();

// Registrar servicios de dominio e infraestructura - PaymentMethod
builder.Services.AddScoped<IPaymentMethodDomainService, PaymentMethodDomainServiceImpl>();
builder.Services.AddScoped<IPaymentMethodDbService, PaymentMethodDbServiceImpl>();

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
