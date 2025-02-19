using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _35_Search_Insert_Position
    {
        public static int SearchInsert(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                else if (nums[i] > target)
                {
                    return i;
                }
                else if (target > nums[i] && i == nums.Length - 1)
                {
                    return i + 1;
                }

            }

            return default;

            //二分收尋
            //int left = 0, right = nums.Length - 1, mid;
            //while (left <= right)
            //{
            //    mid = (right + left) / 2;
            //    if (nums[mid] < target) left = mid + 1;
            //    else if (nums[mid] > target) right = mid - 1;
            //    else return mid;
            //}
            //return left;
        }
    }
}
