using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0543_Diameter_of_Binary_Tree
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)/O(logn)=>極度不平衡與平衡
        //題目說不一定會經過根節點，所以要找出每個節點的左右子樹的長度，然後取最大值
        private int _diameter = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            CheckDiameter(root);
            return _diameter;
        }

        public int CheckDiameter(TreeNode root)
        {
            if (root == null)
                return 0;

            var left = CheckDiameter(root.left);
            var right = CheckDiameter(root.right);
            _diameter = Math.Max(_diameter, left + right);

            return Math.Max(left, right) + 1;
        }
    }
}
