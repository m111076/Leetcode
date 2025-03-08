using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0401_Binary_Watch
    {
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            //runtime 88%
            //bitcount
            var result = new List<string>();
            for (var m = 0; m < 60; m++)
            {
                for (var h = 0; h < 12; h++)
                {
                    if (HammingWeight(m) + HammingWeight(h) == turnedOn)
                        result.Add($@"{h}:{m:D2}");
                }
            }

            return result;

            int HammingWeight(int iTarget)
            {
                var res = 0;
                while (iTarget != 0)
                {
                    iTarget &= (iTarget - 1);
                    res++;
                }
                return res;
            }
        }

    }
}
