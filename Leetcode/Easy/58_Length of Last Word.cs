using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _58_Length_of_Last_Word
    {
        public static int LengthOfLastWord(string s)
        {
            var tempList = new List<int>();
            var tempLength = 0;
            foreach (var c in s)
            {
                if (c.ToString() != " ")
                {
                    tempLength++;
                }
                else
                {
                    tempList.Add(tempLength);
                    tempLength = 0;
                }
            }

            tempList.Add(tempLength);
            tempList.RemoveAll(t => t == 0);

            return tempList.Last();

            //s = s.Trim();
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    if (s[i] == ' ')
            //    {
            //        return s.Substring(i + 1).Length;
            //    }
            //}
            //return s.Length;
        }
    }
}
