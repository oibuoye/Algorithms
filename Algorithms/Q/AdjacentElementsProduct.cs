using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Q
{
    public class AdjacentElementsProduct
    {
        public static int Product(int[] inputArray)
        {

            //1st solution
            int product = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int newProduct = inputArray[i] * inputArray[i + 1];
                if (i == 0)
                {
                    product = newProduct;
                }
                else
                {
                    if (newProduct > product)
                    {
                        product = newProduct;
                    }
                }
            }

            //2nd solution
            int result = inputArray.Select((i, j) => j > 0 ? i * inputArray[j - 1] : int.MinValue).Max();

            //3rd solution
            int num = inputArray.Zip(inputArray.Skip(1), (a, b) => a * b).Max();

            return 1;
        }

    }
}
