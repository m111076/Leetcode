using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3612_Process_String_with_Special_Operations_I
    {
        //runtime 100%
        //time complexity O(2^n)
        //space complexity O(1)
        public string ProcessStr(string s)
        {
            var result = new StringBuilder();

            foreach (var item in s)
            {
                if (item == '*')
                {
                    if (result.Length > 0)
                    {
                        result.Remove(result.Length - 1, 1);
                    }
                }
                else if (item == '#')
                {
                    if (result.Length > 0)
                    {
                        result.Append(result);
                    }
                }
                else if (item == '%')
                {
                    if (result.Length > 0)
                    {
                        var halfLength = result.Length / 2;
                        
                        for (var idx = 0; idx < halfLength; idx++)
                        {
                            var tmp = result[idx];
                            result[idx] = result[result.Length - 1 - idx];
                            result[result.Length - 1 - idx] = tmp;
                        }
                    }
                }
                else
                {
                    result.Append(item);
                }
            }
            return result.ToString();
        }
    }
}
