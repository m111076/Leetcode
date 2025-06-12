using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 100%
    //time complexity O(n)
    //space complexity O(n)/O(logn)=>極度不平衡與平衡
    //BST就是inorder
    internal class _0230_Kth_Smallest_Element_in_a_BST
    {
        private int Result = 0;
        private int Count = 0;

        public int KthSmallest(TreeNode root, int k)
        {
            InorderTraversal(root, k);

            return Result;
        }

        private void InorderTraversal(TreeNode root, int k)
        {
            if (root == null || Count >= k)
                return;

            InorderTraversal(root.left, k);
            Count++;
            if (Count == k)
            {
                Result = root.val;
                return;
            }
            InorderTraversal(root.right, k);
        }
    }
}
