using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal static class _0632_Smallest_Range_Covering_Elements_from_K_Lists
    {
        //runtime 80%
        //time complexity O(n*logk)
        //space complexity O(k)=>nums數量
        //滑動視窗方法還想不出來
        public static int[] SmallestRange(IList<IList<int>> nums)
        {
            var amount = nums.Count;
            var end = int.MinValue;
            var pQueue = new PriorityQueue<(int value, int listIdx, int idx), int>();
            var idx = 0;

            //k*logk
            foreach (var item in nums)
            {
                pQueue.Enqueue((item[0], idx++, 0), item[0]);
                end = Math.Max(end, item[0]);
            }

            var minStart = 0;
            var minEnd = int.MaxValue;

            //n*logk
            while (pQueue.Count == amount)
            {
                var tmp = pQueue.Dequeue();

                if (end - tmp.value < minEnd - minStart)
                {
                    minStart = tmp.value;
                    minEnd = end;
                }

                if (tmp.idx + 1 < nums[tmp.listIdx].Count)
                {
                    pQueue.Enqueue((nums[tmp.listIdx][tmp.idx + 1], tmp.listIdx, tmp.idx + 1), nums[tmp.listIdx][tmp.idx + 1]);
                    end = Math.Max(end, nums[tmp.listIdx][tmp.idx + 1]);
                }
            }

            return new int[] { minStart, minEnd };
        }
        //TLE
        //public static int[] SmallestRange(IList<IList<int>> nums)
        //{
        //    var left = 0;
        //    var right = 0;
        //    var minLength = int.MaxValue;
        //    var minStart = int.MaxValue;
        //    var start = 0;
        //    var end = 0;

        //    var totalList = new List<int>();

        //    foreach (var item in nums)
        //    {
        //        totalList.AddRange(item);
        //    }

        //    totalList.Sort();
        //    start = totalList[left];

        //    while (right < totalList.Count)
        //    {
        //        end = totalList[right];

        //        while (ContainAll(nums, start, end))
        //        {
        //            if (end - start < minLength)
        //            {
        //                minStart = start;
        //                minLength = end - start;
        //            }
        //            else if (end - start == minLength)
        //            {
        //                minStart = Math.Min(start, minStart);
        //            }
        //            left++;

        //            if (left > right)
        //                break;

        //            start = totalList[left];
        //        }
        //        right++;
        //    }

        //    return new int[] { minStart, minStart + minLength };
        //}

        //private static bool ContainAll(IList<IList<int>> nums, int min, int max)
        //{
        //    foreach (var items in nums)
        //    {
        //        var IsContain = false;
        //        foreach (var item in items)
        //        {
        //            if (item >= min && item <= max)
        //            {
        //                IsContain = true;
        //                break;
        //            }
        //        }
        //        if (IsContain)
        //            continue;
        //        else
        //            return false;
        //    }
        //    return true;
        //}
    }
}
