using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1353_Maximum_Number_of_Events_That_Can_Be_Attended
    {
        //runtime 64%
        //time complexity O(dlogn+n)
        //space complexity O(n+d)
        public int MaxEvents(int[][] events)
        {
            var maxEndDay = 0;

            foreach (var e in events)
            {
                maxEndDay = Math.Max(maxEndDay, e[1]);
            }

            var groups = new List<int>[maxEndDay + 1];

            for (var i = 1; i <= maxEndDay; i++)
            {
                groups[i] = new List<int>();
            }

            foreach (var e in events)
            {
                groups[e[0]].Add(e[1]);
            }

            var result = 0;
            var attendedDays = new PriorityQueue<int, int>();

            for (var i = 1; i <= maxEndDay; i++)
            {
                while (attendedDays.Count > 0 && attendedDays.Peek() < i)
                {
                    attendedDays.Dequeue();
                }

                foreach (var endDay in groups[i])
                {
                    attendedDays.Enqueue(endDay, endDay);
                }

                if (attendedDays.Count > 0)
                {
                    attendedDays.Dequeue();
                    result++;
                }
            }

            return result;
        }
    }
}
