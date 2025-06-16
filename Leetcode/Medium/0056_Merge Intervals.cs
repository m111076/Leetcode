using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0056_Merge_Intervals
    {
        public int[][] Merge(int[][] intervals)
        {
            //runtime 99%
            //time complexity O(nlogn)
            //space complexity O(n)
            //按照提議模擬，使用idx來減少查找次數
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            var result = new List<int[]>();
            var idx = -1;

            foreach (var i in intervals)
            {
                if (result.Count == 0 || result[idx][1] < i[0])
                {
                    result.Add(i);
                    idx++;
                }
                else
                {
                    result[idx][1] = Math.Max(result[idx][1], i[1]);
                }
            }

            return result.ToArray();
        }
    }
}
