﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
       
        { 
            {
                Console.Write("Enter the score of student 1: ");
                int score1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the score of student 2: ");
                int score2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the score of student 3: ");
                int score3 = Convert.ToInt32(Console.ReadLine());

                double average = (score1 + score2 + score3) / 3;

             
                Console.WriteLine("The average score is: {0:F2}", average);
            }
        }

    }
}

