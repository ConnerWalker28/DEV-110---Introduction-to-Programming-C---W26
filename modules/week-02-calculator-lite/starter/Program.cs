using System.Diagnostics.CodeAnalysis;

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");
        bool decimalPrecision = false;
        int operationCount = 0;
        string user;
        double num1;
        double num2;

        Console.WriteLine("Enter your name:");
        user = Console.ReadLine();
        Console.WriteLine($"Hello, {user}!");

        Console.WriteLine("Use Decimal Precision? (yes/no)");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            decimalPrecision = true;
        }
        else if (answer == "no")
        {
            decimalPrecision = false;
        }

        Console.WriteLine("First Number?:");
        if (decimalPrecision)
        {
            num1 = double.Parse(Console.ReadLine());
        }
        else
        {
            num1 = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Second Number?:");
        if (decimalPrecision)
        {
            num2 = double.Parse(Console.ReadLine());
        }
        else
        {
            num2 = int.Parse(Console.ReadLine());
        }

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = 0;
        double remainder = 0;
        double average = (num1 + num2) / 2;
        double percentage = ((num1 - num2) / num1) * 100;

        if (decimalPrecision)
        {
            Console.WriteLine($"Sum: {sum:F2}");
            Console.WriteLine($"Difference: {difference:F2}");
            Console.WriteLine($"Product: {product:F2}");
            operationCount += 3;
            if (num2 == 0)
            {
                Console.WriteLine("Quotient: Error - Division by zero");
                Console.WriteLine("Remainder: Error - Division by zero");
            }
            else
            {
                quotient = num1 / num2;
                remainder = num1 % num2;
                Console.WriteLine($"Quotient: {quotient:F2}");
                Console.WriteLine($"Remainder: {remainder:F2}");
                operationCount += 2;
            }

            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Percentage Difference: {percentage:F2}%");
            operationCount += 1;
            }
            else
        {
            Console.WriteLine($"Sum: {sum:F0}");
            Console.WriteLine($"Difference: {difference:F0}");
            Console.WriteLine($"Product: {product:F0}");
            operationCount += 3;
            if (num2 == 0)
            {
                Console.WriteLine("Quotient: Error - Division by zero");
                Console.WriteLine("Remainder: Error - Division by zero");
            }
            else
            {
                quotient = num1 / num2;
                remainder = num1 % num2;
                Console.WriteLine($"Quotient: {quotient:F0}");
                Console.WriteLine($"Remainder: {remainder:F0}");
                operationCount += 2;
            }

            Console.WriteLine($"Average: {average:F0}");
            Console.WriteLine($"Percentage Difference: {percentage:F0}%");
            operationCount += 2;
        }

        Console.WriteLine($"Performed {operationCount} calculations for {user}!");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)

        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double

        // TODO: Prompt user for second number (same type as first)

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"

        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
