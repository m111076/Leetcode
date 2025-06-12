using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _108_Convert_Sorted_Array_to_Binary_Search_Tree
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        private int[] _nums;
        public TreeNode SortedArrayToBST(int[] nums)
        {
            _nums = nums;
            return BST(0, nums.Length - 1);
        }

        private TreeNode BST(int Start, int End)
        {
            var mid = (Start + End) / 2;
            var node = new TreeNode(_nums[mid]);
            node.left = Start < mid ? BST(Start, mid - 1) : null;
            node.right = mid < End ? BST(mid + 1, End) : null;

            return node;
        }
    }
}
