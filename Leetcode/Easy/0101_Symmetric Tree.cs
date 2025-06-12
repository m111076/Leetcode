using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _101_Symmetric_Tree
    {
        //runtime 100%
        //time complexity O(n) N層
        public static bool IsSymmetric(TreeNode root)
        {
            return Check(root.left, root.right);
        }

        public static bool Check(TreeNode iLeft, TreeNode iRight)
        {
            if (iLeft == null || iRight == null) return iLeft == iRight;//同時為null也算相同
            if (iLeft.val != iRight.val) return false;

            return Check(iLeft.left, iRight.right) && Check(iLeft.right, iRight.left);
        }
    }

}
