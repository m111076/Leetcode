using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1717_Maximum_Score_From_Removing_Substrings
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int MaximumGain(string s, int x, int y)
        {
            var c1 = 'a';
            var c2 = 'b';
            if (y > x)
            {
                (x, y) = (y, x);
                (c1, c2) = (c2, c1);
            }

            var result = 0;
            var cnt1 = 0;
            var cnt2 = 0;

            foreach (var c in s)
            {
                if (c == c1)
                    cnt1++;
                else if (c == c2)
                {
                    if (cnt1 > 0)
                    {
                        cnt1--;
                        result += x;
                    }
                    else
                        cnt2++;
                }
                else
                {
                    result += y * Math.Min(cnt1, cnt2);
                    cnt1 = 0;
                    cnt2 = 0;
                }
            }

            result += y * Math.Min(cnt1, cnt2);
            return result;
        }
    }
}
