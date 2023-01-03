using System;
using System.Collections.Generic;

namespace N_aryTreePostorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Node(1, new List<Node>());
            root.children.Add(new Node(3, new List<Node>()));
            root.children.Add(new Node(2, new List<Node>()));
            root.children.Add(new Node(4, new List<Node>()));
            
            Console.WriteLine(String.Join(", ", Postorder(root))); //Expected: [3,2,4,1]
        }

        //The Postorder method takes in a Node object called root, which represents the root of the tree.It creates an empty
        //list called ans, which will be used to store the values of the nodes in the tree as they are visited. If the root
        //node is null, it returns the empty list.

        //The method then calls a helper function called Traverse, passing it the root node and the ans list as arguments. The Traverse
        //method first checks if the root node has any children. If it does not, it simply returns. If it does have children, it loops
        //through each child node and calls itself recursively with that child node as the root. This continues until it reaches
        //a node with no children, at which point it will start returning up the call stack.

        //Once all the children of a node have been visited, the function adds the value of the root node to the ans list. This
        //process continues until the entire tree has been traversed, at which point the ans list will contain the values of the
        //nodes in post-order. The Postorder function then returns this list.
        private static IList<int> Postorder(Node root) {
            List<int> ans = new List<int>();
            if(root is null) return ans;
        
            Traverse(root, ans);
            return ans;
     
            void Traverse(Node root, List<int> ans)
            {
                if (root.children == null) return;

                foreach (var c in root.children)
                    Traverse(c, ans);
                
                ans.Add(root.val);
            }
        }
    }

    class Node
    {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
}