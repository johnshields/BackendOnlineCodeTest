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
 */
public static class StringFormatter
{
    //Code to improve
    public static string ToCommaSeparatedList(string[] items, string quote)
    {
        var builder = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

        if (items.Length > 1)
        {
            for (var i = 1; i < items.Length; i++)
            {
                builder.Append(string.Format(", {0}{1}{0}", quote, items[i]));
            }
        }

        return builder.ToString();
    }
}