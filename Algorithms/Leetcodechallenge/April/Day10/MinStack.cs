using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day10
{
    public class MinStack
    {
        Stack<int> stack;
        public MinStack()
        {
            stack = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
           return stack.Peek();
        }

        public int GetMin()
        {
           return stack.Min();
        }
    }

}
