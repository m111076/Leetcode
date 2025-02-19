using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _94_Binary_Tree_Inorder_Traversal
    {
        public static List<int> Result = new List<int>();

        public static IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return Result;

            InorderTraversal(root.left);
            Result.Add(root.val);
            InorderTraversal(root.right);
            return Result;

        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
