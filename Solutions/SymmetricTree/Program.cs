using System;

namespace SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(4), new TreeNode(3)));

            Console.WriteLine(IsSymmetric(root)); //Expected: True
        }
        
        public static bool IsSymmetric(TreeNode root) {
            if(root is null) return true;
            return IsEqual(root.left, root.right);
        
            bool IsEqual(TreeNode n1, TreeNode n2)
            {
                if (n1 == null && n2 != null || n1 != null && n2 == null || n1 != null && n2 != null && n1.val != n2.val)
                    return false;
        
                return n1 == null && n2 == null || IsEqual(n1.left, n2.right) && IsEqual(n1.right, n2.left);
            }
        }
    }
    
    public class TreeNode {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                 this.val = val;
                 this.left = left;
                 this.right = right;
         } 
    }
}