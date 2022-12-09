using System;

namespace PathSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Complexity - O(n);
            //Explanation - Recursively move to left and right subtree and increase sum
            //by the value of the current node and if at any point the current sum is
            //equal to the target sum we return true;
        }
        
        private static bool HasPathSum(TreeNode root, int targetSum) {
            int sum = 0;
            bool isTargetSum = Sum(root, targetSum, sum);
            return isTargetSum;
        }
    
        private static bool Sum(TreeNode root, int targetSum, int sum)
        {
            if(root == null) return false;
        
            sum += root.val;
        
            if(sum == targetSum && root.left == null && root.right==null)
                return true;
        
            bool a = Sum(root.left, targetSum, sum);
            if(a == true) return true;
        
            bool b = Sum(root.right, targetSum, sum);
            if(b == true) return true;
        
            return false;
        
        }
    }
}