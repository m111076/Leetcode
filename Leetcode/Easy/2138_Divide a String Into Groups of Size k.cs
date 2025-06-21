using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2138_Divide_a_String_Into_Groups_of_Size_k
    {
        public string[] DivideString(string s, int k, char fill)
        {
            //測試用
            //var remainder = s.Length % k;
            //var newLength = s.Length + (remainder == 0 ? 0 : k - remainder);

            //Span<char> buffer = stackalloc char[newLength];  // 分配在 stack，效能好
            //s.AsSpan().CopyTo(buffer);

            //// 補足填充字元
            //for (int i = s.Length; i < newLength; i++)
            //{
            //    buffer[i] = fill;
            //}

            //var result = new string[newLength / k];

            //for (int i = 0; i < result.Length; i++)
            //{
            //    result[i] = new string(buffer.Slice(i * k, k));
            //}

            //return result;

            //runtime 68%
            //time complexity O(n)
            //space complexity O(n/k)
            var tmp = s.Length % k;

            if (tmp != 0)
                s = s.PadRight(s.Length + k - tmp, fill);

            tmp = s.Length / k;

            var result = new string[tmp];

            for (var i = 0; i < tmp; i++)
            {
                result[i] = s.Substring(i * k, k);
            }

            return result;
        }
    }
}
