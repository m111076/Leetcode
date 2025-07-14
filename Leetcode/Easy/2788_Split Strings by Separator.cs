using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2788_Split_Strings_by_Separator
    {
        //runtime 54%
        //time complexity O()
        //space complexity O()
        public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            var result = new List<string>();
            var tmp = new StringBuilder();

            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (c == separator)
                    {
                        if (tmp.Length > 0)
                        {
                            result.Add(tmp.ToString());
                            tmp.Clear();
                        }
                    }
                    else
                    {
                        tmp.Append(c);
                    }
                }

                if (tmp.Length > 0)
                {
                    result.Add(tmp.ToString());
                    tmp.Clear();
                }
            }

            return result;
        }
    }
}
