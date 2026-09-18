using ShoppingCart.Domain.Entities;
using ShoppingCart.InterfaceAdapters.Dtos;

namespace ShoppingCart.InterfaceAdapters.Mappers;

public static class PaymentMethodMapper
{
  public static PaymentMethodDto ToDto(PaymentMethod paymentMethod) =>
      new()
      {
        Id = paymentMethod.Id,
        Name = paymentMethod.Name,
        Charge = paymentMethod.Charge
      };

  public static PaymentMethod ToDomain(PaymentMethodDto dto) =>
      new()
      {
        Id = dto.Id,
        Name = dto.Name,
        Charge = dto.Charge
      };
}
