using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public class UserInput
    {
        public static string GetAString(string message )
        {
            Console.WriteLine( message );
            string input = Console.ReadLine();
            return input;
        }
    }
}
