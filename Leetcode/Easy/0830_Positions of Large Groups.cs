using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0830_Positions_of_Large_Groups
    {
        //runtiem 100%
        //time complexity O(n)
        //sapce complexity O(1)
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            var result = new List<IList<int>>();
            var target = '$';
            var cnt = 1;

            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];

                if (c != target)
                {
                    if (cnt >= 3)
                    {
                        result.Add(new List<int> { i - cnt, i - 1 });
                    }
                    target = c;
                    cnt = 1;
                }
                else
                {
                    cnt++;
                }
            }

            if (cnt >= 3)
            {
                result.Add(new List<int> { s.Length - cnt, s.Length - 1 });
            }

            return result;
        }
    }
}
