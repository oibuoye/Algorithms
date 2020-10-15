using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.May.Day01
{
    public class FirstBadVersionSolution : VersionControl
    {
        public static int FirstBadVersion(int n)
        {
            double min = 0;
            double max = n;
            int firstBadVersion = 0;
            bool found = false;

            do
            {
                double num = (min + max) / 2;
                int middle = (int)Math.Ceiling(num);

                if (IsBadVersion(middle))
                {
                    max = middle;
                    firstBadVersion = middle;
                    for (int i = (int)max; i >= min; i--)
                    {
                        if (IsBadVersion(i))
                        {
                            firstBadVersion = firstBadVersion <= i ? firstBadVersion : i;
                            found = true;
                        }
                    }
                }
                else
                {
                    min = middle;
                }

            } while (found == false);

            return firstBadVersion;
        }
    }

    public class VersionControl
    {
        public static bool IsBadVersion(int version)
        {
            Dictionary<int, bool> list = new Dictionary<int, bool>();
            list.Add(1, false);
            list.Add(2, false);
            list.Add(3, false);
            list.Add(4, false);
            list.Add(5, true);

            return list[version];
        }
    }
}
