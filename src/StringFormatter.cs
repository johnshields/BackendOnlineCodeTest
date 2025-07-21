using System.Text;

namespace BackendOnlineCodeTest;

public static class StringFormatter
{
    public static string ToCommaSeparatedList(string[] items)
    {
        if (items is null || items.Length == 0)
        {
            Console.WriteLine("Null or empty array was passed.");
            return string.Empty;
        }

        var stringBuilder = CommaSeparatedStringBuilder(items);

        return stringBuilder.ToString();
    }
    
    private static StringBuilder CommaSeparatedStringBuilder(string[] items)
    {
        var stringBuilder = new StringBuilder();

        foreach (var item in items)
        {
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Append(',');
            }

            stringBuilder.Append($"\"{item}\"");
        }

        return stringBuilder;
    }
}