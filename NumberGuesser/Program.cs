using System;
using System.Security.Principal;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            string name = "Erik";
            int age = 23;

            // Ways to print
            Console.WriteLine(name + " is " + age);
            Console.WriteLine("{0} is {1}", name, age);
            Console.WriteLine($"{name} is {age}");
        }
    }
}
