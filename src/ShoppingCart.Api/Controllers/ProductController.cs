using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.UseCases.Products;
using ShoppingCart.Domain.Entities;
using ShoppingCart.InterfaceAdapters.Dtos;
using ShoppingCart.InterfaceAdapters.Mappers;

namespace ShoppingCart.Api.Controllers;

[ApiController]
[Route("api/v1/products")]
public class ProductController : ControllerBase
{
  private readonly GetAllProductsUseCase _getAllProductsUseCase;
  private readonly CreateProductUseCase _createProductUseCase;

  public ProductController(
    GetAllProductsUseCase getAllProductsUseCase,
    CreateProductUseCase createProductUseCase
  ){
    _getAllProductsUseCase = getAllProductsUseCase;
    _createProductUseCase = createProductUseCase;
  }

  [HttpGet]
  public IEnumerable<ProductDto> GetAllProducts()
  {
    return _getAllProductsUseCase.Execute()
        .Select(ProductMapper.ToDto);
  }

  [HttpPost]
  public ProductDto CreateProduct([FromBody] ProductDto productDto)
  {
    Product product = ProductMapper.ToDomain(productDto);
    return ProductMapper.ToDto(_createProductUseCase.Execute(product));
  }
}