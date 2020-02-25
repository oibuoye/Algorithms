using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class StringCompression
    {
        public static int Compress(char[] chars)
        {
            int lengthCount = 0;
            char[] temp = new char[chars.Length];
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

            foreach(var str in stringTracker)
            {
                lengthCount += str.Value > 1 ? str.Value.ToString().Length + 1 : 1;
            }
            return lengthCount;
        }
    }
}
