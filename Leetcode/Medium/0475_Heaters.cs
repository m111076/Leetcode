using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0475_Heaters
    {
        //runtime 55%
        //time complexity O(hlogh+hlogh+logn*(h+h))
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            Array.Sort(heaters);

            var left = 0;
            var right = (int)1e9;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(houses, heaters, mid))
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }

        private bool Check(int[] houses, int[] heaters, int radius)
        {
            var idx_House = 0;
            var idx_Heater = 0;

            while (idx_House < houses.Length)
            {
                while (idx_Heater < heaters.Length && houses[idx_House] > heaters[idx_Heater] + radius)
                {
                    idx_Heater++;
                }

                if (idx_Heater < heaters.Length && heaters[idx_Heater] + radius >= houses[idx_House] && heaters[idx_Heater] - radius <= houses[idx_House])
                {
                    idx_House++;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
