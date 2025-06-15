using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3582_Generate_Tag_for_Video_Caption
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public string GenerateTag(string caption)
        {
            var idx = 1;
            var isFirst = true;
            var isBegin = true;
            var result = new StringBuilder();
            result.Append('#');

            foreach (var c in caption)
            {
                if (Char.IsLetter(c))
                {
                    var target = c;

                    if (isFirst)
                    {
                        target = Char.ToLower(c);
                        isFirst = false;
                    }
                    else if (isBegin)
                    {
                        target = Char.ToUpper(c);
                    }
                    else
                    {
                        target = Char.ToLower(c);

                    }

                    result.Append(target);
                    if (++idx == 100)
                        break;

                    isBegin = false;
                }
                else
                {
                    isBegin = true;
                }
            }
            return result.ToString();
        }

    }
}
