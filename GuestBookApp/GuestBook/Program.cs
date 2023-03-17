using GuestBookLibrary.Model;

// Capture the information about each guest (assumption is at least one guest and unknow maximum)
// Info to capture: first name, last name, message to the host
// Once done, loop through each guest and print their info

namespace GuestBook // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {
            
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }


        private static void PrintGuestInformation()
        {

            //loop through the list of guests
            foreach (GuestModel guest in guests)
            {
                Console.Write(guest.GuestInfo);
            }
        }

        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                Console.Write("What is your first name: ");

                guest.FirstName = Console.ReadLine();

                Console.Write("What is your last name: ");

                guest.LastName = Console.ReadLine();

                Console.WriteLine("What message would you like to tell your host: ");
                guest.MessageToHost = Console.ReadLine();

                Console.Write("Are more guests coming (yes/no)?");
                moreGuestsComing = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
        }
    }
}




