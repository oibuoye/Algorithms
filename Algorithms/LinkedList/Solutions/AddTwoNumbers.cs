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
            Int64 num1 = GetNodeIntegerValue(firstNode);

            SingleLinkedList singleLinkedTwo = new SingleLinkedList();
            string secondNode = singleLinkedTwo.Transversal(node2);
            Int64 num2 = GetNodeIntegerValue(secondNode);

            Int64 result = num1 + num2;
            string stringResult = result.ToString();

            SingleLinkedList newNode = new SingleLinkedList();
            for(int i = 0; i < stringResult.Length; i++)
            {
                newNode.AddToBegining(Convert.ToInt32(stringResult[i].ToString()));
            }

            return newNode.head;
        }

        public static long GetNodeIntegerValue(string value)
        {
            char[] charToArray = value.ToCharArray();
            Array.Reverse(charToArray);
            return Convert.ToInt64(new string(charToArray));
        }

    }
}
