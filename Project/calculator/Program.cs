using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again = "yes";

            do
            {
                Console.WriteLine("Select a calculation method:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;

                    case 2:
                        result = num1 - num2;
                        break;

                    case 3:
                        result = num1 * num2;
                        break;

                    case 4:
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                            continue;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid selection! Please choose between 1-4.");
                        continue;
                }

                Console.WriteLine("Result: " + result);

                Console.Write("Do you want to perform another calculation? (yes/no): ");
                again = Console.ReadLine().ToLower();

                Console.WriteLine();

            } while (again == "yes");

            Console.WriteLine("Program ended. Thank you!");
        }
    }
}