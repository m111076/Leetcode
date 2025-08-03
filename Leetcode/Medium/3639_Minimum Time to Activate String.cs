using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3639_Minimum_Time_to_Activate_String
    {
        public int MinTime(string s, int[] order, int k)
        {
            var left = 0;
            var right = order.Length;
            var result = -1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(s, order, mid) >= k)
                {
                    result = mid;
                    right = mid;
                }
                else
                    left = mid + 1;
            }

            return result;
        }

        private long Check(string s, int[] order, int time)
        {
            var sb = new StringBuilder(s);
            for (var i = 0; i <= time; i++)
            {
                sb[order[i]] = '*';
            }

            var length = s.Length;
            var left = 0;
            var right = 0;
            var cnt = 0L;
            var result = 0L;

            while (left < length)
            {
                while (right < length && cnt < 1)
                {
                    if (sb[right] == '*')
                    {
                        cnt++;
                    }
                    right++;
                }

                if (cnt < 1)
                    break;

                result += length - right + 1;
                if (sb[left++] == '*')
                {
                    cnt--;
                }
            }

            return result;
        }
    }
}
