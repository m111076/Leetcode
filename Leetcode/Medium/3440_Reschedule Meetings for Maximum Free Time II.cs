using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3440_Reschedule_Meetings_for_Maximum_Free_Time_II
    {
        public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
        {
            var pq = new PriorityQueue<int, int>();
            var times = new int[startTime.Length + 1];

            for (int i = 0; i <= startTime.Length; i++)
            {
                var time = CheckTargetFreeTime(i, eventTime, startTime, endTime);
                times[i] = time;

                if (pq.Count == 3 && times[pq.Peek()] < time)
                {
                    pq.Dequeue();
                    pq.Enqueue(i, time);
                }
                else if (pq.Count < 3)
                {
                    pq.Enqueue(i, time);
                }
            }

            var third = pq.Dequeue();
            var second = pq.Dequeue();
            var first = pq.Dequeue();

            var result = 0;

            for (var i = 0; i < startTime.Length; i++)
            {
                var targetTime = endTime[i] - startTime[i];
                var tmp = CheckTargetFreeTime(i, eventTime, startTime, endTime) + CheckTargetFreeTime(i + 1, eventTime, startTime, endTime);
                if (i != first && i + 1 != first && targetTime <= times[first] || i != second && i + 1 != second && targetTime <= times[second] || targetTime <= times[third])
                {
                    tmp += targetTime;
                }

                result = Math.Max(result, tmp);
            }

            return result;
        }

        private int CheckTargetFreeTime(int targetFreeIndex, int eventTime, int[] startTime, int[] endTime)
        {
            if (targetFreeIndex == 0)
                return startTime[targetFreeIndex];
            if (targetFreeIndex == startTime.Length)
                return eventTime - endTime[^1];
            return startTime[targetFreeIndex] - endTime[targetFreeIndex - 1];
        }
    }
}
