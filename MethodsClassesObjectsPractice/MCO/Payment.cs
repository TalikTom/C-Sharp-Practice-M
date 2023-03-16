namespace MCO
{
    public class Payment
    {
        public Guid Id { get; set; }
        public DateTime PaymentTime { get; set; }
        public decimal PaymentAmount { get; set; }

        public Guid CustomerOrderId { get; set; }

        public CustomerOrder CustomerOrder { get; set; }
    }
}
