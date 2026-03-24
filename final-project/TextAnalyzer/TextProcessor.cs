using System;
using System.Collections.Generic;
using System.Linq;

public static class TextProcessor
{
    private static readonly string[] StopWords = { "the", "and", "is", "in", "at", "of", "a", "to" };

    public static List<(string FileName, List<string> Words)> ProcessFiles(
        List<(string FileName, string Content)> files)
    {
        return files.Select(file => (
            file.FileName,
            Words: file.Content
                .ToLower()
                .Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => !StopWords.Contains(word))
                .ToList())).ToList();
    }
}
