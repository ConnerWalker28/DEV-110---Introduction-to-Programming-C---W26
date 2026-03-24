using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class FileLoader
{
    public static List<(string FileName, string Content)> LoadFiles(string folderPath)
    {
        return Directory.GetFiles(folderPath, "*.txt")
            .Where(file => !file.EndsWith("_processed.txt", System.StringComparison.OrdinalIgnoreCase)
                           && !file.EndsWith("manual_output.txt", System.StringComparison.OrdinalIgnoreCase))
            .Select(file => (
                FileName: Path.GetFileName(file),
                Content: File.ReadAllText(file))).ToList();
    }
}
