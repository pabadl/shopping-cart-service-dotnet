using Microsoft.EntityFrameworkCore;
using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.Services.PaymentMethods;
using ShoppingCart.Infrastructure.Mappers;
using ShoppingCart.Infrastructure.Persistence;

namespace ShoppingCart.Infrastructure.Services.PaymentMethods;

public class PaymentMethodDbServiceImpl : IPaymentMethodDbService
{
  private readonly ShoppingCartDbContext _dbContext;

  public PaymentMethodDbServiceImpl(ShoppingCartDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public IEnumerable<PaymentMethod> FindAll()
  {
    return _dbContext.PaymentMethods
        .AsNoTracking()
        .ToList()
        .Select(PaymentMethodEntityMapper.ToDomain);
  }
}
