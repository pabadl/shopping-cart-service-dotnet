using ShoppingCart.Domain.Entities;
using ShoppingCart.Infrastructure.Entities;

namespace ShoppingCart.Infrastructure.Mappers;

public static class ProductEntityMapper
{
  public static Product ToDomain(ProductEntity entity) =>
      new(entity.Id, entity.Name, entity.Description, entity.Price);

  public static ProductEntity ToEntity(Product product) =>
      new()
      {
        Id = product.Id,
        Name = product.Name,
        Description = product.Description,
        Price = product.Price
      };
}