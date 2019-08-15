using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloWorld("Scott");
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}");
            }
            else
            {
                Console.WriteLine("Please pass a name as a parameter.");
            }


        }

        /*  void HelloWorld(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        */
    }
}
