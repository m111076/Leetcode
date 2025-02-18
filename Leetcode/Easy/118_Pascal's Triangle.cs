using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _118_Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            for (var i = 1; i <= numRows; i++)
            {
                var tempList = new List<int>();
                tempList.Add(1);
                if (i != 1)
                {
                    var target = result.Last();

                    for (var j = 0; j < target.Count - 1; j++)
                    {
                        tempList.Add(target[j] + target[j + 1]);
                    }
                    tempList.Add(1);
                }
                result.Add(tempList);
            }
            return result;
        }
    }
}
