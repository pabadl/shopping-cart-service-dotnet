using ShoppingCart.Domain.Entities;
using ShoppingCart.InterfaceAdapters.Dtos;

namespace ShoppingCart.InterfaceAdapters.Mappers;

public static class ProductMapper
{
  // Domain -> DTO (para responder por HTTP)
  public static ProductDto ToDto(Product product) =>
      new()
      {
        Id = product.Id,
        Name = product.Name,
        Description = product.Description,
        Price = product.Price
      };

  // DTO -> Domain (para procesar lo que entra por HTTP)
  public static Product ToDomain(ProductDto dto) =>
      new(dto.Id, dto.Name, dto.Description, dto.Price);
}
