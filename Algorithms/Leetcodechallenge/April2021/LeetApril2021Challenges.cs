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

            for(int i=0; i < array.Count/2; i++)
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
            if(node == null)
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
            Dictionary<char, string> keyPadLetters = new Dictionary<char, string> { { '2', "abc"}, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" }, };

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
                        string letters = keyPadLetters[digits[0]];
                        response.Add(letters[i].ToString());
                    }
                    break;
            }

            return response;
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
}
