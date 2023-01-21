/*
 Author: Domenick Rado
Date:1/20/2023
Description: C# console application for calculating letter grades
*/

using System;

namespace Deliverable_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {

                int grade = int.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is A");
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is B");
                }
                else if (grade >= 70 && grade < 80 && grade < 90)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is C");
                }
                else if (grade >= 60 && grade < 70 && grade < 80 && grade < 90)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is D");
                }
                else if (grade >= 50 && grade < 60 && grade < 70 && grade < 80 && grade < 90)
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is F");
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
            }
        }
    }
}