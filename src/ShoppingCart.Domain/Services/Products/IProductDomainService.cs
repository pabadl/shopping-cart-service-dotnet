using ShoppingCart.Domain.Entities;

namespace ShoppingCart.Domain.Services.Products;

public interface IProductDomainService
{
  IEnumerable<Product> GetProducts();
  
  Product CreateProduct(Product product);
}