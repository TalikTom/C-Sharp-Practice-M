using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public class Waiter : Staff
    {
        public bool Bartender { get; set; }

        public double Salary { get; set; }

        public List<CustomerOrder> CustomerOrders { get; set; } 

        // By default set Bartender property to false, when instancing the object without parametres
        public Waiter ()
        {
            Bartender = false;
        }


        // Overloaded constructors
        public Waiter(bool bartender, double salary )
        {
            Bartender = true;
            Salary = salary;
        }
    }
}
