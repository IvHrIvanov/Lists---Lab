using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();


            for (int i = 1; i < number.Count; i++)
            {
                if (number[i - 1] == number[i])
                {
                    
                    number[i] = number[i - 1] + number[i];
                    number.RemoveAt(i - 1);
                    i = i - 2;
                    if (i < 0)
                    {
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", number));

        }
    }
}
