using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.April2021
{
    public class LeetApril2021Challenges
    {
        public ListNode node;
        //Day 1
        #region Day 1 Solution - Given the head of a singly linked list, return true if it is a palindrome.
        public bool IsPalindrome(ListNode head)
        {
            ArrayList array = new ArrayList();
            while (head != null)
            {
                array.Add(head.val);
                head = head.next;
            }

            for (int i = 0; i < array.Count / 2; i++)
            {
                int lastCheck = (array.Count - 1 - i);
                if ((int)array[i] != (int)array[lastCheck])
                {
                    return false;
                }
            }
            return true;
        }

        public void AddToEnd(int val)
        {
            if (node == null)
            {
                node = new ListNode(val);
            }
            else
            {
                ListNode newNode = new ListNode(val);
                ListNode lastNode = GetLastNode(node);
                lastNode.next = newNode;
            }
        }

        public ListNode GetLastNode(ListNode head)
        {
            while (head.next != null)
            {
                head = head.next;
            }
            return head;
        }
        #endregion

        //Day 6
        #region Day 6 Solution - Given the head of a singly linked list, return true if it is a palindrome.



        #endregion


        //Day 8
        #region Day 8 Solution - Letter Combinations of a Phone Number

        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, string> keyPadLetters = new Dictionary<char, string> { { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" }, };

            if (string.IsNullOrEmpty(digits))
            {
                return new List<string> { };
            }

            List<string> response = new List<string>();
            switch (digits.Length)
            {
                case 1:
                    string letters = keyPadLetters[digits[0]];
                    for (int i = letters.Length; i >= 0; i--)
                    {
                        response.Add(letters[i].ToString());
                    }
                    break;
                case 2:
                    for (int i = digits.Length; i >= 0; i--)
                    {
                        //string letters = keyPadLetters[digits[0]];
                        //response.Add(letters[i].ToString());
                    }
                    break;
            }

            return response;
        }
        #endregion

        //Day 11
        #region Day 11 Solution - Given the root of a binary tree, return the sum of values of its deepest leaves.

        public int DeepestLeavesSum(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            int lH = GetDeepestLeavesValue(root.left);
            int rH = GetDeepestLeavesValue(root.right);

            return GetDeepestLeavesValue(root.left) + ;
            //int rH = DeepestLeavesSum(root.right);
        }

        public int GetDeepestLeavesValue(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int lH = DeepestLeavesSum(root.left);
            int rH = DeepestLeavesSum(root.right);

            return root.val;
            //int rH = DeepestLeavesSum(root.right);
        }

        public static TreeNode CreateNewNode(int key)
        {
            TreeNode node = new TreeNode(key);
            node.val = key;
            node.left = node.right = null;
            return node;
        }

        #endregion
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0)
        {
            this.val = val;
            this.next = null;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
