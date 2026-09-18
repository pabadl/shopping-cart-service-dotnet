using Microsoft.EntityFrameworkCore;
using ShoppingCart.Infrastructure.Entities;

namespace ShoppingCart.Infrastructure.Persistence;

public class ShoppingCartDbContext : DbContext
{
  public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) : base(options){}

  public DbSet<ProductEntity> Products => Set<ProductEntity>();
}