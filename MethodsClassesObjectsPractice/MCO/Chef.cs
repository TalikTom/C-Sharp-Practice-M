using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public class Chef : Staff
    {       
        public Guid Id { get; set; }
        public List<CustomerOrder> CustomerOrders { get; set; }
        public bool Certified { get; set; }
    }
}
