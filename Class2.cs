using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaMethods
{
    class Class2
    {
        public static void Main(string[] args)
        {
            /* 
             List<int> grades = new List<int> { 78, 92, 100, 37, 81 };

            double average = grades.Average();

            Console.WriteLine("The average grade is {0}.", average);
            Console.ReadLine();
            */

            string[] numbers = { "10007", "37", "299846234235" };

            double average = numbers.Average(num => long.Parse(num));

            Console.WriteLine("The average is {0}.", average);
        }
    }
}
