using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");

            var numberOfCupsOfCoffee = 2;
            var fullName = "Shawn Soltesz";
            var date = DateTime.Now;

            Console.WriteLine($"{fullName} will drink {numberOfCupsOfCoffee} coffees on {date}");

            Console.Write("What is your name? ");

            var name = Console.ReadLine();
            Console.WriteLine($"It is a pleasure to meet you, {name}"!);

            Console.Write("Lets play a game! Tell me two numbers between 0 - 25. ");

            Console.Write("What is your first number? ");
            var firstNumberAsString = Console.ReadLine();

            Console.Write("What is your second number? ");
            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine($"Great, thank you {name}"!);

            var firstOperand = double.Parse(firstNumberAsString);

            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;

            var difference = secondOperand - firstOperand;

            var product = secondOperand * firstOperand;

            var quotient = firstOperand / secondOperand;

            var remainder = firstOperand % secondOperand;

            Console.WriteLine($"{name} provided the inputs of {firstOperand} and {secondOperand}");

            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine($"The difference is {difference}");

            Console.WriteLine($"The product is {product}");

            Console.WriteLine($"The quotient is {quotient}");

            Console.WriteLine($"The remainder is {remainder}");














        }
    }
}
