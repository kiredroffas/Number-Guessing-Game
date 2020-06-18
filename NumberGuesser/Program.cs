using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Get and display app info
        static void GetAppInfo() {
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

        // Ask user's name and greet
        static void GreetUser() {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello " + inputName + ", let's play a game...");
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user the message
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }

        // Entry point method
        static void Main(string[] args)
        {
            // Run GetAppInfo() function to get info
            GetAppInfo();

            // Ask for user's name and greet
            GreetUser();

            while(true) {
                // Create a new Random object
                Random random = new Random();
                // Get a random number
                int correctNumber = random.Next(1, 11);

                // Initial guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Start over logic in while loop
                        continue;
                    }

                    // Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Green, "CORRECT!!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                // If yes continue while loop
                if(answer == "Y") {
                    continue;
                }
                // Else if no return and exit
                else if(answer == "N") {
                    return;
                }
                // Else if anything else is typed output message, return and exit
                else {
                    Console.WriteLine("Thats not a Y or N... Bye!");
                    return;
                }
            }

            
        }
    }
}
