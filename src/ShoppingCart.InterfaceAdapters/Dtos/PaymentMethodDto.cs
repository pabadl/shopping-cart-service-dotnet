namespace ShoppingCart.InterfaceAdapters.Dtos;

public class PaymentMethodDto
{
  public long Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public decimal Charge { get; set; }
}
