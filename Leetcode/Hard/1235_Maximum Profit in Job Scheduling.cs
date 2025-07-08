using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _1235_Maximum_Profit_in_Job_Scheduling
    {
        //runtime 96%
        //time complexity O()
        //space complexity O()
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            var jobs = new int[startTime.Length][];

            for (int i = 0; i < startTime.Length; i++)
            {
                jobs[i] = new int[] { startTime[i], endTime[i], profit[i] };
            }

            Array.Sort(jobs, (a, b) => a[1].CompareTo(b[1]));

            var dp = new int[endTime.Length + 1];
            dp[0] = 0;

            for (var i = 0; i < jobs.Length; i++)
            {
                var idx = FindIndex(jobs, jobs[i][0]) - 1;
                //jobs-Based轉為dp-Based，避免當idx為-1時會出現錯誤
                dp[i + 1] = Math.Max(dp[i], jobs[i][2] + dp[idx + 1]);
            }

            return dp[^1];
        }

        //找出第一個endTime>startTime的Index，因此return後需要-1
        private int FindIndex(int[][] jobs, int startTime)
        {
            var left = 0;
            var right = jobs.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (jobs[mid][1] > startTime)
                    right = mid;
                else
                    left = mid + 1;
            }

            return right;
        }
    }
}
