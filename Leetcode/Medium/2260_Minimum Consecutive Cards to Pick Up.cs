using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2260_Minimum_Consecutive_Cards_to_Pick_Up
    {
        //runtime 97%
        //time complexity O(n)
        //space complexity O(n)
        //在字典中記錄各數字第一次出現的位置
        //當再次出現時，計算兩次出現的距離，並且更新位置
        public int MinimumCardPickup(int[] cards)
        {
            var map = new Dictionary<int, int>();
            var result = int.MaxValue;
            for (var i = 0; i < cards.Length; i++)
            {
                if (map.ContainsKey(cards[i]))
                {
                    result = Math.Min(result, i - map[cards[i]] + 1);
                }
                map[cards[i]] = i;
            }
            return result == int.MaxValue ? -1 : result;
        }
    }
}
