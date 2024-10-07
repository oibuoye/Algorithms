using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetcodeArray
{
    public class LinkedListSolutions
    {
        /// <summary>
        /// Check if linkedlist has a cycle
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            ListNode fast = head.next;
            ListNode slow = head;

            while(fast != null && fast.next != null && slow != null)
            {
                if(fast == slow)
                {
                    return true;
                }
                fast = fast.next.next;
                slow = slow.next;
            }
            return false;
        }

        public ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode result = new ListNode(0);
            ListNode prev = result;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }
            if (l1 != null)
            {
                prev.next = l1;
            }
            if (l2 != null)
            {
                prev.next = l2;
            }
            return result.next;
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode(0);
            ListNode prev = result;
            while (list1 != null || list2 != null)
            {
                if(list1 != null && list2 != null)
                {
                    if(list1.val < list2.val)
                    {
                        prev.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        prev.next = list2;
                        list2 = list2.next;
                    }
                }
                else if (list1 != null)
                {
                    prev.next = list1;
                    list1 = list1.next;
                }
                else if (list2 != null)
                {
                    prev.next = list2;
                    list2 = list2.next;
                }
                prev = prev.next;
            }
            return result.next;
        }

        public ListNode RotateRight(ListNode head, int k)
        {
            if(head == null || k == 0)
            {
                return head;
            }

            ArrayList arr = new ArrayList();
            while (head != null)
            {
                arr.Add(head.val);
                head = head.next;
            }

            ListNode result = new ListNode(0);
            ListNode prev = result;
            int arrCount = arr.Count;
            int tracker = 0;
            ListNode temp = null;
            if (arrCount > k)
            {
                for(int i = arrCount -1; i >= 0; i--)
                {
                    if(tracker == k)
                    {
                        break;
                    }
                    temp = new ListNode((int)arr[i]);
                    prev.next = temp;
                    prev = prev.next;
                    tracker++;
                }

                for (int i = 0; i < arrCount - tracker; i++)
                {
                    prev.next = new ListNode((int)arr[i]);
                    prev = prev.next;
                }
            }
            else
            {
                int rotateTimes = arrCount % k;
                for (int i = arrCount - 1; i >= 0; i--)
                {
                    if (tracker == rotateTimes)
                    {
                        break;
                    }

                    prev.next = new ListNode((int)arr[i]);
                    prev = prev.next;
                    tracker++;
                }

                for (int i = 0; i < arrCount - tracker; i++)
                {
                    prev.next = new ListNode((int)arr[i]);
                    prev = prev.next;
                }
            }

            return result.next;
        }

        public ListNode RotateRight2(ListNode head, int k)
        {
            if (head == null || k == 0)
            {
                return head;
            }

            ListNode result = null;
            for (int i = 0; i < k; i++)
            {
                result = new ListNode(0);
                ListNode prev = result;
                ListNode temp = null;
                while (head != null)
                {
                    if (head.next != null)
                    {
                        prev.next = head;
                        prev = prev.next;
                    }
                    else
                    {
                        temp = new ListNode(head.val);
                        prev.next = null;
                        prev = prev.next;
                    }
                    head = head.next;
                }

                temp.next = result.next;
                result = temp;
                head = result;
            }
            return result;
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode newList = null;
            ArrayList list = new ArrayList();
            ArrayList delayList = new ArrayList();
            int counter = 0;

            while(head != null)
            {
                counter++;
                list.Add(head.val);

                if (counter > n)
                {
                    delayList.Add(list[counter - (n + 1)]);
                }
                head = head.next;
            }

            for (int i = (counter - n) + 1; i < list.Count; i++)
            {
                delayList.Add(list[i]);
            }


            for (int i = 0; i < delayList.Count; i++)
            {
                if(newList == null)
                {
                    newList = new ListNode((int)delayList[i]);
                }
                else
                {
                    ListNode current = newList;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = new ListNode((int)delayList[i]);
                }
            }

            return newList;
        }

        public int GetDecimalValue(ListNode head)
        {
            int decimalNum = 0;
            while(head != null)
            {
                decimalNum = (decimalNum*2) + head.val;
                head = head.next;
            }

            return decimalNum;
        }

        public ListNode ReverseList(ListNode head)
        {
            if(head == null)
            {
                return head;
            }

            ListNode newNode = new ListNode(head.val);

            while(head.next != null)
            {
                ListNode temp = new ListNode(head.next.val);
                temp.next = newNode;
                newNode = temp;
                head = head.next;
            }

            return newNode;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
