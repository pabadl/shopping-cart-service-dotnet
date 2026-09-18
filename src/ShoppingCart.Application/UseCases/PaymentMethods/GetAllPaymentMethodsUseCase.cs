using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.Services.PaymentMethods;

namespace ShoppingCart.Application.UseCases.PaymentMethods;

public class GetAllPaymentMethodsUseCase
{
  private readonly IPaymentMethodDomainService _paymentMethodDomainService;

  public GetAllPaymentMethodsUseCase(IPaymentMethodDomainService paymentMethodDomainService)
  {
    _paymentMethodDomainService = paymentMethodDomainService;
  }

  public IEnumerable<PaymentMethod> Execute()
  {
    return _paymentMethodDomainService.GetPaymentMethods();
  }
}
