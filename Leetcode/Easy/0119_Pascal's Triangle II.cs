using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _119_Pascal_s_Triangle_II
    {
        public IList<int> GetRow(int rowIndex)
        {
            //Runtime 100% Memory 43.68%
            //頭尾一定是1，前項兩兩相加等於中間的部分
            var result = new List<int> { 1 };

            for (var i = 0; i < rowIndex; i++)
            {
                var tempResult = new List<int>();
                tempResult.Add(1);

                for (var j = 1; j < result.Count; j++)
                {
                    tempResult.Add(result[j - 1] + result[j]);
                }

                tempResult.Add(1);

                result = tempResult;
            }

            return result;

            //Runtime 100% Memory 14.08%
            //var result = new List<int> { 1 };

            //for (var i = 0; i < rowIndex; i++)
            //{
            //    var val = 0;

            //    for (var j = 0; j < result.Count; j++)
            //    {
            //        var temp = result[j];
            //        result[j] += val;
            //        val = temp;
            //    }
            //    result.Add(1);
            //}

            //return result;

        }
    }
}
