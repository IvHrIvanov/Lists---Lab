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

            bool flag = false;

            string outputText = string.Empty;
            while (command[0].ToUpper() != "END")
            {
                switch (command[0])
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        flag = true;
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));
                        flag = true;
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));
                        flag = true;
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        flag = true;
                        break;
                    case "CONTAINS":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No");
                        break;
                    case "PRINTEVEN":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;
                    case "PRINTODD":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 1)));
                        break;
                    case "GETSUM":
                        Console.WriteLine(numbers.Sum(n => n));
                        break;
                    case "FILTER":
                        switch (command[1])
                        {
                            case ">=":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(command[2]))));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(command[2]))));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(command[2]))));
                                break;
                            case "<":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(command[2]))));
                                break;
                        }
                        break;
                }
               
                command = Console.ReadLine()
                    .ToUpper()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            if(flag)
            {
                Console.Write(string.Join(" ", numbers));

            }
            
        }
    }
}