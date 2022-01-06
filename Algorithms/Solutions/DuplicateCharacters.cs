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

        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    keyValuePairs[nums[i]] = nums[i];
                }
            }
            return false;
        }

        /// <summary>
        /// Not efficient enough. The time exceeded the expected run time
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string LongestDupSubstringSolution1(string s)
        {
            Dictionary<int, string> keeper = new Dictionary<int, string>() { { 0, "" } };
            Dictionary<string, string> keyTracker = new Dictionary<string, string>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    string subString = s.Substring(i, j - i);
                    if (keyTracker.ContainsKey(subString))
                    {
                        if (subString.Length > keeper[0].Length)
                        {
                            keeper[0] = subString;
                        }
                    }
                    else
                    {
                        keyTracker[subString] = subString;
                    }
                    Console.WriteLine($"Substring is {subString}");
                }
            }

            return keeper[0];
        }

        public static string LongestDupSubstringSolution2(string s)
        {
            // A prime number 
            int q = 11;
            Dictionary<int, string> keeper = new Dictionary<int, string>() { { 0, "" } };
            Dictionary<string, string> keyTracker = new Dictionary<string, string>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    string subString = s.Substring(i, j - i);
                    if (!keyTracker.ContainsKey(subString))
                    {
                        keyTracker[subString] = subString;
                        if (RKASearch(subString, s, q))
                        {
                            if (subString.Length > keeper[0].Length)
                            {
                                keeper[0] = subString;
                            }
                        }
                    }
                }
            }
            return keeper[0];
        }


        public static int SearchPattern(string txt, string pat)
        {
            int M = pat.Length;
            int N = txt.Length;
            int counter = 0;

            /* A loop to slide pat one by one */
            for (int i = 0; i <= N - M; i++)
            {
                int j;

                /* For current index i, check for pattern
                match */
                for (j = 0; j < M; j++)
                {
                    if (txt[i + j] != pat[j])
                    {
                        break;
                    }
                }

                // if pat[0...M-1] = txt[i, i+1, ...i+M-1]
                if (j == M)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static bool RKASearch(string pat, string txt, int q)
        {
            // This represents the number of characters in the input alphabet 
            int counter = 0;
            int d = 256;
            int M = pat.Length;
            int N = txt.Length;
            int i, j;
            int p = 0; // hash value for pattern 
            int t = 0; // hash value for txt 
            int h = 1;

            // The value of h would be "pow(d, M-1)%q" 
            for (i = 0; i < M - 1; i++)
            {
                h = (h * d) % q;
            }

            // Calculate the hash value of pattern and first 
            for (i = 0; i < M; i++)
            {
                p = (d * p + pat[i]) % q;
                t = (d * t + txt[i]) % q;
            }

            // Slide the pattern over text one by one 
            for (i = 0; i <= N - M; i++)
            {
                // Check the hash values of current window of text 
                // and pattern. If the hash values match then only 
                // check for characters on by one 
                if (p == t)
                {
                    /* Check for characters one by one */
                    for (j = 0; j < M; j++)
                    {
                        if (txt[i + j] != pat[j])
                        {
                            break;
                        }
                    }

                    // if p == t and pat[0...M-1] = txt[i, i+1, ...i+M-1] 
                    if (j == M)
                    {
                        counter++;
                        if(counter > 1)
                        {
                            return true;
                        }
                    }
                }

                // Calculate hash value for next window of text: Remove 
                // leading digit, add trailing digit 
                if (i < N - M)
                {
                    t = (d * (t - txt[i] * h) + txt[i + M]) % q;

                    // We might get negative value of t, converting it 
                    // to positive 
                    if (t < 0)
                    {
                        t = (t + q);
                    }
                }
            }
            return false;
        }

    }
}
