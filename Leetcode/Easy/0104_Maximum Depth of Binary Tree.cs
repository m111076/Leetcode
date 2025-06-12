using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _104_Maximum_Depth_of_Binary_Tree
    {
        //runtime 100%
        //time complexity O(n) N層
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var leftMax = MaxDepth(root.left);
            var rightMax = MaxDepth(root.right);

            return Math.Max(leftMax, rightMax) + 1;
        }
    }
}
