using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day06
{
    public class GroupAnagramsSolution
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> groups = new List<IList<string>>();
            Dictionary<string, List<string>> groupAnagrams = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] chars = strs[i].ToCharArray();
                Array.Sort(chars);
                string word = new string(chars);
                List<string> group = new List<string>();

                if (groupAnagrams.ContainsKey(word))
                {
                    group = groupAnagrams[word];
                    group.Add(strs[i]);
                    groupAnagrams[word] = group;
                }
                else
                {
                    group.Add(strs[i]);
                    groupAnagrams.Add(word, group);
                }
            }

            foreach(var items in groupAnagrams)
            {
                groups.Add(items.Value);
            }

            return groups;
        }

    }
}
