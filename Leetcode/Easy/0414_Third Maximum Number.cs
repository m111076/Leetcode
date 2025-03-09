using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0414_Third_Maximum_Number
    {
        public static int ThirdMax(int[] nums)
        {
            //runtime 100%
            //比大小
            //比要轉List的快
            var max = long.MinValue;
            var mid = long.MinValue;
            var min = long.MinValue;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max || nums[i] == mid || nums[i] == min)
                    continue;
                if (nums[i] > max)
                {
                    min = mid;
                    mid = max;
                    max = nums[i];
                }
                else if (nums[i] > mid)
                {
                    min = mid;
                    mid = nums[i];
                }
                else if (nums[i] > min)
                {
                    min = nums[i];
                }
            }

            return min == long.MinValue ? (int)max : (int)min;

            //runtime 23%
            var map = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!map.ContainsKey(num))
                    map.Add(num, num);
            }

            var target = map.OrderByDescending(x => x.Key).Select(x => x.Key).ToList();

            if (target.Count < 3)
                return target[0];
            else
                return target[2];
        }
    }
}
