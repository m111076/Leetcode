using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _2451_Odd_String_Difference
    {
        public static string OddString(string[] words)
        {
            var dic = new Dictionary<List<int>, List<string>>();

            foreach (var word in words)
            {
                var tmp = new List<int>();

                for (var i = 1; i < word.Length; i++)
                {
                    tmp.Add(word[i] - word[i - 1]);
                }

                if (dic.ContainsKey(tmp))
                    dic[tmp].Add(word);
                else
                    dic.Add(tmp, new List<string>() { word });
            }

            foreach (var d in dic)
            {
                if (d.Value.Count == 1)
                    return d.Value[0];
            }

            return words[0];
        }
    }
}
