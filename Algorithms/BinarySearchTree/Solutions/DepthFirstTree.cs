using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinarySearchTree.Solutions
{
    public class DepthFirstTree
    {
        public static NodeString CreateNewNode(string key)
        {
            NodeString node = new NodeString();
            node.value = key;
            node.left = node.right = null;
            return node;
        }

        public static NodeInt CreateNewNode(int key)
        {
            NodeInt node = new NodeInt();
            node.val = key;
            node.left = node.right = null;
            return node;
        }

        public static ArrayList DepthTranverse(NodeString root)
        {
            ArrayList result = new ArrayList();
            Stack<NodeString> stack = new Stack<NodeString>();
            if(root != null) stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                result.Insert(result.Count, current.value);
                if (current.right != null) stack.Push(current.right);
                if (current.left != null) stack.Push(current.left);
            }
            return result;
        }

        public static ArrayList DepthTranverseRecursive(NodeString root)
        {
            if (root == null) return new ArrayList { };
            var lValues = DepthTranverseRecursive(root.left);
            var rValues = DepthTranverseRecursive(root.right);
            ArrayList result = new ArrayList();
            result.AddRange(lValues);
            result.AddRange(rValues);
            return result;
        }

        public static bool CheckTarget(NodeString root, string target)
        {
            Stack<NodeString> stack = new Stack<NodeString>();
            if (root != null) stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if(current.value == target) return true;
                if (current.right != null) stack.Push(current.right);
                if (current.left != null) stack.Push(current.left);
            }
            return false;
        }

        public static int SumTree(NodeInt root)
        {
            if (root == null) return 0;
            return root.val + SumTree(root.left) + SumTree(root.right);
        }

        public static double MaxPathSumTree(NodeInt root)
        {
            if (root == null) return double.NegativeInfinity;
            if (root.right == null && root.left == null) return root.val;
            double maxChild = Math.Max(MaxPathSumTree(root.left), MaxPathSumTree(root.right));
            return root.val + maxChild;
        }

        public static IList<int> InorderTraversal(NodeInt root)
        {
            List<int> result = new List<int>();
            Stack<NodeInt> stack = new Stack<NodeInt>();
            if (root != null) stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (current.right != null) stack.Push(current.right);
                stack.Push(new NodeInt { val = current.val });
                if (current.left != null) stack.Push(current.left);

                if(current.right == null & current.left == null)
                {
                    result.Add(stack.Pop().val);
                }
            }
            return result;
        }

        public static bool IsValidBST(NodeInt root)
        {
            if (root == null) return true;
            if(LeftBST(root.left, root.val) && RightBST(root.right, root.val))
            {
                return true;
            }
            return false;
        }

        public static bool LeftBST(NodeInt root, int rootValue)
        {
            List<int> tracker = new List<int>();
            Stack<NodeInt> stack = new Stack<NodeInt>();
            if (root != null) stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (current.val >= rootValue) return false;

                if (current.right != null) stack.Push(current.right);
                stack.Push(new NodeInt { val = current.val });
                if (current.left != null) stack.Push(current.left);

                if (current.right == null & current.left == null)
                {
                    tracker.Add(stack.Pop().val);
                }
            }

            for(int i = 1; i < tracker.Count; i++)
            {
                if(tracker[i] <= tracker[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool RightBST(NodeInt root, int rootValue)
        {
            List<int> tracker = new List<int>();
            Stack<NodeInt> stack = new Stack<NodeInt>();
            if (root != null) stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if(current.val <= rootValue) return false;

                if (current.right != null) stack.Push(current.right);
                stack.Push(new NodeInt { val = current.val });
                if (current.left != null) stack.Push(current.left);

                if (current.right == null & current.left == null)
                {
                    tracker.Add(stack.Pop().val);
                }
            }

            for (int i = 1; i < tracker.Count; i++)
            {
                if (tracker[i] <= tracker[i - 1])
                {
                    return false;
                }
            }

            return true;
        }



    }

    public class NodeString
    {
        public string value;
        public NodeString left, right;
    }

    public class NodeInt
    {
        public int val;
        public NodeInt left, right;
    }

}
