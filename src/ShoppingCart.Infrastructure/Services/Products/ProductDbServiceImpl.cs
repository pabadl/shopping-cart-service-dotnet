using Microsoft.EntityFrameworkCore;
using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.Services.Products;
using ShoppingCart.Infrastructure.Mappers;
using ShoppingCart.Infrastructure.Persistence;

namespace ShoppingCart.Infrastructure.Services.Products;

public class ProductDbServiceImpl : IProductDbService
{
  private readonly ShoppingCartDbContext _dbContext;

  public ProductDbServiceImpl(ShoppingCartDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public IEnumerable<Product> FindAll()
  {
    return _dbContext.Products
        .AsNoTracking()
        .ToList()
        .Select(ProductEntityMapper.ToDomain);
  }

  public Product Save(Product product)
  {
    var entity = ProductEntityMapper.ToEntity(product);
    _dbContext.Products.Add(entity);
    _dbContext.SaveChanges();

    return ProductEntityMapper.ToDomain(entity);
  }
}