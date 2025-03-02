using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0278_First_Bad_Version
    {
        public int TargetIdx = 0;

        public int FirstBadVersion(int n)
        {
            //runtime 99%
            //二分搜尋
            var low = 1;
            var high = n;

            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (IsBadVersion(mid))
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return high;
        }

        public bool IsBadVersion(int version)
        {
            return true;
        }
    }
}
