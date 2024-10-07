using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinarySearchTree.Solutions
{
    public class BreathFirstTree
    {
        public static NodeString CreateNewNode(string key)
        {
            NodeString node = new NodeString();
            node.value = key;
            node.left = node.right = null;
            return node;
        }

        public static ArrayList BreathTranverse(NodeString root)
        {
            ArrayList result = new ArrayList();
            Queue<NodeString> queue = new Queue<NodeString>();
            if(root != null) queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result.Insert(result.Count, current.value);
                if (current.left != null) queue.Enqueue(current.left);
                if (current.right != null) queue.Enqueue(current.right);
            }
            return result;
        }
    }
}
