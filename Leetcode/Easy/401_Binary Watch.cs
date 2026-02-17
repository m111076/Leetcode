using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _401_Binary_Watch
    {
        //time complexity O(1)
        //space complexity O(1)
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            var result = new List<string>();
            for (var h = 0; h < 12; h++)
            {
                for (var m = 0; m < 60; m++)
                {
                    if (BitCount(h) + BitCount(m) == turnedOn)
                    {
                        result.Add($@"{h}:{m:D2}");
                    }
                }
            }

            return result;
        }

        public int BitCount(int Number)
        {
            var result = 0;
            while (Number > 0)
            {
                Number &= Number - 1;
                result++;
            }

            return result;
        }
    }
}
