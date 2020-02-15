using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class Anagram
    {
        public static string CheckAnagram(string firstword, string secondword)
        {
            string response = string.Empty;
            //Add optional validation of input words if needed.  
            //.....  

            //step 1  
            char[] char1 = firstword.ToLower().ToCharArray();
            char[] char2 = secondword.ToLower().ToCharArray();

            //Step 2  
            Array.Sort(char1);
            Array.Sort(char2);

            //Step 3  
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            //Step 4  
            //ToLower allows to compare the words in same case, in this case, lower case.  
            //ToUpper will also do exact same thing in this context  
            if (NewWord1 == NewWord2)
            {
                response = string.Format("Yes! Words \"{0}\" and \"{1}\" are Anagrams", firstword, secondword);
            }
            else
            {
                response = string.Format("No! Words \"{0}\" and \"{1}\" are not Anagrams", firstword, secondword);
            }

            return response;
        }
    }
}
