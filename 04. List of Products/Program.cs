using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            List<string> producst = new List<string>();
         

            for (int i = 0; i < rows; i++)
            {
                string addProducts = Console.ReadLine();


                producst.Add(addProducts);

            }
            producst.Sort();

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"{i+1}.{producst[i]}");
            }
        }
    }
}
