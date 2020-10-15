using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcodechallenge.Day08
{
    public class MiddleNodeSolution
    {
        public ListNode CountElements(ListNode head)
        {
            float totalItem = new SingleLinkedList().CountListNodeItem(head);
            if(totalItem%2 == 0)
            {
                totalItem += 1;
            }
            int middleNodePos = (int)Math.Ceiling((totalItem / 2));
            ListNode listNode = new SingleLinkedList().GetMiddleList(head, middleNodePos);
            return listNode;
        }
    }

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
     }

    public class SingleLinkedList
    {
        public ListNode head;
        public SingleLinkedList()
        {
            head = null;
        }

        public int CountListNodeItem(ListNode listNode)
        {
            int counter = 0;
            while(listNode != null)
            {
                counter++;
                listNode = listNode.next;
            }
            return counter;
        }

        public ListNode AddToEnd(ListNode listNode, int value)
        {
            ListNode node = new ListNode(value);
            if (listNode == null)
            {
                listNode = node;
                return listNode;
            }

            ListNode lastNode = GetLastNode(listNode);
            lastNode.next = node;

            return listNode;
        }

        public ListNode GetLastNode(ListNode listNode)
        {
            while (listNode.next != null)
            {
                listNode = listNode.next;
            }
            return listNode;
        }

        public ListNode GetMiddleList(ListNode listNode, int middle)
        {
            SingleLinkedList node = new SingleLinkedList();
            int counter = 1;
            while (listNode != null)
            {
                if(counter >= middle)
                {
                    node.head = AddToEnd(node.head, listNode.val);
                }
                counter++;
                listNode = listNode.next;
            }
            return node.head;
        }

    }
}
