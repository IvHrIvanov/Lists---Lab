using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Max(numbers.Count, secondNumbers.Count); i++)
            {
                if (i <= numbers.Count-1)
                {
                    result.Add(numbers[i]);
                }
                if (i <= secondNumbers.Count-1)
                {
                    result.Add(secondNumbers[i]);
                }

            }
            Console.Write(string.Join(" ", result));
        }
    }
}