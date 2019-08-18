using System.Collections.Generic;
using System;

namespace GradeBook
{

    public class Book
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

        public Statistics GetStats()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;

        }



    }
}