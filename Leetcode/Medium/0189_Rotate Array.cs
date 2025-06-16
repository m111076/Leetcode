using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0189_Rotate_Array
    {
        public void Rotate(int[] nums, int k)
        {
            //三段反轉
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            k %= nums.Length;
            if (k == 0)
                return;

            Rotate(0, nums.Length - 1);
            Rotate(0, k - 1);
            Rotate(k, nums.Length - 1);

            void Rotate(int left, int right)
            {
                while (left < right)
                {
                    var tmp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = tmp;

                    left++;
                    right--;
                }
            }

            //TLE
            //k %= nums.Length;
            //if (k == 0)
            //    return;

            //while (k > 0)
            //{
            //    var last = nums[^1];

            //    for (var i = nums.Length - 1; i > 0; i--)
            //    {
            //        nums[i] = nums[i - 1];
            //    }

            //    nums[0] = last;
            //    k--;
            //}
        }
    }
}
