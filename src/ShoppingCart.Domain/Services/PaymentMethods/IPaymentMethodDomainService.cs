using ShoppingCart.Domain.Entities;

namespace ShoppingCart.Domain.Services.PaymentMethods;

public interface IPaymentMethodDomainService
{
  IEnumerable<PaymentMethod> GetPaymentMethods();
}
