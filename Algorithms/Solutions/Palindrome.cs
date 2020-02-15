using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class Palindrome
    {
        /// <summary>
        /// This get string that is Palindrome in nature or that can be Palindrome by changing a character
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool GetPalindrome(string value)
        {
            int counter = 0;
            //Divide the length into two so that the array can be checked from both ends
            int stLength = value.Length / 2;

            for (int i = 0; i < stLength; i++)
            {
                //start checking from both ends of the array
                if (value[i] != value[(value.Length - (i + 1))])
                {
                    counter++;
                }
            }

            if (counter > 1)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// This get string that is Palindrome in nature
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool PalindromeString(string value)
        {
            int counter = 0;
            //Divide the length into two so that the array can be checked from both ends
            int stLength = value.Length / 2;

            for (int i = 0; i < stLength; i++)
            {
                //start checking from both ends of the array
                if (value[i] != value[(value.Length - (i + 1))])
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                return false;
            }

            return true;
        }

    }
}
