using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions.LeetCode.BS
{
    public class ConvertSortedArraytoBinarySearchTree
    {
        public J27TreeNode SortedArrayToBST(int[] nums)
        {
            J27TreeNode treeNode = new J27TreeNode(nums[0]);
            for (int i =1; i < nums.Length; i++)
            {
                InsertNode(treeNode, nums[i]);
            }

            return treeNode;
        }

        private J27TreeNode InsertNode(J27TreeNode node, int value)
        {
            if(value < node.val)
            {
                node.left = InsertNode(node.left, value);
            }else
            {
                node.right = InsertNode(node.right, value);
            }

            return node;
        }
    }

    public class J27TreeNode
    {
        public int val;
        public J27TreeNode left;
        public J27TreeNode right;
        public J27TreeNode(int val = 0, J27TreeNode left = null, J27TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
