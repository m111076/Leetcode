using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1995_Count_Special_Quadruplets
    {
        //runtime 91%
        //time complexity O(n^2)
        //space complexity O(n)
        public int CountQuadruplets(int[] nums)
        {
            var tmp = new Dictionary<int, int>();
            var bound = nums.Length - 1;
            var result = 0;

            tmp.Add(nums[0] + nums[1], 1);
            
            //C
            for (var i = 2; i < bound; i++)
            {
                //D
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var sum = nums[j] - nums[i];
                    if (tmp.ContainsKey(sum))
                        result += tmp[sum];
                }

                for (var j = 0; j < i; j++)
                {
                    var sum = nums[j] + nums[i]; //a+b
                    if (!tmp.TryAdd(sum, 1))
                        tmp[sum]++;
                }
            }

            return result;
        }
    }
}
