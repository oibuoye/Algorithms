using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day14
{
    public class PerformStringShifts
    {
        public static string StringShift(string s, int[,] shift)
        {
            Char[] chars = s.ToArray();
            int length = shift.Length / 2;

            for (int i = 0; i < length; i++)
            {
                int direction = shift[i, 0];
                int shiftTimes = shift[i, 1];

                if(direction == 0)
                {
                    chars = ShiftLeft(shiftTimes, chars);
                }
                else
                {
                    chars = ShiftRight(shiftTimes, chars);
                }
            }
            return new string(chars);
        }

        public static char[] ShiftLeft(int shiftTimes, char[] chars)
        {
            for (int i = 0; i < shiftTimes; i++)
            {
                var firstChar = chars[0];
                for(int j=1; j<chars.Length; j++)
                {
                    chars[j - 1] = chars[j];
                }
                chars[chars.Length - 1] = firstChar;
            }
            return chars;
        }

        public static char[] ShiftRight(int shiftTimes, char[] chars)
        {
            for (int i = 0; i < shiftTimes; i++)
            {
                var lastChar = chars[chars.Length - 1];
                for (int j = chars.Length - 2; j >= 0; j--)
                {
                    chars[j + 1] = chars[j];
                }
                chars[0] = lastChar;
            }
            return chars;
        }

        public static bool CheckValidString(string s)
        {
            if (s.Length == 0)
                return true;

            int openBracCounter = 0;
            int closeBracCounter = 0;
            int asterikCounter = 0;

            for(int i =0; i < s.Length; i++)
            {
                if (s[i].ToString() == "(")
                {
                    openBracCounter++;
                }
                else if (s[i].ToString() == ")")
                {
                    if (openBracCounter > 0)
                    {
                        openBracCounter--;
                    }
                    else
                    {
                        closeBracCounter++;
                    }
                }
                else if (s[i].ToString() == "*")
                {
                    asterikCounter++;
                }
            }

            int max = closeBracCounter > openBracCounter ? closeBracCounter : openBracCounter;

            if(max > asterikCounter)
            {
                return false;
            }
            return true;
        }
    }
}
