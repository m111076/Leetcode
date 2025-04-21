using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1207_Unique_Number_of_Occurrences
    {
        //runtime 93%
        //time complexity O(n)
        //space complexity O(n)
        //先跑過一次將各個數字出現的次數記錄下來
        //再將出現的次數放入HashSet中
        //如果HashSet中已經有這個數字了，則代表出現的次數不唯一
        public bool UniqueOccurrences(int[] arr)
        {
            var map = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map[num] = 1;
                }
            }
            var occurrences = new HashSet<int>();
            foreach (var count in map.Values)
            {
                if (!occurrences.Add(count))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
