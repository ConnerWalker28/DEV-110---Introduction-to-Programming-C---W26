/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        // TODO 1: Implement the main game loop
        // The loop should:
        // - Let player choose a template
        // - Collect words for the template
        // - Generate and display the story using template.GenerateStory()
        // - Ask if the player wants to play again
        // - Repeat if they answer 'y'
        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine("Chose a Template: " + template.Title);

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    // TODO 2: Implement ChooseTemplate
    // This method should:
    // - Print the two template options:
    //   1) Debugging at the Zoo
    //   2) The Standup Meeting
    // - Use ReadIntInRange to get user's choice (1-2)
    // - Return the appropriate StoryTemplate (see template details in README)
    private static StoryTemplate ChooseTemplate()
    {
        // throw new NotImplementedException();
        int choice;
        do
        {
            Console.WriteLine("1) Debugging at the Zoo");
            Console.WriteLine("2) The Standup Meeting");
            choice = ReadIntInRange("Choose a template (1-2): ", 1, 2);
        }
        while (choice < 1 || choice > 2);

        if (choice == 1)
        {
            return GetDebuggingAtTheZooTemplate();
        }
        else
        {
            return GetTheStandupMeetingTemplate();
        }
    }

    // TODO 3: Implement CollectWords
    // This method should:
    // - Use Logger.Info to log that word collection is starting
    // - Create a string array the same length as template.Prompts
    // - Loop through each prompt and use ReadNonEmptyString
    // - Print a blank line after collection
    // - Return the array of collected words
    private static string[] CollectWords(StoryTemplate template)
    {
        // throw new NotImplementedException();
        Logger.Info("Starting word collection for template: " + template.Title);
        string[] words = new string[template.Prompts.Length];
        for (int i = 0; i < template.Prompts.Length; i++)
        {
            words[i] = ReadNonEmptyString(template.Prompts[i]);
        }

        Console.WriteLine();
        return words;
    }

    // TODO 4: Implement ReadYesNo
    // This method should:
    // - Show the prompt
    // - Read input (handle null with ?? string.Empty)
    // - Trim the input
    // - Accept "y" or "n" (case-insensitive)
    // - Keep asking until valid input is provided
    // - Return true for "y", false for "n"
    private static bool ReadYesNo(string prompt)
    {
        // throw new NotImplementedException();
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }
        }
    }

    // TODO 5: Implement ReadIntInRange
    // This method should:
    // - Use a do-while loop
    // - Show the prompt
    // - Read input and use int.TryParse
    // - Validate the number is between min and max (inclusive)
    // - Keep asking until valid
    // - Return the valid integer
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // throw new NotImplementedException();
        int result;
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(input, out result) && result >= min && result <= max)
            {
                return result;
            }
            else
            {
                Console.WriteLine($"Invalid input. Please enter an integer between {min} and {max}.");
            }
        }
        while (true);
    }

    // TODO 6: Implement ReadNonEmptyString
    // This method should:
    // - Show the prompt
    // - Read input (handle null with ?? string.Empty)
    // - Trim the input
    // - Keep asking if input is empty or whitespace
    // - Return the valid non-empty string
    private static string ReadNonEmptyString(string prompt)
    {
        // throw new NotImplementedException();
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid string.");
            }
        }
    }

    // Helper method to create the "Debugging at the Zoo" template
    private static StoryTemplate GetDebuggingAtTheZooTemplate()
    {
        return new StoryTemplate(
            "Debugging at the Zoo",
            new[]
            {
                "Enter an adjective: ",
                "Enter an animal (plural): ",
                "Enter a verb ending in -ing: ",
                "Enter a programming language: ",
                "Enter a debugging tool (example: breakpoint): ",
                "Enter a number: ",
                "Enter an emotion: ",
                "Enter an exclamation: ",
            },
            "Today I visited the {0} zoo. I saw {1} {2} while writing {3}. I used a {4} {5} times until the bug disappeared. I felt {6} and yelled, \"{7}!\"");
    }

    // Helper method to create the "The Standup Meeting" template
    private static StoryTemplate GetTheStandupMeetingTemplate()
    {
        return new StoryTemplate(
            "The Standup Meeting",
            new[]
            {
                "Enter a name: ",
                "Enter an adjective: ",
                "Enter a noun: ",
                "Enter a verb (past tense): ",
                "Enter a number: ",
                "Enter a plural noun: ",
                "Enter a type of bug (example: null reference): ",
                "Enter a snack: ",
            },
            "{0} walked into the standup with a {1} {2}. They {3} the code {4} times before finding a {5} error. Everyone applauded with {6}, and we celebrated with {7}!");
    }
}
