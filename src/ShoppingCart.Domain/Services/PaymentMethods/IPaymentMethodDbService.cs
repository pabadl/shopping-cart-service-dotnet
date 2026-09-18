using ShoppingCart.Domain.Entities;

namespace ShoppingCart.Domain.Services.PaymentMethods;

public interface IPaymentMethodDbService
{
  IEnumerable<PaymentMethod> FindAll();
}
