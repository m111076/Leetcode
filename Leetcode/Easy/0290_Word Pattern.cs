using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0290_Word_Pattern
    {
        public bool WordPattern(string pattern, string s)
        {
            //runtime 100%
            var target = s.Split(" ");
            var tmpDic = new Dictionary<char, string>();
            var charCnt = pattern.Length;

            if (target.Length != charCnt)
                return false;

            for (var i = 0; i < charCnt; i++)
            {
                if (!tmpDic.ContainsKey(pattern[i]))
                {
                    if (tmpDic.ContainsValue(target[i]))
                        return false;
                    tmpDic.Add(pattern[i], target[i]);
                }
                else
                {
                    if (tmpDic[pattern[i]] != target[i])
                        return false;
                }

                //var t = tmpDic.Where(s => s.Value == target[i]).Where(s => s.Key != pattern[i]).Count();
                //if (t > 0)
                //    return false;
            }
            return true;
        }
    }
}
