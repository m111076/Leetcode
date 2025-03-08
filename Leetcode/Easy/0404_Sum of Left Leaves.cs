using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0404_Sum_of_Left_Leaves
    {

        public int result = 0;

        //runtime 100%
        //就定義搞清楚
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 0;

            dfs(root);

            return result;
        }

        public void dfs(TreeNode root)
        {
            if (root == null) return;

            if (root.left == null && root.right == null)
            {
                result += root.val;
                return;
            }

            dfs(root.left);

            if (root.right != null)
                if (root.right.left != null || root.right.right != null)
                {
                    dfs(root.right);
                }
        }
    }
}
