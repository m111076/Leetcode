using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _110_Balanced_Binary_Tree
    {
        public static bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (Math.Abs(CountHeight(root.left) - CountHeight(root.right)) <= 1)
            {
                return IsBalanced(root.left) && IsBalanced(root.right);
            }
            else
            {
                return false;
            }

        }
        public static int CountHeight(TreeNode iNode)
        {
            if (iNode == null) return 0;

            return 1 + Math.Max(CountHeight(iNode.left), CountHeight(iNode.right));

        }
    }
}
