﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _1751_Maximum_Number_of_Events_That_Can_Be_Attended_II
    {
        //runtime 100%
        //time complexity O(n * k * log n)
        //space complexity O(n * k)
        public int MaxValue(int[][] events, int k)
        {
            if (k == 1)
            {
                return events.Max(x => x[2]);
            }

            Array.Sort(events, (a, b) => a[1].CompareTo(b[1]));
            var dp = new int[events.Length + 1, k + 1];

            for (var i = 0; i < events.Length; i++)
            {
                var idx = FindIndex(events, events[i][0]) - 1;
                for (var j = 1; j <= k; j++)
                {
                    dp[i + 1, j] = Math.Max(dp[i, j], dp[idx + 1, j - 1] + events[i][2]);
                }
            }

            return dp[events.Length, k];
        }

        private int FindIndex(int[][] jobs, int startTime)
        {
            var left = 0;
            var right = jobs.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (jobs[mid][1] >= startTime)
                    right = mid;
                else
                    left = mid + 1;
            }

            return right;
        }
    }
}
