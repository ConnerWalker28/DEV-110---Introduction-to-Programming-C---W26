namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        Console.WriteLine("Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hometown (city, state):");
        string hometown = Console.ReadLine();
        Console.WriteLine("Favorite color:");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine("Dream job:");
        string dreamJob = Console.ReadLine();
        Console.WriteLine("Major:");
        string major = Console.ReadLine();
        Console.WriteLine("GPA (0.0 - 4.0):");
        double gpa = double.Parse(Console.ReadLine());
        Console.WriteLine("Graduation year:");
        int graduationYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Are you a full-time student? (yes/no):");
        bool isFullTime = Console.ReadLine().ToLower() == "yes";
        Console.WriteLine("Age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Height in inches:");
        double heightInches = double.Parse(Console.ReadLine());
        Console.WriteLine("Favorite number:");
        int favoriteNumber = int.Parse(Console.ReadLine());

        int birthYear = 2026 - age;
        int yearsLeft = graduationYear - 2026;
        int feet = (int)(heightInches / 12);
        double inches = heightInches % 12;
        bool isHonorStudent = gpa >= 3.5;
        int ageMonths = age * 12;

        // Printing Card
        Console.WriteLine("══════════Personal Information:═══════════");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Hometown: " + hometown);
        Console.WriteLine("Favorite Color: " + favoriteColor);
        Console.WriteLine("Dream Job: " + dreamJob);
        Console.WriteLine("Age:" + age);
        Console.WriteLine("Favorite Number: " + favoriteNumber);
        Console.WriteLine(" ");
        Console.WriteLine("══════════Academic Details:═══════════════");
        Console.WriteLine("Major: " + major);
        Console.WriteLine("GPA: " + gpa.ToString("F2"));
        Console.WriteLine("Graduation Year: " + graduationYear);
        Console.WriteLine("Full-time Student: " + (isFullTime ? "Yes" : "No"));
        Console.WriteLine(" ");
        Console.WriteLine("══════════Calculated Statistics:══════════");
        Console.WriteLine("Birth Year: " + birthYear);
        Console.WriteLine("Years to Graduation: " + yearsLeft);
        Console.WriteLine("Height: " + feet.ToString("F0") + " feet " + inches + " inches");
        Console.WriteLine("Honor Student: " + (isHonorStudent ? "Yes" : "No"));
        Console.WriteLine("Age in Months: " + ageMonths);

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        // - Hometown (city, state)
        // - Favorite color
        // - Dream job
        // Hint: string variableName = Console.ReadLine();

        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        // - GPA (double, 0.0-4.0)
        // - Graduation year (int)
        // - Is full-time student? (bool from yes/no)
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        // - Height in inches (double)
        // - Favorite number (int)

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        // - Is honor student? = gpa >= 3.5
        // - Age in months = age * 12

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
