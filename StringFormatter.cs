﻿using System.Text;

namespace BackendOnlineCodeTest
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public static class StringFormatter
    {

        //Code to improve
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            StringBuilder qry = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

            if (items.Length > 1)
            {
                for (int i = 1; i < items.Length; i++)
                {
                    qry.Append(string.Format(", {0}{1}{0}", quote, items[i]));
                }
            }

            return qry.ToString();
        }
    }
}
