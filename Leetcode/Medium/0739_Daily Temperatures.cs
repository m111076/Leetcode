using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0739_Daily_Temperatures
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            //runtime 92%
            //time complexity O(n)
            //space complexity O(n)
            //直接紀錄index=>index就可以直接查表，不需要再透過字典
            var stack = new Stack<int>();
            var result = new int[temperatures.Length];

            for (var i = temperatures.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
                {
                    stack.Pop();
                }

                result[i] = stack.Count > 0 ? stack.Peek() - i : 0;

                stack.Push(i);
            }
            return result;

            //18%
            //太慢了
            //var stack = new Stack<int>();
            //var record = new Dictionary<int, int>();
            //var result = new int[temperatures.Length];

            //for (var i = temperatures.Length - 1; i >= 0; i--)
            //{
            //    while (stack.Count > 0 && stack.Peek() <= temperatures[i])
            //    {
            //        stack.Pop();
            //    }

            //    if (stack.Count > 0)
            //    {
            //        result[i] = record[stack.Peek()] - i;
            //    }
            //    else
            //    {
            //        result[i] = 0;
            //    }

            //    stack.Push(temperatures[i]);
            //    if (!record.TryAdd(temperatures[i], i))
            //    {
            //        record[temperatures[i]] = i;
            //    }
            //}
            //return result;
        }
    }
}
