// See https://aka.ms/new-console-template for more information
using MCO;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstName = UserInput.GetAString("Enter your first name.");

            UserMessages.ApplicationStartMessage(firstName);

            //MainMenu();


            Waiter igor = new Waiter();

          
            igor.FirstName = "Igor";
            igor.LastName = "Igoric";
            igor.bartender = true;
            igor.StartDate = new DateTime(2022, 05, 09, 9, 0, 0);

            Console.WriteLine(igor.StartDate);


            Waiter misko = new Waiter();


            misko.FirstName = "Misko";
            misko.LastName = "Miskic";
            misko.bartender = false;
            misko.StartDate = new DateTime(2021, 01, 01, 9, 0, 0);

            Console.WriteLine(misko.StartDate);


            Chef alemka = new Chef();

            alemka.FirstName = "Alemka";
            alemka.LastName = "Alemkic";
            alemka.certified = true;
            alemka.StartDate = new DateTime(2021);


            Chef sasha = new Chef();

            sasha.FirstName = "Sasha";
            sasha.LastName = "Alemkic";
            sasha.certified = true;
            sasha.StartDate = new DateTime(2020, 5,5);


            /* ---------------------------------- */

            /* Practicing lists */

            /* ---------------------------------- */


            Console.WriteLine("-----------------------");


            List<Waiter> waiters = new List<Waiter>();


            Waiter person = new Waiter();

            person.FirstName = "Miroslav";
            waiters.Add(person);

            person = new Waiter();

            person.FirstName = "Antimon";
            waiters.Add(person);


            foreach (Waiter w in waiters)
            {
                Console.WriteLine(w.FirstName);
            }


            Console.WriteLine("-----------------------");




            //    HelloWorld();
            //    string message = Console.ReadLine();

            //    Reverse(message);
            //}

            //private static void HelloWorld()
            //{
            //    Console.WriteLine("Hello World");
            //}

            //private static void Reverse(string message)
            //{

            //    char[] messageArray = message.ToCharArray();
            //    Array.Reverse(messageArray);

            //    foreach (char item in messageArray)
            //    {
            //        Console.Write(item);
            //    }
        }
        //static void MainMenu()
        //{
        //    Console.Write("\nOptions" +
        //        ":\n");
        //    Console.Write("1: Waiters\n2: Chefs\n");

        //    int input;

        //    Console.Write("\nInput your choice: ");
        //    while (!int.TryParse(Console.ReadLine(), out input))
        //    {
        //        Console.WriteLine("Invalid input! Please enter a valid number.\n");
        //    }

        //    switch (input)
        //    {
        //        case 1:
        //            Console.WriteLine("Waiters");
        //            break;

        //        case 2:
        //            DisplayChefs();
        //            break;

        //        case 3:
        //            Console.WriteLine("----------------------------------------------------------- \n");
        //            Console.Write("Goodbye\n");

        //            break;

        //        default:
        //            Console.Clear();
        //            Console.Write("Not, fair... Input correct option between 1 and 3\n");
        //            MainMenu();
        //            break;


        //    }
        //}

        //static void DisplayChefs()
        //{



        //    Console.ReadLine();
        //    Console.Clear();
        //    MainMenu();
        //}

    }
}
