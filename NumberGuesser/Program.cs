using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Erik";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info
            Console.WriteLine(appName + ": Version " + appVersion + " by " + appAuthor);

            // Reset text color
            Console.ResetColor();
        }
    }
}
