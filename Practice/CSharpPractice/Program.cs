// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("----------------------------------------------------------- \n");
//Console.WriteLine("Integers of differing sizes and range: \n");
//Console.WriteLine("----------------------------------------------------------- \n");

///* ---------
// * C# BASICS
// * --------*/

///* Data types */

///* Integers of differing sizes and ranges */

//// byte 

//byte aSingleByte = 30;
//byte byteByteUsage = 1;
//bool allowNegatives = false;
//byte minimumByte = 0;
//byte maximumByte = 255;

//Console.WriteLine($"byte:    Byte usage: {byteByteUsage} || Allows negatives: {allowNegatives} || Minimum byte:           {minimumByte} || Maximum byte:                   {maximumByte} || byte example: {aSingleByte} \n");

//// short

//short shortByteUsage = 2;
//bool shortAllowNegatives = true;
//short minimumShort = -32768;
//short maximumShort = 32767;
//short aShortNumber = 500;

//Console.WriteLine($"short:   Byte usage: {shortByteUsage} || Allows negatives: {shortAllowNegatives}  || Minimum short:     {minimumShort} || Maximum short:                {maximumShort} || short example: {aShortNumber} \n");

////int

//int intByteUsage = 4;
//bool intAllowNegatives = true;
//int minimumInt = -2_147_483_648;
//int maximumInt = 2_147_483_647;
//int aIntNumber = 50_000;

//Console.WriteLine($"int:     Byte usage: {intByteUsage} || Allows negatives: {intAllowNegatives}  || Minimum int:  {minimumInt} || Maximum int:             {maximumInt} || int example: {aIntNumber} \n");


////long

//long longByteUsage = 8;
//bool longAllowNegatives = true;
//long minimumLong = -2_147_483_648;
//long maximumLong = 2_147_483_647;
//long aLongNumber = 5_222_352_136_354_575_837;

//Console.WriteLine($"long:    Byte usage: {longByteUsage} || Allows negatives: {longAllowNegatives}  || Minimum long: {minimumLong} || Maximum long:            {maximumLong} || long example: {aLongNumber} \n");

////sbyte

//sbyte sbyteByteUsage = 1;
//bool sbyteAllowNegatives = true;
//sbyte minimumSbyte = -128;
//sbyte maximumSbyte = 127;
//sbyte aSbyteNumber = -50;

//Console.WriteLine($"sbyte:   Byte usage: {sbyteByteUsage} || Allows negatives: {sbyteAllowNegatives}  || Minimum sbyte:       {minimumSbyte} || Maximum sbyte:                  {maximumSbyte} || sbyte example: {aSbyteNumber} \n");

////ushort

//ushort ushortByteUsage = 1;
//bool ushortAllowNegatives = false;
//ushort minimumUshort = 0;
//ushort maximumUshort = 65_535;
//ushort aUshortNumber = 11_111;

//Console.WriteLine($"ushort:  Byte usage: {ushortByteUsage} || Allows negatives: {ushortAllowNegatives} || Minimum ushort:         {minimumUshort} || Maximum ushort:               {maximumUshort} || ushort example: {aUshortNumber} \n");

////uint

//uint uintByteUsage = 4;
//bool uintAllowNegatives = false;
//uint minimumUint = 0;
//uint maximumUint = 4_294_967_295;
//uint aUintNumber = 2_000_967_295;

//Console.WriteLine($"uint:    Byte usage: {uintByteUsage} || Allows negatives: {uintAllowNegatives} || Minimum uint:           {minimumUint} || Maximum uint:            {maximumUint} || uint example: {aUintNumber} \n");

////ulong

//ulong ulongByteUsage = 8;
//bool ulongAllowNegatives = false;
//ulong minimumulong = 0;
//ulong maximumulong = 18_446_744_073_709_551_615;
//ulong aUlongNumber = 17_226_114_073_239_541_111;

//Console.WriteLine($"ulong:   Byte usage: {ulongByteUsage} || Allows negatives: {ulongAllowNegatives} || Minimum ulong:          {minimumulong} || Maximum ulong: {maximumulong} || ulong example: {aUlongNumber} \n");


Console.WriteLine("\n");
Console.WriteLine("----------------------------------------------------------- \n");

/* --------------------------------------------------------------------------------------*/

MainMenu();


static void ForLoop()
{
    

    Console.WriteLine("\n");
    Console.WriteLine("Hello! This is an example of << For Loop >>:\n");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("for (int i = 0; i < 5; i++) \r\n{\r\n  Console.WriteLine(i);\r\n}\n");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("Press enter to continue and see what the code does!\n");
    Console.ReadLine();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i);
    }
    Console.ReadLine();
    Console.WriteLine("Statement was executed and it listed numbers from 0 to 4!\n");
    Console.WriteLine("Press enter to go back to main menu\n");
    Console.ReadLine();
    Console.Clear();
    MainMenu();
}


static void While()
{
    Console.WriteLine("\n");
    Console.WriteLine("Hello! This is an example of << While Loop >>:\n");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("int i = 0;\r\nwhile (i < 5) \r\n{\r\n  Console.WriteLine(i);\r\n  i++;\r\n}");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("Press enter to continue and see what the code does!\n");
    Console.ReadLine();
    int i = 0;
    while (i < 5)
    {
        Console.WriteLine(i);
        i++;
    }
    Console.WriteLine("\n");
    Console.WriteLine("Statement was executed and it listed numbers from 0 to 4!\n");
    Console.WriteLine("Here is another example of a << While Loop >>!\n");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("while (true)\r\n    {\r\n        Console.WriteLine(\"You are stuck in an infinite loop until you enter STOP\");\r\n        string stop = Console.ReadLine();\r\n        if (stop == \"STOP\") break;\r\n        \r\n    }");
    Console.WriteLine("----------------------------------------------------------- \n");
    while (true)
    {
        Console.WriteLine("You are stuck in an infinite loop until you enter STOP");
        string stop = Console.ReadLine();
        if (stop == "STOP") break;
        
    }
    Console.WriteLine("Press enter to go back to main menu\n");
    Console.ReadLine();
    Console.Clear();
    MainMenu();

}

static void DoWhile()
{
    Console.WriteLine("\n");
    Console.WriteLine("Hello! This is an example of << Do While Loop >>:\n");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("int i = 0;\r\ndo \r\n{\r\n  Console.WriteLine(i);\r\n  i++;\r\n}\r\nwhile (i < 5);");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("Press enter to continue and see what the code does!\n");
    Console.ReadLine();
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    }
    while (i < 5);
    Console.WriteLine("\n");
    Console.WriteLine("Statement was executed and it listed numbers from 0 to 4!\n");
    Console.WriteLine("Press enter to see another example of Do While loop!\n");
    Console.ReadLine();
    Console.WriteLine("Here is another example of a << While Loop >>!\n");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("string stopIt;\r\n    do\r\n    {\r\n        Console.WriteLine(\"Welcome to infinity hell\");\r\n        stopIt = Console.ReadLine();\r\n    }\r\n    while (stopIt != \"STOP\");\r\n    {\r\n        \r\n        Console.WriteLine(\"You are stuck in an infinite loop until you enter STOP\");\r\n        string stop = Console.ReadLine();\r\n\r\n    }");
    Console.WriteLine("----------------------------------------------------------- \n");
   
    string stopIt;
    do
    {
        Console.WriteLine("Welcome to infinity hell, enter STOP to exit");
        stopIt = Console.ReadLine();
    }
    while (stopIt != "STOP");
    {
        
        Console.WriteLine("Phew... You were stuck in an infinite loop until you entered STOP");
        

    }

    Console.WriteLine("Press enter to go back to main menu\n");
    Console.ReadLine();
    Console.Clear();
    MainMenu();
}

static void ForEach()
{
    Console.WriteLine("\n");
    Console.WriteLine("Hello! This is an example of << For Each Loop >>:\n");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("char[] myArray = {'H','e','l','l','o'};\r\n \r\n            foreach(char ch in myArray)\r\n            {\r\n                Console.WriteLine(ch);\r\n            }");
    Console.WriteLine("----------------------------------------------------------- \n");
    Console.WriteLine("Press enter to continue and see what the code does!\n");
    Console.ReadLine();
    char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

    foreach (char ch in myArray)
    {
        Console.WriteLine(ch);
    }
    Console.ReadLine();
    Console.WriteLine("Statement was executed and it looped through an array, spelling out all characters in it!\n");
    Console.WriteLine("Press enter to go back to main menu\n");
    Console.ReadLine();
    Console.Clear();
    MainMenu();
}

static void MainMenu()
{
    Console.Write("\nOptions" +
        ":\n");
    Console.Write("1: For loop\n2: While loop\n3: Do-While loop\n4: Foreach loop\n5: Exit\n");

    int input;

    Console.Write("\nInput your choice: ");
    while (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("Invalid input! Please enter a valid number.\n");
    }

    switch (input)
    {
        case 1:
            ForLoop();
            break;

        case 2:
            While();
            break;

        case 3:
            DoWhile();
            break;

        case 4:
            ForEach();
            break;

        case 5:
            Console.WriteLine("----------------------------------------------------------- \n");
            Console.Write("Goodbye\n");
            
            break;

        default:
            Console.Write("Input correct option\n");
            break;


    }
}





/* --------------------------------------------------------------------------------------*/


/* -----------------------*/
/* Characters and strings */
/* -----------------------*/

// char

//Console.WriteLine("Examples of char data types: \n");
//Console.WriteLine("----------------------------------------------------------- \n");

//char aLetter = 'a';
//char star = '\u002A';

//Console.WriteLine($"{aLetter} and a {star}\n" );

//// string

//Console.WriteLine("Examples of string data types: \n");
//string helloWorld = "Hello World";
//Console.WriteLine("What is your first name? \n");
//string firstName = Console.ReadLine();

//Console.WriteLine($"{helloWorld}! My name is {firstName.ToLower()}! \n");
//Console.WriteLine("Press enter to continue");
//Console.ReadLine();


///* --------------------------*/
///* Floating-point data types */
///* --------------------------*/

//Console.WriteLine("\n");
//Console.WriteLine("----------------------------------------------------------- \n");
//Console.WriteLine("Examples of float, double and decimal data types: \n");
//Console.WriteLine("----------------------------------------------------------- \n");

////float - 4 bytes || 7 digits of precision

//float number1 = 3.14159f;

////double - 8 bytes || 15-16 digits of precision

//double number2 = 3.14159D;

////decimal - 16 bytes || 28-29 digits of precision

//decimal number3 = 3.14159m;


//Console.WriteLine("Examples - division - 1/3: \n");

//float flt = 1F / 3;
//double dbl = 1D / 3;
//decimal dcm = 1M / 3;
//Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);

//Console.WriteLine("Press enter to continue");
//Console.ReadLine();



///* --------------------------*/
///* Boolean data type */
///* --------------------------*/


//Console.WriteLine("\n");
//Console.WriteLine("----------------------------------------------------------- \n");
//Console.WriteLine("Examples of boolean data type \n");
//Console.WriteLine("----------------------------------------------------------- \n");


//Console.Write("Enter a number: \n");

//string userInput = Console.ReadLine();

//if (Int32.TryParse(userInput, out int number))
//{
//    Console.WriteLine($"I converted your number: {number} to an integer \n");
//}
//else
//{
//    Console.WriteLine("Enter a valid number \n");
//}

//Console.WriteLine("Press enter to continue");
//Console.ReadLine();

//Console.WriteLine("Is C# fun?\n");

//bool isCSharpFun = true;



//if (isCSharpFun)
//{
//    Console.Write("Yes, it\'s okay \n");
//}
//else
//{
//    Console.Write("No");
//}

//Console.WriteLine("Press enter to continue");
//Console.ReadLine();

//Console.WriteLine("----------------------------------------------------------- \n");
//Console.WriteLine("Array practice \n");
//Console.WriteLine("----------------------------------------------------------- \n");
///* --------------------------*/
///* Array practice */
///* --------------------------*/

////string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };


////Console.WriteLine(cars[0]);


//////update index 0 in an array "cars"

////cars[0] = "Opel";

////Console.WriteLine(cars[0]);



////set array, hardcode values

//string[] firstNames = new string[5];

//firstNames[0] = "Luka";
//firstNames[1] = "Marija";
//firstNames[2] = "Jona";
//firstNames[3] = "Mila";
//firstNames[4] = "Noa";

//Console.WriteLine($"Array firstNames contains following names {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[3]}, {firstNames[4]}\n");


////set array, split string into arrays using separator ","

//string testArraySplit = "luka,Marija,Jona,Mila,Noa";

//string[] firstNamesSplit = testArraySplit.Split(',');

//Console.WriteLine($"Last firstName in the array firstNamesSplit is {firstNamesSplit[4]}\n");
//Console.WriteLine("----------------------------------------------------------- \n");

//Console.WriteLine("Press enter to continue");
//Console.ReadLine();


////Math
//Console.WriteLine("Enter the first number:");
//string firstNumber = Console.ReadLine();
//Console.WriteLine("Enter the second number:");
//string secondNumber = Console.ReadLine();

//Int32.TryParse(firstNumber, out int numberX);
//Int32.TryParse(secondNumber, out int numberY);

//Console.WriteLine($"Between number {firstNumber} and number { secondNumber } the number {(Math.Max(numberX, numberY))} is a bigger number");