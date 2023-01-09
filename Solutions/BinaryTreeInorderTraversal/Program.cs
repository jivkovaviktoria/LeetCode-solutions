using System;
using System.Collections.Generic;

namespace BinaryTreeInorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(2, null, new TreeNode(3)));
            Console.WriteLine(InorderTraversal(root)); //Expected: [1,3,2]
        }
        
        public static IList<int> InorderTraversal(TreeNode root) {
            List<int> ans = new List<int>();
            Traverse(root);
            return ans;
        
            void Traverse(TreeNode root)
            {
                if (root != null)
                {
                    Traverse(root.left);
                    ans.Add(root.val);
                    Traverse(root.right);
                }
            }
        }
    }
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        } 
    }
}