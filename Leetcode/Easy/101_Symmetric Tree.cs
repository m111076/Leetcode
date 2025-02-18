using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _101_Symmetric_Tree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            return Check(root.left, root.right);
        }

        public static bool Check(TreeNode iLeft, TreeNode iRight)
        {
            if (iLeft == null || iRight == null) return iLeft == iRight;
            if (iLeft.val != iRight.val) return false;

            return Check(iLeft.left, iRight.right) && Check(iLeft.right, iRight.left);
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
