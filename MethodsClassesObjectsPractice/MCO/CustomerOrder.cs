namespace MCO;

public class CustomerOrder
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ChefId { get; set; }
    public Guid WaiterId { get; set; }
    public List<CustomerOrderItem> CustomerOrderItems { get; set; }
    public Chef Chef { get; set; }
    public Waiter Waiter { get; set; }
    public Customer Customer { get; set; }

}
