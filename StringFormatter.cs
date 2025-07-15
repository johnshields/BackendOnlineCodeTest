using System.Text;

namespace BackendOnlineCodeTest;

public static class StringFormatter
{
    // Simpler and more readable approach for small collections where performance impact is negligible by LINQ.
    public static string ToCommaSeparatedListLinq(string[] items)
    {
        if (items is null || items.Length == 0)
        {
            Console.WriteLine("Null or empty array was passed.");
            return string.Empty;
        }

        return string.Join(",", items.Select(i => $"'{i}'"));
    }
    
    // Optimal approach that uses manual iteration with StringBuilder to avoid LINQ allocation overhead.
    public static string ToCommaSeparatedListOptimal(string[] items)
    {
        if (items is null || items.Length == 0)
        {
            Console.WriteLine("Null or empty array was passed.");
            return string.Empty;
        }

        var stringBuilder = CommaSeparatedStringBuilder(items);

        return stringBuilder.ToString();
    }
    
    // Helper method that appends quoted items as a comma-separated list using StringBuilder.
    private static StringBuilder CommaSeparatedStringBuilder(string[] items)
    {
        var stringBuilder = new StringBuilder();

        foreach (var item in items)
        {
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Append(',');
            }

            stringBuilder.Append($"'{item}'");
        }

        return stringBuilder;
    }
}