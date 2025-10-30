using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 10; // predefined value
                int b = 20; // predefined value

                Console.WriteLine($"Before swapping: a = {a}, b = {b}");

                // Swapping using arithmetic (no temp variable)
                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine($"After swapping: a = {a}, b = {b}");
            }
        }
    }
}

