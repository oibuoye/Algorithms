using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinarySearchTree.Solutions
{
    public class LeftSkewedTree
    {
        public Node GetLeftSkewedTree()
        {
            Node root = BinarySearchTree.CreateNewNode(1);
            root.left = BinarySearchTree.CreateNewNode(2);
            root.left.left = BinarySearchTree.CreateNewNode(3);

            return root;
        }
    }
}
