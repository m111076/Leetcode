using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3160_Find_the_Number_of_Distinct_Colors_Among_the_Balls
    {
        public int[] QueryResults(int limit, int[][] queries)
        {
            //Time Limit Exceeded= =
            var result = new int[queries.Length];
            //紀錄顏色次數
            var colorDic = new Dictionary<int, int>();
            //記錄球的顏色
            var ballDic = new Dictionary<int, int>();

            for (var i = 0; i < queries.Length; i++)
            {
                var query = queries[i];
                var ballIdx = query[0];
                var color = query[1];
                var preColor = ballDic.TryGetValue(ballIdx, out var colorVal) ? colorVal : 0;

                if (preColor > 0)
                {
                    if (--colorDic[preColor] == 0)
                        colorDic.Remove(preColor);
                    ballDic[ballIdx] = color;
                }
                else
                {
                    ballDic.Add(ballIdx, color);
                }
                if (colorDic.ContainsKey(color))
                    colorDic[color]++;
                else
                    colorDic.Add(color, 1);

                result[i] = colorDic.Count();
            }

            return result;
        }
    }
}
