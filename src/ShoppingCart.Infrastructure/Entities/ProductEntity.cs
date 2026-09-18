using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Infrastructure.Entities;

[Table("product")]
public class ProductEntity
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public string? Description { get; set; }

  public long Price { get; set; }
}
