using ShoppingCart.Domain.Entities;

namespace ShoppingCart.Domain.Services.Products;

public interface IProductDbService
{
  IEnumerable<Product> FindAll();
  Product Save(Product product);
}