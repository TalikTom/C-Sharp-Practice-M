using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public abstract class Staff : IStaff
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
