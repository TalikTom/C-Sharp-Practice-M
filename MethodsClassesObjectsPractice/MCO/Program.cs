// See https://aka.ms/new-console-template for more information
using MCO;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name?\n");
            string firstName = Console.ReadLine();

            UserMessages.ApplicationStartMessage(firstName);



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
    }
}
