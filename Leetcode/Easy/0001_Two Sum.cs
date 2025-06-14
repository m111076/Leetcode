using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1_Two_Sum
    {
        //runtime 98%
        //time complexity O(n)
        //space complexity O(n)
        //用字典紀錄剩下的部分，然後查表
        public static int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            var result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.TryGetValue(nums[i], out var val))
                {
                    result[0] = val;
                    result[1] = i;
                    return result;
                }
                else
                {
                    dic.TryAdd(target - nums[i], i);
                }
            }

            return result;
        }
    }
}
