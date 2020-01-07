using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class PossibleCharacter
    {
        //string word = "KS";
        //List<string> ret = PossibleCharacter.Possibilities(word);


        /// <summary>
        /// Morse Code is delivered in a series signals which are referred to as dashes (-) or dots (.). To keep things simple for the purposes of this challenge we'll only decode letters with a maximum length of three signals.
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static List<string> Possibilities(string word)
        {
            List<string> possibleCharacter = new List<string>();
            Dictionary<string, string> morseCodeDic = new Dictionary<string, string>()
            {
                {".-","A"}, {"-...","B" }, { "-.-.","C" }, { "-..", "D"}, {".","E" },
                {"..-.","F" }, {"--.","G" }, {"....","H" }, {"..","I" }, {".---","J"},
                {"-.-","K" }, {".-..","L" }, {"--","M" }, {"-.","N" }, {"---","O" }, {".--.","P" },
                {"--.-","Q" }, {".-.","R" }, {"...","S" }, {"-","T" }, {"..-","U" }, {"...-","V" }, {".--","W" },
                {"-..-","X"}, {"-.--","Y"}, {"--..","Z"},{"1",".----"}, {"2","..---"}, {"3","...--"},
                {"4","....-"}, {"5","....."}, {"6","-...."}, {"7","--..."}, {"8","---.."}, {"9","----."},
                {"0","-----"}, {", ","--..--"}, {".",".-.-.-"}, {"?","..--.."}, {"/","-..-."}, {"-","-....-"},
                {"(","-.--."}, {")","-.--.-"}
            };

            if (word.Contains("?"))
            {
                string firstReplacement = word;
                possibleCharacter.Add(morseCodeDic[firstReplacement.Replace("?", ".")]);

                string secondReplacement = word;
                possibleCharacter.Add(morseCodeDic[secondReplacement.Replace("?", "-")]);
            }
            else
            {
                possibleCharacter.Add(morseCodeDic[word.ToString()]);
            }

            return possibleCharacter;
        }

    }
}
