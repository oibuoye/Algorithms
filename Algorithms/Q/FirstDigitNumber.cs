using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms.Q
{
    public class FirstDigitNumber
    {
        public static char GetFirstNumber(string inputString)
        {
            //string input = "q2q-q";
            //int val = FirstDigitNumber.GetFirstNumber(input);
            //Console.WriteLine(val);


            Regex r = new Regex(@"\d");

            Match match = r.Match(inputString);

            return Char.Parse(match.Value);
        }

        public static void LearmRegex()
        {
            //FirstDigitNumber.LearmRegex();



            //Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");


            ////class Regex Repesents an immutable regular expression.    

            //string[] str = { "+291-9678967101", "9678967101", "++91-9678-967101", "+91-96789-67101", "+919678967101" };
            ////Input strings for Match valid mobile number.    

            //foreach (string s in str)
            //{
            //    Console.WriteLine("{0} {1} a valid mobile number.", s, r.IsMatch(s) ? "is" : "is not");
            //    //The IsMatch method is used to validate a string or     
            //    //to ensure that a string conforms to a particular pattern.    
            //}

            string[] str1 = { "op ibuoye", "opeyemi ibuoye" };

            Regex r1 = new Regex(@"^[A-Za-z ]++,[A-Za-z ]++$");
            foreach (string s in str1)
            {
                Console.WriteLine("{0} {1} a valid name.", s, r1.IsMatch(s) ? "is" : "is not");
            }


            Console.ReadLine();
        }

    }
}
