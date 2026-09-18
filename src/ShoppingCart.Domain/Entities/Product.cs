using ShoppingCart.Domain.Exceptions;

namespace ShoppingCart.Domain.Entities;

public class Product
{
  public long Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string? Description { get; set; }
  public long Price { get; set; }

  public Product(long id, string name, string? description, long price)
  {
    if (string.IsNullOrWhiteSpace(name) || name.Length is < 3 or > 20)
      throw new DomainValidationException("Product name must be between 3 and 20 characters");

    if (price <= 0)
      throw new DomainValidationException("Product price must be greater than zero");

    Id = id;
    Name = name;
    Description = description;
    Price = price;
  }
}