using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class CatsandMouse
    {
        public static string catAndMouse(int x, int y, int z)
        {
            int difA = z > x ? z - x : x - z;
            int difB = z > y ? z - y : y - z;

            if(difA < difB)
            {
                return "Cat A";
            }else if(difB < difA)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }
    }
}
