using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2800_Shortest_String_That_Contains_Three_Strings
    {
        public static string MinimumString(string a, string b, string c)
        {
            if (string.Compare(a, b) > 0)
            {
                if (string.Compare(b, c) > 0)
                {
                    var tmp = LCS(c, b);
                    var result = LCS(tmp, a);
                    return result;
                }
                else
                {
                    if (string.Compare(a, c) > 0)
                    {
                        var tmp = LCS(b, c);
                        var result = LCS(tmp, a);
                        return result;
                    }
                    else
                    {
                        var tmp = LCS(b, a);
                        var result = LCS(tmp, c);
                        return result;
                    }
                }
            }
            else
            {
                if(string.Compare(a, c) > 0)
                {
                    var tmp = LCS(c, a);
                    var result = LCS(tmp, b);
                    return result;
                }
                else
                {
                    if (string.Compare(b, c) > 0)
                    {
                        var tmp = LCS(a, c);
                        var result = LCS(tmp, b);
                        return result;
                    }
                    else
                    {
                        var tmp = LCS(a, b);
                        var result = LCS(tmp, c);
                        return result;
                    }
                }
            }


            //var tmp = LCS(a, b);
            //var result = LCS(tmp, c);
            //return result;
        }

        public static string LCS(string str1, string str2)
        {
            var s1Length = str1.Length;
            var s2Length = str2.Length;
            var dp = new int[s1Length + 1, s2Length + 1];

            for (var i = 1; i <= s1Length; i++)
            {
                for (var j = 1; j <= s2Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            var result = string.Empty;

            while (s1Length > 0 && s2Length > 0)
            {
                if (str1[s1Length - 1] == str2[s2Length - 1])
                {
                    result += str1[s1Length - 1];
                    s1Length--;
                    s2Length--;
                }
                else if (dp[s1Length - 1, s2Length] > dp[s1Length, s2Length - 1])
                {
                    result += str1[s1Length - 1];
                    s1Length--;
                }
                else
                {
                    result += str2[s2Length - 1];
                    s2Length--;
                }
            }

            while (s1Length > 0)
            {
                result += str1[s1Length - 1];
                s1Length--;
            }

            while (s2Length > 0)
            {
                result += str2[s2Length - 1];
                s2Length--;
            }

            return new string(result.Reverse().ToArray());
        }
    }
}
