using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day11
{
    public class DiameterofBinaryTree
    {
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            //To get the path, less one from the value of height of the node
            int hHeightLeft = BinarySearchTree.GetHighestHeight(root.left);
            int hHeightRight = BinarySearchTree.GetHighestHeight(root.right);
            return hHeightLeft + hHeightRight;
        }
    }

    public class TreeNode
    {
        public int? value;
        public TreeNode left, right;

        public TreeNode(int val)
        {
            value = val;
        }
    }

    public class BinarySearchTree
    {
        public static int GetHighestHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int heightL = GetHighestHeight(root.left);
            int heightR = GetHighestHeight(root.right);
            if (heightR > heightL)
                return (heightR + 1);
            else return (heightL + 1);
        }

        public static TreeNode CreateNewNode(int key)
        {
            TreeNode node = new TreeNode(key);
            node.value = key;
            node.left = node.right = null;
            return node;
        }
    }

}
