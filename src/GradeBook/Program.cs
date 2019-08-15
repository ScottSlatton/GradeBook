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
            book.ShowStats();

        }
    }
}
