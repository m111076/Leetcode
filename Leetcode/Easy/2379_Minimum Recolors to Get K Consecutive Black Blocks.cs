using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2379_Minimum_Recolors_to_Get_K_Consecutive_Black_Blocks
    {
        public static int MinimumRecolors(string blocks, int k)
        {
            //runtime 100%
            //每滑動一次確認移出的跟加入的
            var length = blocks.Length;
            var result = int.MaxValue;
            var B = 0;

            for (var i = 0; i < length; i++)
            {
                if (i - k >= 0 && blocks[i - k] == 'B')
                    B--;
                if (blocks[i] == 'B')
                    B++;
                result = Math.Min(result, k - B);
            }
            return result;

            //runtime 24%
            //sliding window
            //var length = blocks.Length;
            //var max = length - k;
            //var result = int.MaxValue;

            //for (var i = 0; i <= max; i++)
            //{
            //    var tmp = blocks.Substring(i, k);
            //    var w = tmp.Count(c => c == 'W');
            //    result = Math.Min(result, w);
            //}
            //return result;
        }
    }
}
