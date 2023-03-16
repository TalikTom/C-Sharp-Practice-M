// See https://aka.ms/new-console-template for more information
using MCO;
using System;
using System.Net.NetworkInformation;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstName = UserInput.GetAString("Enter your first name.");

            UserMessages.ApplicationStartMessage(firstName);

            Console.WriteLine("\n");

            //MainMenu();


            Waiter igor = new Waiter();

          
            igor.FirstName = "Igor";
            igor.LastName = "Igoric";
            igor.Bartender = true;
            igor.StartDate = new DateTime(2022, 05, 09, 9, 0, 0);


            Console.WriteLine("Listing waiters info: \n");
            Console.WriteLine($"Waiters name: {igor.FirstName} {igor.LastName}");
            Console.WriteLine($"{igor.FirstName} is {(igor.Bartender ? "a bartender" : "not a bartender")}");
            Console.WriteLine($"{igor.FirstName} start date is {igor.StartDate}");

            Console.WriteLine("------------------\n");

            Waiter misko = new Waiter();


            misko.FirstName = "Misko";
            misko.LastName = "Miskic";
            misko.Bartender = false;
            misko.StartDate = new DateTime(2021, 01, 01, 9, 0, 0);

            Console.WriteLine($"Waiters name: {misko.FirstName} {misko.LastName}");
            Console.WriteLine($"{misko.FirstName} is {(misko.Bartender ? "a bartender" : "not a bartender")}");
            Console.WriteLine($"{misko.FirstName} start date is {misko.StartDate}");


            Chef alemka = new Chef();

            alemka.FirstName = "Alemka";
            alemka.LastName = "Alemkic";
            alemka.Certified = true;
            alemka.StartDate = new DateTime(2021);


            Chef sasha = new Chef();

            sasha.FirstName = "Sasha";
            sasha.LastName = "Alemkic";
            sasha.Certified = true;
            sasha.StartDate = new DateTime(2020, 5,5);


            /* ---------------------------------- */

            /* Practicing lists */

            /* ---------------------------------- */


            Console.WriteLine("-----------------------");
            Console.WriteLine("Listing waiters first name from the list 'waiter': ");
            


            List<Waiter> waiters = new List<Waiter>();


            Waiter staffPerson = new Waiter();

            staffPerson.FirstName = "Miroslav";
            waiters.Add(staffPerson);
            waiters.Add(igor);
            waiters.Add(misko);

            staffPerson = new Waiter();

            staffPerson.FirstName = "Antimon";
            waiters.Add(staffPerson);


            foreach (Waiter w in waiters)
            {
                Console.WriteLine(w.FirstName);
            }


            Console.WriteLine("-----------------------");


            Console.WriteLine("Enter New Chefs");
            Console.WriteLine("-----------------------");



            List<Chef> chefs = new List<Chef>();
            string lastName = "";


            do
            {
                Console.Write("What is the last name of a chef (type exit to stop)");
                lastName = Console.ReadLine();

                if (lastName.ToLower() != "exit")
                {
                    Chef staffChef = new Chef();
                    staffChef.LastName = lastName;
                    chefs.Add(staffChef);
                }

            } while (lastName.ToLower() != "exit");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Listing chefs you entered: ");

            foreach (Chef c in chefs)
            {
                Console.WriteLine(c.LastName);
            }


            /* constructor */


            Waiter luciano = new Waiter();


            Console.WriteLine($"Luciano is {(luciano.Bartender ? "a bartender" : "not a bartender")}");


            Waiter kreshimir = new Waiter(true, 3000.22);

            Console.WriteLine($"Kresho is {(kreshimir.Bartender ? "a bartender" : "not a bartender")}. His salary is {kreshimir.Salary}kn");


            // passing parameters by value

            static void addOne(int i)
            {
                i = i + 1;
                Console.WriteLine("i is : " + i);
            }

           
            int test = 20;
            addOne(test);
            Console.WriteLine("test is : " + test);

            /* i is : 21
            test is : 20 */



            // passing parameters by reference

            static void addOneToRefParam(ref int i)
            {
                i = i + 1;
                Console.WriteLine("i is : " + i);
            }

            test = 20;
            addOneToRefParam(ref test);
            Console.WriteLine("test is : " + test);

            /* i is : 21
            test is : 21 
            "changes to the parameter change the variable whose 
            reference you passed” */



            // passing Parameter values as "out" references

            static void readPerson(out string name, out int age)
            {
                name = readString("Enter your name : ");
                age = readInt("Enter your age : ");
            }
           
            string name;
            int age;
            readPerson(out name, out age);

            Console.WriteLine($"{name} {age}");




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
        private static string readString(string v)
        {
            v = Console.ReadLine();
            return v;
        }

        private static int readInt(string input)
        {
            int myNum;
            input = Console.ReadLine();
            bool isString = int.TryParse(input, out myNum);
            return myNum;
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
