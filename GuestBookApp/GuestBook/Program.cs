// See https://aka.ms/new-console-template for more information

using GuestBookLibrary.Model;


// Capture the information about each guest (assumption is at least one guest and unknow maximum)
// Info to capture: first name, last name, message to the host
// Once done, loop through each guest and print their info



List<GuestModel> guests = new List<GuestModel>();

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

foreach (GuestModel guest in guests)
{
    Console.Write(guest.GuestInfo);
}

Console.ReadLine();