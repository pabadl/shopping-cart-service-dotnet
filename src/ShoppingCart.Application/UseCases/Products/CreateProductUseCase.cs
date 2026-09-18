using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.Services.Products;

namespace ShoppingCart.Application.UseCases.Products;

public class CreateProductUseCase {
  private readonly IProductDomainService _productDomainService;

  public CreateProductUseCase(IProductDomainService productDomainService)
  {
    _productDomainService = productDomainService;
  }

  public Product Execute(Product product){
    return _productDomainService.CreateProduct(product);
  }
}