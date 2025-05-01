using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _0904_Fruit_Into_Baskets
    {
        public static int TotalFruit(int[] fruits)
        {
            //runtime 49%
            var left = 0;
            var right = 0;
            var result = 0;
            var dic = new Dictionary<int, int>();

            while (right < fruits.Length)
            {
                if (!dic.ContainsKey(fruits[right]))
                    dic.Add(fruits[right], 0);
                dic[fruits[right]]++;

                while (dic.Count > 2)
                {
                    dic[fruits[left]]--;
                    if (dic[fruits[left]] == 0)
                        dic.Remove(fruits[left]);
                    left++;
                }

                result = Math.Max(result, right - left + 1);

                right++;
            }

            return result;

            //runtime 39%
            //time complexity O(n)
            //var left = 0;
            //var right = 0;
            //var result = 0;
            //var dic = new Dictionary<int, int>();

            //while (right < fruits.Length)
            //{
            //    if (!dic.ContainsKey(fruits[right]) && dic.Count + 1 > 2)
            //    {
            //        var target = fruits[left++];
            //        dic[target]--;
            //        if (dic[target] == 0)
            //            dic.Remove(target);
            //    }
            //    else
            //    {
            //        if (dic.ContainsKey(fruits[right]))
            //            dic[fruits[right]]++;
            //        else
            //            dic.Add(fruits[right], 1);
            //        result = Math.Max(result, right - left + 1);
            //        right++;
            //    }
            //}

            //return result;
        }
    }
}
