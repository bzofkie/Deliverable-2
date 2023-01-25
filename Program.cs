using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Author: Barbara Zofkie
 Date: 1/24/2023
 Description: C# Console application for calculating letter grade
 */

using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            decimal grade = decimal.Parse(Console.ReadLine());

            string letter;

            try
            {
                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";

                }
            }

            catch
            {
                Console.WriteLine("Enter a numeric grade: ");
            }

        }
    }
}
