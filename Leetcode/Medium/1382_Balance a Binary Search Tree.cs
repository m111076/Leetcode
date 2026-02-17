using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1382_Balance_a_Binary_Search_Tree
    {
        //runtime 89%
        //time complexity O(n)
        //space complexity O(n)
        public TreeNode BalanceBST(TreeNode root)
        {
            var nums = new List<int>();
            Inorder(root, nums);

            return BuildBST(nums, 0, nums.Count - 1);
        }

        private void Inorder(TreeNode node, List<int> nums)
        {
            if (node == null)
                return;

            Inorder(node.left, nums);
            nums.Add(node.val);
            Inorder(node.right, nums);
        }

        private TreeNode BuildBST(List<int> nums, int left, int right)
        {
            if (left > right)
                return null;

            var mid = left + (right - left) / 2;

            TreeNode node = new TreeNode(nums[mid]);

            node.left = BuildBST(nums, left, mid - 1);
            node.right = BuildBST(nums, mid + 1, right);

            return node;
        }
    }
}
