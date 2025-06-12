using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0098_Validate_Binary_Search_Tree
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)/O(logn)=>極度不平衡與平衡
        //BST除了左右子樹要符合，自己本身也要符合
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        private bool IsValidBST(TreeNode root, long min, long max)
        {
            if (root == null)
                return true;
            if (root.val <= min || root.val >= max)
                return false;

            return IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max);
        }
    }
}
