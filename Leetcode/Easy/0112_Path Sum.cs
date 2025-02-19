using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _112_Path_Sum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            targetSum -= root.val;

            //左右節點皆為null target又為0代表找到不需要繼續找了
            if (root.left == null && root.right == null && targetSum == 0)
                return true;

            if (HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum))
                return true;

            return false;
        }
    }
}
