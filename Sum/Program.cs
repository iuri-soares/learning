using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number2Input = Console.ReadLine();

            int number1 = int.Parse(number1Input);
            int number2 = int.Parse(number2Input);

            int total  = number1 + number2;

            Console.WriteLine($"The sum of {number1} and {number2} is {total}");
            Console.ReadLine();
        }
    }
}
