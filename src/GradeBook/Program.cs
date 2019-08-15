using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {


        static void Main(string[] args)
        {

            double result = 0.0;
            List<double> grades = new List<double>() { 1.0, 2.0, 3.0 };

            grades.Add(10.6);
            grades.Add(13.26);

            Console.WriteLine(grades.Count);

            foreach (double number in grades)
            {
                result += number;
            }

            double average = result / grades.Count;

            Console.WriteLine(average);


        }
    }
}
