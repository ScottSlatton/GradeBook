using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");

            book.AddGrade(10.9);
            book.AddGrade(38.5);
            book.AddGrade(80.8);

            var stats = book.GetStats();

            Console.WriteLine($"The average grade is: {stats.Average:N1}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");

        }
    }
}
