using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2300_Successful_Pairs_of_Spells_and_Potions
    {
        //runtime 84%
        //time complexity O(nlogn)
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            var result = new int[spells.Length];
            Array.Sort(potions);

            for (int i = 0; i < spells.Length; i++)
            {
                result[i] = potions.Length - BinarySearch(potions, spells[i], success);
            }

            return result;
        }

        private int BinarySearch(int[] potions, long spells, long success)
        {
            var left = 0;
            var right = potions.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (potions[mid] * spells >= success)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}
