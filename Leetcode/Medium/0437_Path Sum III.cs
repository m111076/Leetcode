using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode.Medium
{
    internal class _0437_Path_Sum_III
    {
        //runtime 57%
        //time complexity O(n^2)
        private int Result = 0;
        private long Target = 0;

        public int PathSum(TreeNode root, int targetSum)
        {
            Target = targetSum;
            Check(root);

            return Result;
        }

        public void Check(TreeNode root)
        {
            if (root == null) return;

            Travel(root, Target);
            Check(root.left);
            Check(root.right);
        }

        public void Travel(TreeNode root, long targetSum)
        {
            if (root == null)
                return;
            if (targetSum == root.val)
            {
                Result++;
            }
            Travel(root.left, targetSum - root.val);
            Travel(root.right, targetSum - root.val);
        }
    }
}
