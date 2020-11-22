using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            List<int> results = new List<int>();

            Console.WriteLine("Welcome!");
            Console.WriteLine("Enter first operator:");
            char.TryParse(Console.ReadLine(), out char firstOperator);
            Console.WriteLine("Enter the second operator");
            char.TryParse(Console.ReadLine(), out char secondOperator);

            int firstTerm;
            int secondTerm;
            int thirdTerm;

            do
            {
                Console.WriteLine("Terms must be bigger than 0");
                Console.WriteLine("Enter the first term");
                int.TryParse(Console.ReadLine(), out firstTerm);
                Console.WriteLine("Enter the second term");
                int.TryParse(Console.ReadLine(), out secondTerm);
                Console.WriteLine("Enter the third term");
                int.TryParse(Console.ReadLine(), out thirdTerm);
            } while (firstTerm == 0 || secondTerm == 0 || thirdTerm == 0);



            if (firstOperator == '+')
            {
                if (secondOperator == '+')
                {
                    sum = (firstTerm + secondTerm) + thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} + {secondTerm} + {thirdTerm} = {sum}");
                }
                else if (secondOperator == '-')
                {
                    sum = (firstTerm + secondTerm) - thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} + {secondTerm} - {thirdTerm} = {sum}");
                }
                else if (secondOperator == '*')
                {
                    sum = (firstTerm + secondTerm) * thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} + {secondTerm} * {thirdTerm} = {sum}");
                }
                else if (secondOperator == '/')
                {
                    sum = (firstTerm + secondTerm) / thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} + {secondTerm} / {thirdTerm} = {sum}");

                }
            }
            else if (firstOperator == '-')
            {
                if (secondOperator == '-')
                {
                    sum = (firstTerm - secondTerm) - thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} - {secondTerm} - {thirdTerm} = {sum}");
                }
                else if (secondOperator == '+')
                {
                    sum = (firstTerm - secondTerm) + thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} - {secondTerm} + {thirdTerm} = {sum}");
                }
                else if (secondOperator == '*')
                {
                    sum = (firstTerm - secondTerm) * thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} - {secondTerm} * {thirdTerm} = {sum}");
                }
                else if (secondOperator == '/')
                {
                    sum = (firstTerm - secondTerm) / thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} - {secondTerm} / {thirdTerm} = {sum}");

                }
            }
            else if (firstOperator == '*')
            {
                if (secondOperator == '*')
                {
                    sum = (firstTerm * secondTerm) * thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} * {secondTerm} * {thirdTerm} = {sum}");
                }
                else if (secondOperator == '-')
                {
                    sum = (firstTerm * secondTerm) - thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} * {secondTerm} - {thirdTerm} = {sum}");
                }
                else if (secondOperator == '+')
                {
                    sum = (firstTerm * secondTerm) + thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} * {secondTerm} + {thirdTerm} = {sum}");
                }
                else if (secondOperator == '/')
                {
                    sum = (firstTerm * secondTerm) / thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} * {secondTerm} / {thirdTerm} = {sum}");

                }
            }
            else if (firstOperator == '/')
            {
                if (secondOperator == '/')
                {
                    sum = (firstTerm / secondTerm) / thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} / {secondTerm} / {thirdTerm} = {sum}");
                }
               else  if (secondOperator == '*')
                {
                    sum = (firstTerm / secondTerm) / thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} / {secondTerm} / {thirdTerm} = {sum}");
                }
                else if (secondOperator == '-')
                {
                    sum = (firstTerm / secondTerm) - thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} / {secondTerm} - {thirdTerm} = {sum}");
                }
                else if (secondOperator == '+')
                {
                    sum = (firstTerm / secondTerm) + thirdTerm;
                    results.Add(sum);
                    Console.WriteLine($"{firstTerm} / {secondTerm} + {thirdTerm} = {sum}");
                }
            }
        }
    }
}
