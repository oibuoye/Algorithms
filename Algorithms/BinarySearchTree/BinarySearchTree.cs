using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinarySearchTree
{
    public class BinarySearchTree
    {
        public static Node CreateNewNode(int? key)
        {
            Node node = new Node();
            node.value = key;
            node.left = node.right = null;
            return node;
        }
    }

    public class Node
    {
        public int? value;
        public Node left, right;
    }

}
