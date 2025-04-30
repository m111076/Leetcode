using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0904_Fruit_Into_Baskets
    {
        public int TotalFruit(int[] fruits)
        {
            var left = 0;
            var right = 0;
            var result = 0;
            var dic = new Dictionary<int, int>();

            while (right < fruits.Length)
            {
                if (!dic.ContainsKey(fruits[right]) && dic.Count + 1 > 2)
                {

                }
                else
                {
                    dic[fruits[right]]++;
                }
            }
        }
    }
}
