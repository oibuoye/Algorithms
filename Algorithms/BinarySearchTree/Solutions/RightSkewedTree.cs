using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinarySearchTree.Solutions
{
    public class RightSkewedTree
    {
        public Node GetRightSkewedTree()
        {
            Node root = BinarySearchTree.CreateNewNode(1);
            root.right = BinarySearchTree.CreateNewNode(2);
            root.right.right = BinarySearchTree.CreateNewNode(3);

            return root;
        }
    }
}
