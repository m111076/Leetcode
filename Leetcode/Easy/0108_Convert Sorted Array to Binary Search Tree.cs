using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _108_Convert_Sorted_Array_to_Binary_Search_Tree
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return Helper(nums, 0, nums.Length - 1);
        }

        public static TreeNode Helper(int[] iNums, int iStartIdx, int iEndIdx)
        {
            if (iEndIdx < iStartIdx)
                return null;

            var midIdx = (iStartIdx + iEndIdx) / 2;
            var node = new TreeNode(iNums[midIdx]);
            node.left = Helper(iNums, iStartIdx, midIdx - 1);
            node.right = Helper(iNums, midIdx + 1, iEndIdx);
            return node;
        }
    }
}
