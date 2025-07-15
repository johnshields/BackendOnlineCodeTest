using System.Text;

namespace BackendOnlineCodeTest;

/*
Improve a block of code as you see fit in C#.
You may make any improvements you see fit, for example:
  - Cleaning up code
  - Removing redundancy
  - Refactoring / simplifying
  - Fixing typos
  - Any other light-weight optimisation
*/

/*
 * Changes:
 * Added a Program class for testing outputs.
 * Removed {} from namespace to update to C# 10 standards.
 * Fixed typo in ToCommaSepatatedList to ToCommaSeparatedList.
 * Made class static to prevent instantiation.
 * Simplified types with "var".
 * Renamed qry to builder for readability.
 * Switched to string interpolation instead of string.Format.
 * Removed redundant if statement.
 * Added null/empty guard clause for param.
 * Added nullifier (?) to string[] param.
 * Converted for loop to foreach to improve readability.
 */
public static class StringFormatter
{
    //Code to improve
    public static string ToCommaSeparatedList(string[]? items, string quote)
    {
        if (items is null || items.Length == 0)
        {
            Console.WriteLine("Null or empty array was passed.");
            return string.Empty;
        }

        var builder = new StringBuilder($"{quote}{items[0]}{quote}");

        // skip first item as it is already appended above,
        // and the rest follow with a comma and quotes.
        foreach (var item in items.Skip(1))
            builder.Append($", {quote}{item}{quote}");

        return builder.ToString();
    }
}