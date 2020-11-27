using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Inlamningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Enter first term");
                int firstterm = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a operator");
                string _operator = Console.ReadLine();
                Console.WriteLine("Enter second term");
                int secondterm = int.Parse(Console.ReadLine());
                int result = 0;
                int sum = 0;
                if (_operator == "+")
                {
                    result = firstterm + secondterm;
                }

                else if (_operator == "-")
                {
                    result = firstterm - secondterm;
                }

                else if (_operator == "*")
                {
                    result = firstterm * secondterm;
                }

                else if (_operator == "/")
                {
                    result = firstterm / secondterm;
                }

                Console.WriteLine($"{firstterm} {_operator} {secondterm} = {result}");


                int[] arr = new int[result];
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += i;
                }
                if (sum < 100)
                {
                    Console.WriteLine("The sum is less then a hundred");
                }
                else if (sum > 100)
                {
                    Console.WriteLine("The sum is more then a hundred");
                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                }

                Console.WriteLine("Another try?");
                Console.WriteLine("Press Enter if you want to try again or Escpae if you want to quit");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {

                    continue;

                }
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {

                    Console.WriteLine($"Thank you for playing. The sum of all round is {sum}. Bye");
                    break;

                }

            }

            Console.ReadLine();
          
        }
    }
}
