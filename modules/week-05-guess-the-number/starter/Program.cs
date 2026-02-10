namespace GuessTheNumber;

public class Program
{
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;
        do
        {
            Console.Write(prompt);
            value = int.TryParse(Console.ReadLine(), out value) ? value : 0;
            isValid = value >= min && value <= max;
            if (!isValid)
            {
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
        }
        while (!isValid);
        return value;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");
        int maxValue = ReadIntInRange("Enter a max value (10-100): ", 10, 100);
        int rounds = ReadIntInRange("How many rounds? (1-3): ", 1, 3);
        for (int round = 1; round <= rounds; round++)
        {
            Console.WriteLine($"\nRound {round} of {rounds}");
            Random random = new Random(maxValue + round);
            int secret = random.Next(1, maxValue + 1);
            int guess = 0;
            int guessCount = 0;
            while (guess != secret)
            {
                guess = ReadIntInRange($"Guess a number (1-{maxValue}) : ", 1, maxValue);
                guessCount++;
                if (guess < secret)
                {
                    Console.WriteLine("Too Low.");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Too High.");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine($"You got it in {guessCount} guesses.");
                }
            }
        }

        Console.WriteLine("\nThanks for playing!");

        // TODO 1: Complete the helper method named ReadIntInRange
        // Why: It avoids repeating the same input-validation code for max value and rounds.

        // TODO 2: Get a valid max value (10-100) using ReadIntInRange
        // Prompt: "Enter a max value (10-100): "
        // Hint: int.TryParse() and range check (value >= 10 && value <= 100)
        // Store result in an int named maxValue

        // TODO 3: Get a valid number of rounds (1-3) using ReadIntInRange
        // Prompt: "How many rounds? (1-3): "
        // Hint: int.TryParse() and range check (value >= 1 && value <= 3)
        // Store result in an int named rounds

        // TODO 4: Use a for loop to repeat the game for each round
        // Example: for (int round = 1; round <= rounds; round++)
        // NOTE: The round header, secret number, and guessing loop are inside this for loop.

        // TODO 5: Display the round header (inside the for loop)
        // Example: Console.WriteLine($"\nRound {round} of {rounds}");

        // TODO 6: Generate a secret number in the range 1..max (inclusive)
        // Hint: Random random = new Random(maxValue + round);
        // Hint: int secret = random.Next(1, maxValue + 1);
        // NOTE: This should be inside the for loop so each round has a new secret.

        // TODO 7: Initialize guess tracking variables (inside the for loop)
        // Hint: int guess = 0; int guessCount = 0;

        // TODO 8: Use a while loop to keep asking until the guess is correct
        // Hint: while (guess != secret) { ... }
        // NOTE: Everything related to a single guess goes inside this while loop.

        // TODO 9: Read a guess and validate that it is a number (inside the while loop)
        // Prompt: $"Guess a number (1-{maxValue}): "
        // Hint: int.TryParse() and continue the loop if invalid
        // Hint: if parsing fails, skip feedback and ask again

        // TODO 10: Update guessCount and provide feedback (inside the while loop)
        // Track guessCount and print: "Too low.", "Too high.", or
        // "Correct! You got it in X guesses."

        // TODO 11: Print a closing message after all rounds finish
        // Example: "Thanks for playing!"
    }

    // private static int ReadIntInRange(string prompt, int min, int max)
    // {
    // Requirements:
    // - Use a do-while loop
    // - Use int.TryParse() for input
    // - Repeat until the value is in range
    // -- Hint: !isValid || value < min || value > max
    // }
}
