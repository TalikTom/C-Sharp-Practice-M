

namespace MCO;

public class CustomerOrderItem
{
    public Guid Id { get; set; }

    public CustomerOrder CustomerOrder { get; set; }
    public Guid CustomerOrderId { get; set; }
    public OrderItem OrderItem { get; set; }
    public Guid OrderItemId { get; set; }
}
