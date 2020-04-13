using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms.LinkedList.LinkedList;

namespace Algorithms.LinkedList.Solutions
{
    public static class AddTwoNumbers
    {
        public static Node Add(Node node1, Node node2)
        {
            SingleLinkedList singleLinkedOne = new SingleLinkedList();
            string firstNode = singleLinkedOne.Transversal(node1);
            SingleLinkedList singleLinkedTwo = new SingleLinkedList();
            string secondNode = singleLinkedTwo.Transversal(node2);
            return GetNodeSummation(firstNode, secondNode);
        }

        public static Node GetNodeSummation(string value1, string value2)
        {
            string string1 = new string(value1.ToCharArray());
            string string2 = new string(value2.ToCharArray());

            int length = string1.Length > string2.Length ? string1.Length : string2.Length;
            int reminder = 0;

            SingleLinkedList newNode = new SingleLinkedList();
            for (int i = 0; i < length; i++)
            {
                int node1Value = 0;
                int node2Value = 0;
                
                if(i < string1.Length)
                {
                    node1Value = Convert.ToInt32(string1[i].ToString());
                }

                if (i < string2.Length)
                {
                    node2Value = Convert.ToInt32(string2[i].ToString());
                }

                int result = node1Value + node2Value + reminder;
                reminder = reminder != 0 ? 0 : reminder;
                if(result >= 10)
                {
                    reminder = result / 10;
                    result = result % 10;
                }
                newNode.AddToEnd(result);
            }

            if(reminder != 0)
            {
                newNode.AddToEnd(reminder);
            }

            return newNode.head;
        }

    }
}
