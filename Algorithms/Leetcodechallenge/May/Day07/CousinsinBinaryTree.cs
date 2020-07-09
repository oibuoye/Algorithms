using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.May.Day07
{
    public class CousinsinBinaryTree
    {
        public static bool isCousins(TreeNode root, int x, int y)
        {
            return true;
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
        public static TreeNode CreateNewNode(int key)
        {
            TreeNode node = new TreeNode(key);
            node.value = key;
            node.left = node.right = null;
            return node;
        }
    }

}
