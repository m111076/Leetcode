using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _3066_Minimum_Operations_to_Exceed_Threshold_Value_II
    {
        public static int MinOperations(int[] nums, int k)
        {
            //int result = 0;
            //List<long> newNums = new List<long>();
            //Array.Sort(nums, (a, b) => b.CompareTo(a));
            //int i = nums.Length - 1;
            //int j = 0;
            //while (true)
            //{
            //    long a, b;
            //    if (newNums.Count > 0 && j < newNums.Count && (i < 0 || newNums[j] < nums[i]))
            //        a = newNums[j++];
            //    else
            //        a = nums[i--];
            //    if (a >= k)
            //        return result;
            //    if (newNums.Count > 0 && j < newNums.Count && (i < 0 || newNums[j] < nums[i]))
            //        b = newNums[j++];
            //    else
            //        b = nums[i--];
            //    newNums.Add(a * 2 + b);
            //    result++;
            //}

            var priorityQueue = new PriorityQueue<int, int>();

            foreach (var num in nums)
            {
                if (num < k)
                {
                    priorityQueue.Enqueue(num, num);
                }
            }

            var res = 0;
            while (priorityQueue.Count > 1)
            {
                var x = priorityQueue.Dequeue();
                var y = priorityQueue.Dequeue();

                var newNum = x * 2 + y;
                if (x * 2 < k - y)
                {
                    priorityQueue.Enqueue(x * 2 + y, x * 2 + y);
                }

                res++;
            }

            return res + priorityQueue.Count;

            //var tempDic = new Dictionary<long, long>();
            //var time = 0;
            //foreach (var num in nums)
            //{
            //    if (tempDic.TryGetValue(num, out var value))
            //    {
            //        tempDic[num] = ++value;
            //    }
            //    else
            //    {
            //        tempDic.Add(num, 1);
            //    }
            //}

            //while (tempDic.Any(n => n.Key < k))
            //{
            //    var first = tempDic.Min(n => n.Key);
            //    if (tempDic[first] == 1)
            //    {
            //        tempDic.Remove(first);
            //    }
            //    else
            //    {
            //        tempDic[first]--;
            //    }

            //    var second = tempDic.Min(k => k.Key);
            //    if (tempDic[second] == 1)
            //    {
            //        tempDic.Remove(second);
            //    }
            //    else
            //    {
            //        tempDic[second]--;
            //    }
            //    var target = first * 2 + second;
            //    if (tempDic.TryGetValue(target, out var value))
            //    {
            //        tempDic[target]++;
            //    }
            //    else
            //    {
            //        tempDic.Add(target, 1);
            //    }

            //    time++;
            //}
            //return time;
        }
    }
}
