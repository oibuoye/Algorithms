using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day20
{
    public class BinarySearchTreefromPreorderTraversal
    {
        public static TreeNode BstFromPreorder(int[] preorder)
        {
            BST node = new BST();
            for(int i =0; i < preorder.Length; i++)
            {
                node.root = node.Insert(node.root, preorder[i]);
            }

            return node.root;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left, right;
        public TreeNode (int x)
        {
            val = x;
        }
    }

    public class BST
    {
        public TreeNode root;
        public BST()
        {
            root = null;
        }

        public TreeNode Insert(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else if (value < root.val)
            {
                root.left = Insert(root.left, value);
            }
            else
            {
                root.right = Insert(root.right, value);
            }
            return root;
        }

    }
}
