using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class LinkedList
    {
        //LinkedList examples
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        //Instantiate the linkedlist
        internal class SingleLinkedList
        {
            internal Node head;
        }
        private void InsertFrontData(SingleLinkedList singleLink, int mydata)
        {
            Node myNewNode = new Node(mydata);
            myNewNode.next = singleLink.head;
            singleLink.head = myNewNode;
        }
        private void InsertLastData(SingleLinkedList singleLink, int mydata)
        {
            Node myNode = new Node(mydata);
            if (singleLink.head == null)
            {
                singleLink.head = myNode;
                return;
            }

            Node lastNode = GetLastNode(singleLink);
            lastNode.next = myNode;

        }
        private void InsertDataAfter(Node previousNode, int mydata)
        {
            if (previousNode == null)
            {
                //This can't be null
                return;
            }

            Node myNode = new Node(mydata);
            myNode.next = previousNode.next;
            previousNode.next = myNode;
        }
        private void ReverseLinked(SingleLinkedList singleLink)
        {
            Node temp = null;
            Node prev = null;
            Node Current = singleLink.head;

            while (Current != null)
            {
                temp = Current.next;
                Current.next = prev;
                prev = Current;
                Current = temp;
            }

            singleLink.head = prev;
        }
        internal Node GetLastNode(SingleLinkedList singleLink)
        {
            Node temp = singleLink.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }
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
