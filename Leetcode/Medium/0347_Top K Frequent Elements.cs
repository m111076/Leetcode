using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0347_Top_K_Frequent_Elements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            //runtime 50%
            var numDic = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (numDic.ContainsKey(num))
                    numDic[num]++;
                else
                    numDic[num] = 1;
            }

            var minHeap = new PriorityQueue<int, int>();

            foreach (var kvp in numDic)
            {
                minHeap.Enqueue(kvp.Key, kvp.Value);
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }

            var result = new int[k];

            for (var i = 0; i < k; i++)
            {
                result[i] = minHeap.Dequeue();
            }

            return result;

            //runtime 34%
            //time complexity O(n log n)
            // space complexity O(n)
            //var numDic = new Dictionary<int, int>();

            //foreach (var num in nums)
            //{
            //    if (numDic.ContainsKey(num))
            //        numDic[num]++;
            //    else
            //        numDic[num] = 1;
            //}

            //var sortedNums = numDic.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            //var result = new int[k];

            //for (var i = 0; i < k; i++)
            //{
            //    result[i] = sortedNums[i];
            //}

            //return result;
        }
    }
}
