using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");

            var numberOfCupsOfCoffee = 2;
            var fullName = "Shawn";
            var date = DateTime.Now;

            Console.WriteLine($"{fullName} will drink {numberOfCupsOfCoffee} on {date}");

            Console.Write("What is your name? ");

            var name = Console.ReadLine();
            Console.WriteLine($"It is a pleasure to meet you, {name}"!);

            Console.Write("Lets play a game! Tell me two numbers between 0 - 25. ");

            Console.Write("What is your first number? ");
            var firstNumberAsString = Console.ReadLine();

            Console.Write("What is your second number? ");
            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine($"Great, thank you {name}"!);

            double firstNumberAsString = Convert.ToDouble(firstOperand);
            double secondNumberAsString = Convert.ToDouble(secondOperand);



        }
    }
}
