using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.WriteLine($"Welcome {firstName}");


            //check current hour and display a message accordingly

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            }
        }

    }
}
