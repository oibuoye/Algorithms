using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.September.Day10
{
    public class BullsandCows
    {
        public static string GetHint(string secret, string guess)
        {
            StringBuilder sb = new StringBuilder();
            int bullCounter = 0;
            int cowCounter = 0;
            ArrayList arrOfElements = new ArrayList();
            ArrayList secretElements = new ArrayList();
            for (int i =0; i < secret.Length; i++)
            {
                secretElements.Add(secret[i].ToString());
            }

            for (int i = 0; i < secret.Length; i++)
            {
                if (secretElements[i].ToString() == guess[i].ToString())
                {
                    bullCounter++;
                    int ind = secret.IndexOf(guess[i]);
                    secretElements[ind] = -1;
                }
                else if (secretElements.Contains(guess[i].ToString()))
                {
                    cowCounter++;
                    int ind = secret.IndexOf(guess[i]);
                    secretElements[ind] = -1;
                }
            }
            sb.Append(bullCounter + "A");
            sb.Append(cowCounter + "B");
            return sb.ToString();
        }
    }
}
