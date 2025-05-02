using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2962_Count_Subarrays_Where_Max_Element_Appears_at_Least_K_Times
    {
        public long CountSubarrays(int[] nums, int k)
        {
            //runtime 52%
            var left = 0;
            var right = 0;
            var result = 0L;
            var max = nums.Max();
            var cnt = 0;

            while (right < nums.Length)
            {
                if (nums[right] == max)
                    cnt++;

                while (cnt >= k)
                {
                    result += nums.Length - right;

                    if (nums[left++] == max)
                        cnt--;
                }

                //出來後不滿足，但left為滿足的，因此有0~left-1個
                //result += left;

                right++;
            }

            return result;

            //runtime 60%
            //slidingWindow
            //sapce complexity O(1)
            //var max = nums.Max();
            //var left = 0;
            //var right = 0;
            //var result = 0L;
            //var maxCnt = 0;

            //for (; right < nums.Length; right++)
            //{
            //    maxCnt += nums[right] == max ? 1 : 0;
            //    while (maxCnt >= k)
            //    {
            //        maxCnt -= nums[left++] == max ? 1 : 0;
            //    }
            //    result += left;
            //}

            //return result;


            //runtime 26%
            //time complexity O(n)
            //space complexity O(n)
            //var max = nums.Max();
            //var q = new Queue<int>();
            //var right = 0;
            //var result = 0L;

            //for (; right < nums.Length; right++)
            //{
            //    if (nums[right] == max)
            //    {
            //        q.Enqueue(right);
            //    }

            //    if (q.Count > k)
            //    {
            //        q.Dequeue();
            //        result += q.Peek() + 1;
            //    }
            //    else if (q.Count == k)
            //    {
            //        result += q.Peek() + 1;
            //    }
            //}

            //return result;
        }

    }
}
