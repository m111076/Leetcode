using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2799_Count_Complete_Subarrays_in_an_Array
    {
        public int CountCompleteSubarrays(int[] nums)
        {
            //runtime 60%
            //time complexity O(n)
            //space complexity O(n)
            //滑動視窗
            var left = 0;
            var right = 0;
            var dis = nums.Distinct().Count();
            var dic = new Dictionary<int, int>();
            var result = 0;

            while (right < nums.Length)
            {
                if (!dic.TryAdd(nums[right], 1))
                {
                    dic[nums[right]]++;
                }

                while (dic.Count == dis)
                {
                    dic[nums[left]]--;

                    if (dic[nums[left]] == 0)
                        dic.Remove(nums[left]);
                    left++;
                }
                result += left;
                right++;
            }

            return result;

            //runtime 50%
            //time complexity O(n)
            //space complexity O(n)
            //var dis = nums.Distinct().Count();
            //var tmpDic = new Dictionary<int, int>();
            //var result = 0;

            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (tmpDic.ContainsKey(nums[i]))
            //    {
            //        tmpDic[nums[i]] = i;
            //    }
            //    else
            //    {
            //        tmpDic.Add(nums[i], i);
            //    }

            //    if (tmpDic.Count == dis)
            //    {
            //        result += tmpDic.Min(s => s.Value) + 1;
            //    }
            //}

            //return result;
        }
    }
}
