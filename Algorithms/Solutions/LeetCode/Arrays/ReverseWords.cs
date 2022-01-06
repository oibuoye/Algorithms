using System.Text;

namespace Algorithms.Solutions.LeetCode.Arrays
{
    public class ReverseWords
    {
        public static string TryReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            var strSplit = s.Trim().Split(' ');
            for (int i = strSplit.Length - 1; i >= 0; i--)
            {
                if(strSplit[i] != "")
                {
                    sb.Append(strSplit[i].Trim() + " ");
                }
            }
            return sb.ToString().Trim();
        }
    }
}
