using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _118_Pascal_s_Triangle
    {
        //runtime 100%
        //time complexity O(n^2)
        //space complexity O(n^2)
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            for (var i = 0; i < numRows; i++)
            {
                var row = new List<int>();

                for (var j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(result[i - 1][j - 1] + result[i - 1][j]);
                    }
                }
                result.Add(row);
            }

            return result;
        }
    }
}
