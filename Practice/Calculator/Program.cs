// See https://aka.ms/new-console-template for more information
MainMenu();

static void MainMenu()
{
    int num1, num2, input;

    Console.Write("\n\n");
    Console.Write("------------------------------------------------\n");
    Console.Write("Simple calculator:\n");
    Console.Write("------------------------------------------------\n");
    Console.Write("\n\n");



    Console.Write("Enter the first number :");
    while (!int.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Invalid input! Please enter a valid number.");
    }

    Console.Write("Enter the second number :");
    while (!int.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Invalid input! Please enter a valid number.");
    }


    Console.Write("\nOptions :\n");
    Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");

    Console.Write("\nInput your choice :");
    while (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("Invalid input! Please enter a valid number.");
    }

    switch (input)
    {
        case 1:
            Console.Clear();
            Console.Write($"The Addition of  {num1} and {num2} is: {(num1 + num2)}\n");
            MainMenu();
            break;

        case 2:
            Console.Clear();
            Console.Write($"The Substraction of {num1}  and {num2} is: {(num1 - num2)}\n");
            MainMenu();
            break;

        case 3:
            Console.Clear();
            Console.Write($"The Multiplication of {num1}  and {num2} is: {(num1 * num2)}\n");
            MainMenu();
            break;

        case 4:
            if (num2 == 0)
            {
                Console.Clear();
                Console.Write("The second integer is zero. Divide by zero.\n");
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.Write($"The Division of {num1}  and {num2} is : {(num1 / num2)}\n");
                MainMenu();
            }
            break;

        case 5:
            break;

        default:
            Console.Write("Input correct option\n");
            break;


    }
}



