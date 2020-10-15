using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int originalLenght = number.Count;

            for (int i = 0; i < originalLenght / 2; i++)
            {
                number[i] += number[number.Count - 1];
                number.RemoveAt(number.Count - 1);
            }

            Console.WriteLine(string.Join(" ", number));

        }
    }
}
