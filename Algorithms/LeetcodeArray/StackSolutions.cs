using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetcodeArray
{
    public static class StackSolutions
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if(!stack.Any())
                    {
                        return false;
                    }
                    else
                    {
                        char c = stack.Pop();
                        switch (c)
                        {
                            case '(':
                                if (s[i] != ')')
                                {
                                    return false;
                                }
                                break;
                            case '[':
                                if (s[i] != ']')
                                {
                                    return false;
                                }
                                break;
                            case '{':
                                if (s[i] != '}')
                                {
                                    return false;
                                }
                                break;
                            default:
                                return false;
                        }
                    }
                }
            }

            if (stack.Any())
            {
                return false;
            }
            return true;
        }

    }


}
