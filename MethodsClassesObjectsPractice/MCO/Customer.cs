

namespace MCO;

public class Customer
{
    public Guid Id { get; set; }
    public int TableId { get; set; }

    public List<CustomerOrder> CustomerOrders { get; set; }

    public CustomerDetails CustomerDetails { get; set; }
}
