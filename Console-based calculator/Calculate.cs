// Second Run (after refactoring): 2023-10-14 01:00 PM
class Calculate
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();
        Console.Write("Enter second number: ");
        decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("===================================");
        Console.WriteLine($"Result: { Calculator(firstNumber, secondNumber, op) } ");
        Console.WriteLine("===================================");
        Console.WriteLine("Enter any key to exit .....");
        Console.Read();
    }
    static decimal Calculator(decimal firstNumber, decimal secondNumber, string op)
    {
        if (op == "+")
        {
            return firstNumber + secondNumber;
        }

        if (op == "-")
        {
            return firstNumber - secondNumber;
        }
        
        if (op == "*")
        {
            return firstNumber * secondNumber;
        }
        
        if (op == "/")
        {
            decimal remainder = firstNumber % secondNumber;
            Console.WriteLine($"Remainder: { remainder } ");
            return  firstNumber / secondNumber;
        }
        return 0;
    }
}

