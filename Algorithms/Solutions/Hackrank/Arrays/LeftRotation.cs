using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.Hackrank.Arrays
{
    public class LeftRotation
    {
        public static List<int> rotLeft(List<int> a, int d)
        {
            for(int i =0; i<d; i++)
            {
                int temp = a[0];

                for (int k =1; k< a.Count; k++)
                {
                    a[k - 1] = a[k];
                }
                a[a.Count - 1] = temp;
            }
            return a;
        }

        public static List<int> OprotLeft(List<int> a, int d)
        {
            List<int> arrayHolder = new List<int>();
            bool isMovementStartingFromBack = a.Count > d ? true : false;
            int startingPoint = 0;
            if (isMovementStartingFromBack)
            {
                startingPoint = d;
                for (int i = startingPoint; i < a.Count; i++)
                {
                    Console.WriteLine($"{a[i]}");
                    arrayHolder.Add(a[i]);
                }

                //Add the remaining part
                for (int k = 0; k < startingPoint; k++)
                {
                    Console.WriteLine($"{a[k]}");
                    arrayHolder.Add(a[k]);
                }
            }
            else
            {
                startingPoint = d - a.Count;
                for (int i = startingPoint; i < a.Count; i++)
                {
                    Console.WriteLine($"{a[i]}");
                    arrayHolder.Add(a[i]);
                }

                //Add the remaining part
                for (int k = 0; k < startingPoint; k++)
                {
                    Console.WriteLine($"{a[k]}");
                    arrayHolder.Add(a[k]);
                }
            }

            return arrayHolder;
        }

    }
}
