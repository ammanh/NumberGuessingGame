class Program
{
    static void Main()
    {
        bool playAgain = true; 

        while (playAgain) 
        {
            Random random = new Random(); 
            int numberToGuess = random.Next(1, 101); 
            int guess = 0; 

            Console.WriteLine("\nGuess the number (between 1 and 100)!");

            while (guess != numberToGuess) 
            {
                Console.Write("Enter your guess: ");
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < 1 || guess > 100)
                        Console.WriteLine("Enter a valid number between 1 and 100!");
                    else if (guess < numberToGuess)
                        Console.WriteLine("Too low! Try again.");
                    else if (guess > numberToGuess)
                        Console.WriteLine("Too high! Try again.");
                    else
                        Console.WriteLine("Congratulations! You guessed the number.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower(); 

            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
