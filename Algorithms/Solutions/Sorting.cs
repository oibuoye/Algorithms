using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class Sorting
    {
        public static int[] SelectionSorting(int[] inputArray)
        {
            int n = inputArray.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n -1; j++)
                {
                    int temp = inputArray[j];
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                    }
                }
            }

            return inputArray;
        }

        public static void SelSorting(int[] lst)
        {
            // get the length
            int n = lst.Length;
            for (int i = 0; i < n; i++)
            {
                int index = 0;
                int smallest = lst[i];
                for (int j = i; j < n; j++)
                {
                    if (lst[j] < smallest)
                    {
                        smallest = lst[j];
                        index = j;
                    }
                    int temp = lst[i];
                    lst[i] = smallest;
                    lst[index] = temp;
                }
            }
            Console.WriteLine(lst);
        }
    }
}
