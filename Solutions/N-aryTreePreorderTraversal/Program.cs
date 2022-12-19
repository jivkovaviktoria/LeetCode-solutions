using System;
using System.Collections.Generic;

namespace N_aryTreePreorderTraversal
{
    class Program
    {
        static void Main(string[] args) { }

        //The method defines a helper function called Solve which takes a node as an input
        //and performs the following steps:
        //If the input node is null, it returns immediately.
        //It adds the value of the input node to the result list.
        //It iterates through the children of the input node and calls the Solve function on each child node.
        
        //Note: This method is an example of a recursive function, as the Solve function calls itself on each child node of the input node.
        
        private static IList<int> Preorder(Node root)
        {
            List<int> res = new List<int>();
            Solve(root);

            return res;

            void Solve(Node node)
            {
                if (node == null) return;
                res.Add(node.val);

                foreach (var c in node.children) Solve(c);
            }
        }
    }
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}