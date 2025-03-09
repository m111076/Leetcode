using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0434_Number_of_Segments_in_a_String
    {
        public static int CountSegments(string s)
        {
            //runtime 100%
            //要注意一堆空白 split完為stringEmpty
            if (s == null) return 0;
            if (s == string.Empty) return 0;

            var tmp = s.Split(' ');
            var cnt = 0;

            foreach (var segment in tmp)
            {
                if (segment != string.Empty)
                    cnt++;
            }
            return cnt;

        }
    }
}
