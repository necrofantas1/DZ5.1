while (true)

    try
    {
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

       int result = number1 / number2;
        Console.WriteLine($"The result of dividing {number1} by {number2} is: {result}");

        break; 
    }

    catch (DivideByZeroException)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");

        Console.WriteLine("\nPlease enter a non-zero second number.");
    }

