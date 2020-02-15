using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinarySearchTree.Solutions
{
    public class TreeOperations
    {
        public Node Insert(Node root, int value)
        {
            if(root == null)
            {
                root = new Node();
                root.value = value;
            }
            else if( value < root.value)
            {
                root.left = Insert(root.left, value);
            }
            else
            {
                root.right = Insert(root.right, value);
            }

            return root;
        }

        public void Tranverse(Node root)
        {
            if (root == null)
                return;

            Tranverse(root.left);
            Tranverse(root.right);
        }
    }
}
