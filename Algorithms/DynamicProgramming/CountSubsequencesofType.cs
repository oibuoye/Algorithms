using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class CountSubsequencesofType
    {
        //Given a string s, the task is to count number of subsequences of the form aibjck, where i >= 1, j >=1 and k >= 1.

        //Note: Two subsequences are considered different if the set of array indexes picked for the 2 subsequences are different.

        public static void GetSubsequentType(string s, int testCase)
        {
            int minLength = 3;
            int counter = 0;
            int length = s.Length;
            Dictionary<string, int> characters = new Dictionary<string, int>();
            Dictionary<string, string> indexes = new Dictionary<string, string>();
            characters.Add("a", 1);
            characters.Add("b", 2);
            characters.Add("c", 3);

            for(int i = 1; i < length; i++)
            {

            }

        }


    }
}
