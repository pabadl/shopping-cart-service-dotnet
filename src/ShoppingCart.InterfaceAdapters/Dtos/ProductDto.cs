using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.InterfaceAdapters.Dtos;

public class ProductDto
{
  public long Id { get; set; }

  [Required(ErrorMessage = "Product name cannot be empty")]
  [StringLength(20, MinimumLength = 3, ErrorMessage = "Product name between 3 and 20 characters")]
  public string Name { get; set; } = string.Empty;

  public string? Description { get; set; }

  [Required(ErrorMessage = "Product price cannot be null")]
  public long Price { get; set; }
}