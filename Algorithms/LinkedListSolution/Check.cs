using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class Check
    {
        //LinkedList examples
        internal class DNode
        {
            internal int data;
            internal DNode prev;
            internal DNode next;
            public DNode(int d)
            {
                data = d;
                prev = null;
                next = null;
            }
        }
        internal class DoubleLinkedList
        {
            internal DNode head;
        }
        private void InsertFrontData(DoubleLinkedList dlinkedList, int mydata)
        {
            DNode myNewNode = new DNode(mydata);
            myNewNode.next = dlinkedList.head;
            myNewNode.prev = null;
            if (dlinkedList.head != null)
            {
                dlinkedList.head.prev = myNewNode;
            }
            else
            {
                dlinkedList.head = myNewNode;
            }

        }
        private void InsertLastData(DoubleLinkedList dlinkedList, int mydata)
        {
            DNode mynode = new DNode(mydata);

            if (dlinkedList.head == null)
            {
                mynode.prev = null;
                dlinkedList.head = mynode;
                return;
            }

            DNode lastNode = GetLastNode(dlinkedList);
            lastNode.next = mynode;
            mynode.prev = lastNode;
        }
        private void InsertDataAfter(DNode previousNode, int mydata)
        {
            if (previousNode == null)
            {
                //This can't be null
                return;
            }

            DNode myNode = new DNode(mydata);
            myNode.next = previousNode.next;
            previousNode.next = myNode;
            myNode.prev = previousNode;

            if (myNode.next != null)
            {
                myNode.next.prev = myNode;
            }
        }
        internal DNode GetLastNode(DoubleLinkedList singleLink)
        {
            DNode temp = singleLink.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }
    }
}
