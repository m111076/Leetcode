using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3477_Fruits_Into_Baskets_II
    {
        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            var result = 0;
            foreach (var fruit in fruits)
            {
                for (int i = 0; i < baskets.Length; i++)
                {
                    if (baskets[i] >= fruit)
                    {
                        result++;
                        baskets[i] = 0;
                        break;
                    }
                }

            }

            return fruits.Length - result;
        }
    }
}
