using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine()
                .ToUpper()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (command[0].ToUpper()!= "END")
            {
                switch (command[0])
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;

                }
                command = Console.ReadLine()
                    .ToUpper()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            Console.Write(string.Join(" ", numbers));
        }
    }
}