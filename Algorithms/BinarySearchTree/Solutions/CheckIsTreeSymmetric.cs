using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinarySearchTree.Solutions
{
    public class CheckIsTreeSymmetric
    {
        public static bool IsTreeSymmetric(Node root)
        {
            if(root == null)
            {
                return true;
            }

            return IsMirror(root.left, root.right);
        }
        public static bool IsMirror(Node node1, Node node2)
        {
            if(node1 == null && node2 == null)
            {
                return true;
            }

            if(node1 != null && node2 != null && node1.value == node2.value)
            {
                return IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
            }

            return false;
        }

    }


    public class CheckIsSameTree
    {
        public static bool IsSameTree(Node p, Node q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p != null && q != null && p.value == q.value)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }

            return false;
        }

    }
}
