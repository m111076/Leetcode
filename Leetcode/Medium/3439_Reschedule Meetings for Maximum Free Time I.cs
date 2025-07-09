using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3439_Reschedule_Meetings_for_Maximum_Free_Time_I
    {
        public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
        {
            var result = 0;
            var tmp = 0;

            for (var i = 0; i <= startTime.Length; i++)
            {
                tmp += CheckTargetFreeTime(i, eventTime, startTime, endTime);

                if (i < k)
                    continue;

                result = Math.Max(result, tmp);

                tmp -= CheckTargetFreeTime(i - k, eventTime, startTime, endTime);
            }

            return result;
        }

        public int CheckTargetFreeTime(int targetFreeIndex, int eventTime, int[] startTime, int[] endTime)
        {
            if (targetFreeIndex == 0)
                return startTime[targetFreeIndex];

            if (targetFreeIndex == startTime.Length)
                return eventTime - endTime[^1];

            return startTime[targetFreeIndex] - endTime[targetFreeIndex - 1];
        }
    }
}
