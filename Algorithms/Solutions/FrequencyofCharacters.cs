using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class FrequencyofCharacters
    {
        public static void Frequency(char[] chars)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<char, int> stringTracker = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                int value = 0;
                if (stringTracker.TryGetValue(chars[i], out value))
                {
                    stringTracker[chars[i]] = value + 1;
                }
                else
                {
                    stringTracker[chars[i]] = 1;
                }
            }

            foreach (var str in stringTracker)
            {
                sb.Append(str.Key.ToString() + str.Value);
            }
            string txt = sb.ToString();
        }
    }
}
