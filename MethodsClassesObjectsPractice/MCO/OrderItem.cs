

namespace MCO;

public class OrderItem
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public List<CustomerOrderItem> CustomerOrderItems { get; set; }
    public List<MenuItem> MenuItems { get; set; }
}
