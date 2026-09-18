using ShoppingCart.Domain.Entities;

namespace ShoppingCart.Domain.Services.PaymentMethods;

public class PaymentMethodDomainServiceImpl : IPaymentMethodDomainService
{
  private readonly IPaymentMethodDbService _paymentMethodDbService;

  public PaymentMethodDomainServiceImpl(IPaymentMethodDbService paymentMethodDbService)
  {
    _paymentMethodDbService = paymentMethodDbService;
  }

  public IEnumerable<PaymentMethod> GetPaymentMethods()
  {
    return _paymentMethodDbService.FindAll();
  }
}
