using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.WC._439
{
    public class Q1_Find_the_Largest_Almost_Missing_Integer
    {
        public int LargestInteger(int[] nums, int k)
        {
            if (nums == null)
                return -1;
            if (nums.Length == k)
            {
                return nums.Max();
            }

            var tmpDic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (tmpDic.ContainsKey(num))
                    tmpDic[num]++;
                else
                    tmpDic.Add(num, 1);
            }
            var result = -1;
            var idx = nums.Length - 1;

            if (k > 1)
            {
                if (tmpDic[nums[0]] == 1)
                    result = Math.Max(result, nums[0]);
                if (tmpDic[nums[idx]] == 1)
                    result = Math.Max(result, nums[idx]);
                return result;
            }
            else
            {
                foreach (var n in tmpDic.Where(x => x.Value == 1))
                {
                    result = Math.Max(result, n.Key);
                }
                return result;
            }
        }
    }
}
