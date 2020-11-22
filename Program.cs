using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Enter first operator:");
            char.TryParse(Console.ReadLine(), out char firstOperator);
            Console.WriteLine("Enter the second operator");
            char.TryParse(Console.ReadLine(), out char secondOperator);
            Console.WriteLine("Enter the third operator");
            char.TryParse(Console.ReadLine(), out char thirdOperator);


        }
    }
}
