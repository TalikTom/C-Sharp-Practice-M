using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public class MenuItem
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Menu Menu { get; set; }

        public Guid MenuId { get; set; }

        public OrderItem OrderItem { get; set; }

        public Guid OrderItemId { get; set; }





        
    }
}
