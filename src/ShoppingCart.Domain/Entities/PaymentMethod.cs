namespace ShoppingCart.Domain.Entities;

public class PaymentMethod {
  public long Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public decimal Charge { get; set; }
}