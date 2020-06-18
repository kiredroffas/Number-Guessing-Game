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

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello " + inputName + ", let's play a game...");

            // Set correct number
            int correctNumber = 7;

            // Initial guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while(guess != correctNumber) {
                // Get users input
                string input = Console.ReadLine();

                // Make sure its a number
                if(!int.TryParse(input, out guess)) {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user its nor a number
                    Console.WriteLine("Please enter an actual number");

                    // Reset text color
                    Console.ResetColor();

                    // Start over logic in while loop
                    continue;
                }

                // Cast to int and put in guess var
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber) {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Write out wrong number message
                    Console.WriteLine("Wrong number, please try again");

                    // Reset text color
                    Console.ResetColor();
                }
            }

            // Output success message
            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Write out right number message
            Console.WriteLine("You are CORRECT!!!");

            // Reset text color
            Console.ResetColor();
        }
    }
}
