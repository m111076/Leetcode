using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1415_The_k_th_Lexicographical_String_of_All_Happy_Strings_of_Length_n
    {
        public static string GetHappyString(int n, int k)
        {
            //最佳解?
            //var total = 3 * (1 << (n - 1));

            //if (k > total)
            //{
            //    return string.Empty;
            //}

            //var stringBuilder = new StringBuilder();

            //var current = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    if (current + (1 << (n - 1)) >= k)
            //    {
            //        stringBuilder.Append((char)('a' + i));
            //        break;
            //    }
            //    current += 1 << (n - 1);
            //}

            //for (int i = 1; i < n; i++)
            //{
            //    if (current + (1 << (n - i - 1)) >= k)
            //    {
            //        stringBuilder.Append(stringBuilder[^1] == 'a' ? 'b' : 'a');
            //    }
            //    else
            //    {
            //        stringBuilder.Append(stringBuilder[^1] == 'c' ? 'b' : 'c');
            //        current += 1 << (n - i - 1);
            //    }
            //}

            //return stringBuilder.ToString();


            //效率太差了
            var option = new Dictionary<char, string>();
            var result = new List<string>();
            option.Add('a', "a");
            option.Add('b', "b");
            option.Add('c', "c");


            foreach (var op in option.Keys)
            {
                var subResult = "";
                var cnt = n;
                subResult += op;
                dft(subResult, --cnt);
            }

            if (result.Count < k)
            {
                return "";
            }
            else
            {
                return result[k - 1];
            }

            void dft(string iString, int iCnt)
            {
                if (iCnt == 0)
                {
                    result.Add(iString);
                    return;
                }

                foreach (var op in option.Keys)
                {
                    var tempStr = iString;
                    var tempCnt = iCnt;

                    if (iString.Last() != op)
                    {
                        tempStr += op;
                        dft(tempStr, --tempCnt);
                    }
                }
            }
        }
    }
}
