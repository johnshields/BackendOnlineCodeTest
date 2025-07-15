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
 */
public static class StringFormatter
{
    //Code to improve
    public static string ToCommaSeparatedList(string[] items, string quote)
    {
        var builder = new StringBuilder($"{quote}{items[0]}{quote}");

        for (var i = 1; i < items.Length; i++)
        {
            builder.Append($", {quote}{items[i]}{quote}");
        }

        return builder.ToString();
    }
}