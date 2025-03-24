using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0530_Minimum_Absolute_Difference_in_BST
    {
        //runtime 100%
        public int GetMinimumDifference(TreeNode root)
        {
            int prev = -1;
            var tmpMin = int.MaxValue;
            Check(root);

            return tmpMin;

            void Check(TreeNode node)
            {
                if (node == null)
                    return;

                if (prev != -1)
                {
                    tmpMin = Math.Min(tmpMin, Math.Abs(node.val - prev));
                }

                prev = node.val;

                Check(node.left);
                Check(node.right);
            }
        }
    }
}
