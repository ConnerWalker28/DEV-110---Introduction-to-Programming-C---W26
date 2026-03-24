using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string folderPath = "texts";

        List<(string FileName, string Content)> files = FileLoader.LoadFiles(folderPath);

        if (files == null || files.Count == 0)
        {
            Console.WriteLine($"No text files found in folder '{folderPath}'. Please add TXT files and try again.");
            return;
        }

        List<(string FileName, List<string> Words)> processedFiles = TextProcessor.ProcessFiles(files);

        // Pre-calculate all analysis data
        List<(string Word, int Count)> overallStats = Analyzer.GetWordFrequency(processedFiles);
        List<(string FileName, List<(string Word, int Count)> TopWords)> perFileStats =
            Analyzer.GetTopWordsPerFile(processedFiles);
        List<string> longestWords = Analyzer.GetLongestWords(processedFiles);

        // Display menu and get user choices
        Console.WriteLine("=== Text Analyzer Menu ===");
        Console.WriteLine("Choose analysis options (enter numbers separated by commas, e.g., '1, 2, 4'):");
        Console.WriteLine("1. File Statistics");
        Console.WriteLine("2. Longest Words");
        Console.WriteLine("3. Overall Word Frequency");
        Console.WriteLine("4. Top Words Per File");
        Console.WriteLine("5. Generate Processed Text Files");
        Console.WriteLine("6. Word Removal Tool");
        Console.WriteLine();

        Console.Write("Enter your choices: ");
        string? input = Console.ReadLine();

        // Parse user input
        List<int> selectedOptions = ParseUserChoices(string.IsNullOrEmpty(input) ? string.Empty : input);

        // Run selected analysis options
        if (selectedOptions.Contains(1))
        {
            DisplayFileStatistics(files, processedFiles);
        }

        if (selectedOptions.Contains(2))
        {
            DisplayLongestWords(longestWords);
        }

        if (selectedOptions.Contains(3))
        {
            DisplayOverallWordFrequency(overallStats);
        }

        if (selectedOptions.Contains(4))
        {
            DisplayTopWordsPerFile(perFileStats);
        }

        if (selectedOptions.Contains(5))
        {
            GenerateProcessedTextFiles(processedFiles);
        }

        if (selectedOptions.Contains(6))
        {
            RunWordRemovalTool(files);
        }

        // Prompt to print processed file content to console
        Console.WriteLine("\nWould you like to print processed file content to the console? (y/n)");
        string? printChoice = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(printChoice) && printChoice.Trim().Equals("y", StringComparison.OrdinalIgnoreCase))
        {
            PrintProcessedTextFiles(processedFiles);
        }

        Console.WriteLine("\nAnalysis complete!");
    }

    private static List<int> ParseUserChoices(string input)
    {
        var choices = new List<int>();
        if (string.IsNullOrWhiteSpace(input))
        {
            return choices;
        }

        string[] parts = input.Split(',');
        foreach (string part in parts)
        {
            if (int.TryParse(part.Trim(), out int choice) && choice >= 1 && choice <= 6)
            {
                choices.Add(choice);
            }
        }

        return choices;
    }

    private static void DisplayFileStatistics(
        List<(string FileName, string Content)> files,
        List<(string FileName, List<string> Words)> processedFiles)
    {
        Console.WriteLine("\n=== File Statistics ===");
        for (int i = 0; i < files.Count; i++)
        {
            string fileName = files[i].FileName;
            int charCount = files[i].Content.Length;
            int wordCount = processedFiles[i].Words.Count;
            Console.WriteLine($"File: {fileName} - Words: {wordCount}, Characters: {charCount}");
        }
    }

    private static void DisplayLongestWords(List<string> longestWords)
    {
        Console.WriteLine("\n=== Longest Words (All Files) ===");
        Console.WriteLine();
        foreach (string word in longestWords)
        {
            Console.WriteLine(word);
        }
    }

    private static void DisplayOverallWordFrequency(List<(string Word, int Count)> overallStats)
    {
        Console.WriteLine("\n=== Overall Word Frequency ===");
        Console.WriteLine();

        foreach ((string Word, int Count) word in overallStats.Take(10))
        {
            Console.WriteLine($"{word.Word}: {word.Count}");
        }
    }

    private static void DisplayTopWordsPerFile(List<(string FileName, List<(string Word, int Count)> TopWords)> perFileStats)
    {
        Console.WriteLine("\n=== Top Words Per File ===");
        foreach ((string FileName, List<(string Word, int Count)> TopWords) file in perFileStats)
        {
            Console.WriteLine($"\nFile: {file.FileName}");

            foreach ((string Word, int Count) word in file.TopWords)
            {
                Console.WriteLine($"{word.Word}: {word.Count}");
            }
        }
    }

    private static void GenerateProcessedTextFiles(List<(string FileName, List<string> Words)> processedFiles)
    {
        Console.WriteLine("\n=== Processed Text Per File (No Stop Words, No Duplicates) ===");
        Console.WriteLine();
        string outputDir = "outputs";
        Directory.CreateDirectory(outputDir);

        for (int i = 0; i < processedFiles.Count; i++)
        {
            string fileName = processedFiles[i].FileName;
            IEnumerable<string> uniqueWords = processedFiles[i].Words.Distinct();
            string text = string.Join(" ", uniqueWords);
            string outputFileName = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(fileName) + "_processed.txt");
            File.WriteAllText(outputFileName, text);
            Console.WriteLine($"Processed text saved to {outputFileName}");
        }
    }

    private static void RunWordRemovalTool(List<(string FileName, string Content)> files)
    {
        Console.WriteLine("\n=== Remove Word From Original Files ===");
        Console.WriteLine();
        Console.WriteLine("Enter a word to remove from original text files:");

        string? removeWord = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(removeWord))
        {
            var outputLines = new List<string>();
            foreach ((string FileName, string Content) file in files)
            {
                string cleaned = System.Text.RegularExpressions.Regex.Replace(
                    file.Content,
                    $"\\b{System.Text.RegularExpressions.Regex.Escape(removeWord)}\\b",
                    string.Empty,
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // Normalize whitespace after removal
                cleaned = System.Text.RegularExpressions.Regex.Replace(cleaned, "\\s+", " ").Trim();

                outputLines.Add($"=== {file.FileName} ===");
                outputLines.Add(cleaned);
            }

            string outputDir = "outputs";
            Directory.CreateDirectory(outputDir);
            string manualOutputFile = Path.Combine(outputDir, "manual_output.txt");
            File.WriteAllText(manualOutputFile, string.Join(Environment.NewLine, outputLines));
            Console.WriteLine($"Original files (without the removed word) saved to {manualOutputFile}");
        }
        else
        {
            Console.WriteLine("No word entered.");
        }
    }

    private static void PrintProcessedTextFiles(List<(string FileName, List<string> Words)> processedFiles)
    {
        Console.WriteLine("\n=== Processed Files Content ===");
        foreach ((string FileName, List<string> Words) file in processedFiles)
        {
            Console.WriteLine($"\n--- {file.FileName} ---");
            IEnumerable<string> uniqueWords = file.Words.Distinct();
            Console.WriteLine(string.Join(" ", uniqueWords));
        }
    }
}
