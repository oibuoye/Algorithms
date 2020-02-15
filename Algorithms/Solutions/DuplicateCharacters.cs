using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class DuplicateCharacters
    {
        public static string RemoveDuplicateChars(string key)
        {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                int indexofinitil = table.IndexOf(value);
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    result += value;
                }
                table += value;
            }
            return result;
        }

    }
}
