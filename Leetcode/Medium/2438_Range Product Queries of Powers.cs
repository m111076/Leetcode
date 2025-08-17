using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2438_Range_Product_Queries_of_Powers
    {
        public int[] ProductQueries(int n, int[][] queries)
        {
            var mod = 1000000007;
            var powers = new List<long>();
            while (n > 0)
            {
                var lowBit = n & -n;
                powers.Add(lowBit);
                n ^= lowBit;
            }

            var result = new int[queries.Length];

            for (var i = 0; i < queries.Length; i++)
            {
                var tmp = queries[i];
                var product = 1L;

                for (var j = tmp[0]; j <= tmp[1]; j++)
                {
                    product = (product * powers[j]) % mod;
                }

                result[i] = (int)product;
            }

            return result;
        }
    }
}
