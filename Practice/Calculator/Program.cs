// See https://aka.ms/new-console-template for more information
int num1, num2, input;

Console.Write("\n\n");
Console.Write("------------------------------------------------");
Console.Write("Simple calculator:\n");
Console.Write("------------------------------------------------");
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
while (!int.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Invalid input! Please enter a valid number.");
    }