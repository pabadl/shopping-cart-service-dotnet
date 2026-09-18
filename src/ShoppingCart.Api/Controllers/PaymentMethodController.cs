using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.UseCases.PaymentMethods;
using ShoppingCart.InterfaceAdapters.Dtos;
using ShoppingCart.InterfaceAdapters.Mappers;

namespace ShoppingCart.Api.Controllers;

[ApiController]
[Route("api/v1/payment-methods")]
public class PaymentMethodController : ControllerBase
{
  private readonly GetAllPaymentMethodsUseCase _getAllPaymentMethodsUseCase;

  public PaymentMethodController(GetAllPaymentMethodsUseCase getAllPaymentMethodsUseCase)
  {
    _getAllPaymentMethodsUseCase = getAllPaymentMethodsUseCase;
  }

  [HttpGet]
  public IEnumerable<PaymentMethodDto> GetAllPaymentMethods()
  {
    return _getAllPaymentMethodsUseCase.Execute()
        .Select(PaymentMethodMapper.ToDto);
  }
}
