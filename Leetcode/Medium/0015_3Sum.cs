using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0015_3Sum
    {
        //runtime 62%
        //time complexity O(n^2)
        //space complexity O(1)
        //終止條件要判斷
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();

            for (var i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0)
                    if (nums[i] == nums[i - 1])
                        continue;
                if (nums[i] + nums[i + 1] + nums[i + 2] > 0)
                    break;
                if (nums[i] + nums[nums.Length - 2] + nums[nums.Length - 1] < 0)
                    continue;

                var j = i + 1;
                var k = nums.Length - 1;

                while (j < k)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    if (sum > 0)
                        k--;
                    else if (sum < 0)
                        j++;
                    else
                    {
                        result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        j++;

                        while (j < k && nums[j] == nums[j - 1])
                        {
                            j++;
                        }

                        k--;

                        while (j < k && nums[k] == nums[k + 1])
                        {
                            k--;
                        }
                    }
                }

            }
            return result;
        }
    }
}
