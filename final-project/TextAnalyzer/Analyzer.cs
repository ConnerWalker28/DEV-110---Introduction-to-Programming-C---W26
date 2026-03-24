using System.Collections.Generic;
using System.Linq;

public static class Analyzer
{
    public static List<(string Word, int Count)> GetWordFrequency(
        List<(string FileName, List<string> Words)> files)
    {
        return files
            .SelectMany(f => f.Words)
            .GroupBy(word => word)
            .Select(g => (Word: g.Key, Count: g.Count()))
            .OrderByDescending(x => x.Count)
            .ToList();
    }

    public static List<(string FileName, List<(string Word, int Count)> TopWords)> GetTopWordsPerFile(
        List<(string FileName, List<string> Words)> files)
    {
        return files.Select(f => (
            f.FileName,
            TopWords: f.Words
                .GroupBy(word => word)
                .Select(g => (Word: g.Key, Count: g.Count()))
                .OrderByDescending(x => x.Count)
                .Take(5)
                .ToList())).ToList();
    }

    public static List<string> GetLongestWords(
    List<(string FileName, List<string> Words)> files)
    {
    List<string> allWords = files
        .SelectMany(f => f.Words)
        .ToList();

    int maxLength = allWords.Max(w => w.Length);

    return allWords
        .Where(w => w.Length == maxLength)
        .Distinct()
        .ToList();
    }
}
