using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double price = 250;
                double discountRate = 0.15;
                double discountAmount, finalPrice;

                discountAmount = price * discountRate;
                finalPrice = price - discountAmount;

                Console.WriteLine($"Original Price: ${price}");
                Console.WriteLine("Discount: 15%");
                Console.WriteLine($"Final Price after discount: ${finalPrice:F2}");
           
        }

    }
}

