using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _0992_Subarrays_with_K_Different_Integers
    {
        //runtime 87%
        //time complexity O(n)
        //space complexity O(n)
        //滑動視窗 at least
        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            return check(nums, k) - check(nums, k + 1);
        }

        private int check(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var dic = new Dictionary<int, int>();

            while (right < nums.Length)
            {
                if (!dic.TryAdd(nums[right], 1))
                    dic[nums[right]]++;

                while (dic.Count >= k)
                {
                    var target = nums[left++];

                    dic[target]--;
                    if (dic[target] == 0)
                        dic.Remove(target);
                }

                result += left;
                right++;
            }

            return result;
        }
    }
}
