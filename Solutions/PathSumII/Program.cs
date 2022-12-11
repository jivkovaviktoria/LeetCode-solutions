using System;
using System.Collections.Generic;
using System.Linq;
using PathSum;

namespace PathSumII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explanation - Recursively move to left and right subtree and add the node value in a list
            //if at any point the current sum is equal to the target sum and the given node is a leaf
            //we return true;
        }
        
        public static IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if(root == null) return ans;
            Sum(root, targetSum, new List<int>(), ans);
            
            return ans;
        }

        private static void Sum(TreeNode root, int targetSum, List<int> nodes, IList<IList<int>> ans)
        {
            nodes.Add(root.val);
        
            if (root.left == null && root.right == null && nodes.Sum() == targetSum)
                ans.Add(nodes);

            if (root.left != null)
                Sum(root.left, targetSum, new List<int>(nodes), ans);
            if (root.right != null)
                Sum(root.right, targetSum, new List<int>(nodes), ans);
        }
    }
}