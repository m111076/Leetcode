using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0981_Time_Based_Key_Value_Store
    {
        //runtime 59%
        public class TimeMap
        {

            private Dictionary<string, List<(int time, string value)>> history = new Dictionary<string, List<(int time, string value)>>();

            public TimeMap()
            {

            }

            public void Set(string key, string value, int timestamp)
            {
                if (!history.TryAdd(key, new List<(int, string)>() { (timestamp, value) }))
                    history[key].Add((timestamp, value));
            }

            public string Get(string key, int timestamp)
            {
                if (!history.ContainsKey(key))
                    return string.Empty;

                var targets = history[key];

                var left = 0;
                var right = targets.Count;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;

                    if (targets[mid].time > timestamp)
                        right = mid;
                    else
                        left = mid + 1;
                }

                if (left == 0)
                    return string.Empty;

                return targets[left - 1].value;
            }

        }
    }
}
