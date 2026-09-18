using ShoppingCart.Domain.Entities;

namespace ShoppingCart.Domain.Services.Products;

public class ProductDomainServiceImpl : IProductDomainService
{
  private readonly IProductDbService _productDbService;

  public ProductDomainServiceImpl(IProductDbService productDbService)
  {
    _productDbService = productDbService;
  }

  public IEnumerable<Product> GetProducts()
  {
    return _productDbService.FindAll();
  }

  public Product CreateProduct(Product product)
  {
    return _productDbService.Save(product);
  }
}