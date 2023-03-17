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
} while (moreGuestsComing.ToLower() ! = "yes");

Console.ReadLine();