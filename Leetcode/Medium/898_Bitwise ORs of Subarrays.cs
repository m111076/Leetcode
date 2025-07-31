using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _898_Bitwise_ORs_of_Subarrays
    {
        public int SubarrayBitwiseORs(int[] arr)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
                for (var j = i - 1; j >= 0; j--)
                {
                    if ((arr[j] | arr[i]) == arr[j])
                        break;
                    arr[j] |= arr[i];
                    set.Add(arr[j]);
                }
            }

            return set.Count;
        }
    }
}
