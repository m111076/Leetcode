using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _0049_Group_Anagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            //runtime 49%
            var resultDic = new Dictionary<string, IList<string>>();

            foreach (var s in strs)
            {
                var c = s.ToCharArray();
                Array.Sort(c);
                var target = new string(c);

                if (resultDic.TryGetValue(target, out var list))
                {
                    list.Add(s);
                }
                else
                {
                    resultDic.Add(target, new List<string>() { s });
                }
            }

            return new List<IList<string>>(resultDic.Values);

            //runtime 5%
            //var result = new List<IList<string>>();
            //var arrs = new List<int[]>();

            //foreach (var str in strs)
            //{
            //    var cArrays = new int[26];
            //    foreach (var c in str)
            //    {
            //        cArrays[c - 'a']++;
            //    }

            //    var isMatch = false;

            //    for (var i = 0; i < arrs.Count; i++)
            //    {
            //        isMatch = true;

            //        for (var j = 0; j < 26; j++)
            //        {
            //            if (arrs[i][j] != cArrays[j])
            //            {
            //                isMatch = false;
            //                break;
            //            }
            //        }

            //        if (isMatch)
            //        {
            //            result[i].Add(str);
            //            break;
            //        }
            //    }

            //    if (!isMatch)
            //    {
            //        arrs.Add(cArrays);
            //        result.Add(new List<string>() { str });
            //    }
            //}

            //return result;
        }
    }
}
