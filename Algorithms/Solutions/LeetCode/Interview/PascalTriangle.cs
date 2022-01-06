using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.LeetCode.Interview
{
    public class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> listList = new List<IList<int>>();
            List<int> newList = null;
            bool listExist = false;

            for(int i =1; i <= numRows; i++)
            {
                bool firstItemOnRow = true;
                newList = new List<int>();
                for (int j = 1; j <= i; j++)
                {
                    if (!listExist)
                    {
                        newList.Add(1);
                        listExist = true;
                    }
                    else
                    {
                        if (firstItemOnRow)
                        {
                            newList.Add(1);
                            firstItemOnRow = false;
                        }
                        else
                        {
                            int subListNo = listList.Count;
                            IList<int> lastList = listList[subListNo - 1];
                            if (lastList.Count == 1)
                            {
                                newList.Add(1);
                            }
                            else
                            {
                                if(j != i)
                                {
                                    newList.Add(lastList[j-2] + lastList[j-1]);
                                }
                                else
                                {
                                    newList.Add(1);
                                }
                            }
                        }
                    }
                }
                listList.Add(newList);
            }

            return listList;
        }
    }
}
