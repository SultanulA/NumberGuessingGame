using System;

namespace NumberGuessingGame
{
    class Program
    {
        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;

            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine(); // "66" to 66
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);

            return integerFromUser;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game!  The higher your score, the worse you did!");

            int maxRange = GetIntegerFromUser("What max range would you like?");

            Random random = new Random();

            int secretNumber = random.Next(1, maxRange + 1);

            int score = 0; 
            int guess;

                        
            do
            {
                Console.ResetColor();
                Console.WriteLine("Your current score is " + score);
                guess = GetIntegerFromUser($"Please guess a number between 1- {maxRange}:");

                if (guess > secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were too high, loser!");
                    score += 1;
                }
                if (guess < secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were too low, loser");
                    score += 1;
                }

            } while (guess != secretNumber);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You got it!");
            Console.WriteLine("Your final score was " + score);
        }
    }
}
