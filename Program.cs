using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool stopPlaying = false;
            int firstTerm = 0;
            int secondTerm = 0;
            int thirdTerm = 0;
            List<int> results = new List<int>();

            do
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("Enter first operator:");
                char.TryParse(Console.ReadLine(), out char firstOperator);
                Console.WriteLine("Enter the second operator");
                char.TryParse(Console.ReadLine(), out char secondOperator);

                while(firstTerm == 0 || secondTerm == 0 || thirdTerm == 0)     // to avoid divide by zero Exception.
                {
                    Console.WriteLine("Enter the first term (must be > 0)");
                    int.TryParse(Console.ReadLine(), out firstTerm);
                    Console.WriteLine("Enter the second term (must be > 0)");
                    int.TryParse(Console.ReadLine(), out secondTerm);
                    Console.WriteLine("Enter the third term (must be > 0)");
                    int.TryParse(Console.ReadLine(), out thirdTerm);
                }
               

            

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
                        if (firstTerm - secondTerm == 0)   // i use this to avoid divide by zero Exception
                        {
                            sum = 0;
                            results.Add(sum);
                            Console.WriteLine($"{firstTerm} - {secondTerm} / {thirdTerm} = {sum}");
                        }
                        else
                        {
                            sum = (firstTerm - secondTerm) / thirdTerm;
                            results.Add(sum);
                            Console.WriteLine($"{firstTerm} - {secondTerm} / {thirdTerm} = {sum}");
                        }

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
                    else if (secondOperator == '*')
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

                if (sum < 100)
                {
                    Console.WriteLine("Less than hundred!");
                }
                else if (sum > 100)
                {
                    Console.WriteLine("More than hundred");
                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool you now have a hundred. You won!");
                }

                Console.WriteLine("Play again? y/n");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "N") 
                { 
                 stopPlaying = true;
                }
                else if ( answer == "Y")
                {
                     firstTerm = 0;
                     secondTerm = 0;
                     thirdTerm = 0;
                     sum = 0;
                }

            } while (stopPlaying != true);

            int totalSum = 0;

            foreach (var result in results)
            {
                totalSum += result;
            }

            Console.WriteLine($"Thank you for playing!\nTotal sum of all calculations: {totalSum}");
        }
    }
}
    

