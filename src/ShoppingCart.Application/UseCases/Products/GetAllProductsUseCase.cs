using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.Services.Products;

namespace ShoppingCart.Application.UseCases.Products;

public class GetAllProductsUseCase
{
  private readonly IProductDomainService _productDomainService;

  public GetAllProductsUseCase(IProductDomainService productDomainService)
  {
    _productDomainService = productDomainService;
  }

  public IEnumerable<Product> Execute()
  {
    return _productDomainService.GetProducts();
  }
}