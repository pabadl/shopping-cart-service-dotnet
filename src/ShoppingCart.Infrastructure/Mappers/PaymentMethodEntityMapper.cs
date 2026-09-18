using ShoppingCart.Domain.Entities;
using ShoppingCart.Infrastructure.Entities;

namespace ShoppingCart.Infrastructure.Mappers;

public static class PaymentMethodEntityMapper
{
  public static PaymentMethod ToDomain(PaymentMethodEntity entity) =>
      new()
      {
        Id = entity.Id,
        Name = entity.Name,
        Charge = entity.Charge
      };

  public static PaymentMethodEntity ToEntity(PaymentMethod paymentMethod) =>
      new()
      {
        Id = paymentMethod.Id,
        Name = paymentMethod.Name,
        Charge = paymentMethod.Charge
      };
}
