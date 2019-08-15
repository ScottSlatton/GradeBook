using System.Collections.Generic;
using System;

namespace GradeBook
{

    class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        private List<double> grades;
        private string name;
        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine($"You have added {grade} to the grade book");

        }

        public void ShowStats()
        {
            double result = 0.0;
            List<double> grades = new List<double>() { 1.0, 2.0, 3.0 };

            grades.Add(10.6);
            grades.Add(13.26);

            Console.WriteLine(grades.Count);

            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach (double number in grades)
            {
                highestGrade = Math.Max(number, highestGrade);
                lowestGrade = Math.Min(number, lowestGrade);
                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"The average grade is: {result:N1}");
            Console.WriteLine($"The highest grade is: {highestGrade}");
            Console.WriteLine($"The lowest grade is: {lowestGrade}");

        }



    }
}