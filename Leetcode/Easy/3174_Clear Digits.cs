using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _3174_Clear_Digits
    {
        public static string ClearDigits(string s)
        {
            var isFinish = false;
            while (!isFinish)
            {
                isFinish = true;

                for (var i = 0; i < s.Length; i++)
                {
                    if (Char.IsNumber(s[i]))
                    {
                        if (i == 0)
                        {
                            s.Remove(i, 1);
                            isFinish = false;
                            break;
                        }
                        else
                        {
                            s = s.Remove(i - 1, 1);
                            s = s.Remove(i - 1, 1);
                            isFinish = false;
                            break;
                        }

                    }
                }
            }
            return s;
        }
    }
}
