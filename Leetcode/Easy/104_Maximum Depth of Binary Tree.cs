using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _104_Maximum_Depth_of_Binary_Tree
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var leftMax = MaxDepth(root.left);
            var rightMax = MaxDepth(root.right);

            return Math.Max(leftMax, rightMax) + 1;
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
