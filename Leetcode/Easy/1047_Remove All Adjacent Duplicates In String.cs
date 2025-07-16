using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1047_Remove_All_Adjacent_Duplicates_In_String
    {
        //runtime 44%
        //time compexity O()
        //space complexity O()
        public string RemoveDuplicates(string s)
        {
            var charStack = new Stack<char>();

            foreach (char c in s)
            {
                if (charStack.TryPeek(out var last))
                {
                    if (last == c)
                    {
                        charStack.Pop();
                    }
                    else
                    {
                        charStack.Push(c);
                    }
                }
                else
                {
                    charStack.Push(c);
                }
            }

            var result = new StringBuilder();

            foreach (char c in charStack.Reverse())
            {
                result.Append(c);
            }

            return result.ToString();
        }
    }
}
