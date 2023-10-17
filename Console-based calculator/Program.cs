// // See https://aka.ms/new-console-template for more information
// // First Successful Run: 2023-10-14 01:00 PM 
// class CalculateProgram
// {
//     static void Main()
//     {
//         Console.WriteLine("Welcome to Console-based calculator");
//         Console.WriteLine("===================================");
//         Console.WriteLine("This program will calculate two numbers");
//         Console.WriteLine("===================================");
//         Console.WriteLine("Enter two numbers to calculate and operator");
//         Console.WriteLine("===================================");
//         Input take = new Input();
//         Console.Write("Enter first number: ");
//         take.FirstNumber = Convert.ToDecimal(Console.ReadLine());
//         Console.Write("Enter operator (+, -, *, /): ");
//         take.Operator = Console.ReadLine();
//         Console.Write("Enter second number: ");
//         take.SecondNumber = Convert.ToDecimal(Console.ReadLine());
//         Console.WriteLine("===================================");
//         take.Calculator(take.FirstNumber, take.SecondNumber, take.Operator);
//         Console.WriteLine("===================================");
//         Console.WriteLine("Enter any key to exit .....");
//         Console.Read();
//     }
// }
//
//
// class Input
// {
//     // Fields Members 
//     private decimal _firstNumber;
//     private decimal _secondNumber;
//     private string? _operator;
//
//     // Properties Members
//     public decimal FirstNumber
//     {
//         get { return _firstNumber; }
//         set { _firstNumber = value; }
//     }
//     public decimal SecondNumber
//     {
//         get { return _secondNumber; }
//         set { _secondNumber = value; }
//     }
//
//     public string Operator
//     {
//         get { return _operator; }
//         set { _operator = value; }
//     }
//     
//     // Methods Members
//     public void Calculator(decimal firstNumber, decimal secondNumber, string op)
//     {
//         if (op == "+")
//         {
//             Console.WriteLine($"Result: { firstNumber + secondNumber } ");
//         }
//
//         if (op == "-")
//         {
//             Console.WriteLine($"Result: { firstNumber - secondNumber } ");
//         }
//         
//         if (op == "*")
//         {
//             Console.WriteLine($"Result: { firstNumber * secondNumber } ");
//         }
//         
//         if (op == "/")
//         {
//             Console.WriteLine($"Result: { firstNumber / secondNumber } ");
//             Console.WriteLine($"Reminder: { firstNumber % secondNumber } ");
//         }
//     } 
// }
