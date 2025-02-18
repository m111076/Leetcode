using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1_Two_Sum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var subDic = new Dictionary<int, int>();
            var length = nums.GetLength(0);
            for (var i = 0; i < length; i++)
            {
                var sub = target - nums[i];
                if (subDic.ContainsKey(sub))
                {
                    return new int[] { subDic[sub], i };
                }
                if (!subDic.ContainsKey(nums[i]))
                {
                    subDic.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
