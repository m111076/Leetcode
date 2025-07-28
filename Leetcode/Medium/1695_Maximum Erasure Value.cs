using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1695_Maximum_Erasure_Value
    {
        //runtime 92%
        //time complexity O(n)
        //space complexity O(n)
        //20250722
        public int MaximumUniqueSubarray(int[] nums)
        {
            var result = 0;
            var tmp = 0;
            var left = 0;
            var right = 0;
            var numDic = new Dictionary<int, int>();

            while (right < nums.Length)
            {
                var target = nums[right++];
                if (numDic.ContainsKey(target))
                {
                    while (left < right)
                    {
                        var remove = nums[left++];
                        tmp -= remove;
                        numDic.Remove(remove);
                        if (target == remove)
                            break;
                    }
                }
                numDic.Add(target, target);
                tmp += target;
                result = Math.Max(result, tmp);
            }

            return result;
        }
        //public int MaximumUniqueSubarray(int[] nums)
        //{
        //    //runtime 40%
        //    //time complexity O(n)
        //    var left = 0;
        //    var right = 0;
        //    var set = new HashSet<int>();
        //    var sum = 0;
        //    var result = int.MinValue;

        //    while (right < nums.Length)
        //    {
        //        if (set.Contains(nums[right]))
        //        {
        //            set.Remove(nums[left]);
        //            sum -= nums[left];
        //            left++;
        //        }
        //        else
        //        {
        //            set.Add(nums[right]);
        //            sum += nums[right];
        //            result = Math.Max(sum, result);
        //            right++;
        //        }
        //    }
        //    return result;
        //}
    }
}
