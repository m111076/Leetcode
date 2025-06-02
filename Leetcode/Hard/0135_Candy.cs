using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _0135_Candy
    {
        //runtime 22%
        //time complexity O(n)
        //space complexity O(n)
        public int Candy(int[] ratings)
        {
            var tmp = new int[ratings.Length];
            Array.Fill(tmp, 1);


            for (int i = 1; i < tmp.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    tmp[i] = tmp[i - 1] + 1;
            }

            for (int i = tmp.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                    tmp[i] = Math.Max(tmp[i], tmp[i + 1] + 1);
            }

            return tmp.Sum();
        }
    }
}
