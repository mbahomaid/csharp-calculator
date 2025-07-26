namespace csharp_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello mathematician, choose operation: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            string? choice = Console.ReadLine();
            if (choice is null)
            {
                Console.WriteLine("Invalid choice, exiting.");
                return;
            }
            Console.WriteLine("Enter first number: ");
            string? firstInput = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            string? secondInput = Console.ReadLine();

            if (firstInput is null || secondInput is null)
            {
                Console.WriteLine("Invalid input, exiting.");
                return;
            }

            int? firstNumber = int.Parse(firstInput);
            int? secondNumber = int.Parse(secondInput);
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Result: {firstNumber + secondNumber}");
                    break;
                case "2":
                    Console.WriteLine($"Result: {firstNumber - secondNumber}");
                    break;
                case "3":
                    Console.WriteLine($"Result: {firstNumber * secondNumber}");
                    break;
                case "4":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Cannot divide by zero, exiting.");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {firstNumber / secondNumber}");
                    }
                    break;

            }


        }
    }
}
