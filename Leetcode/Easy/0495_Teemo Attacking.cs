using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0495_Teemo_Attacking
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            //runtime 96%
            //確認前一次+持續時間是否有超過下一次攻擊，若有超過則減去超過的值再加持續時間
            var pre = -1;
            var result = 0;

            for (var i = 0; i < timeSeries.Length; i++)
            {
                if (pre != -1)
                {
                    if (pre + duration > timeSeries[i])
                    {
                        result -= pre + duration - timeSeries[i];
                    }
                }
                result += duration;
                pre = timeSeries[i];
            }

            return result;
        }
    }
}
