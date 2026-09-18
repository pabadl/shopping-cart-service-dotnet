using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Infrastructure.Entities;

[Table("payment_method")]
public class PaymentMethodEntity
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  [Column(TypeName = "numeric(5,2)")]
  public decimal Charge { get; set; }
}
