using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _3494_Find_the_Minimum_Amount_of_Time_to_Brew_Potions
    {
        public static long MinTime(int[] skill, int[] mana)
        {
            //runtime88%
            //分別計算每個法師完成後下輪後可以開始的時間，並且紀錄最大值
            //求得最後一輪的開始時間後，再加上最後一輪的時間
            var mLength = mana.Length;
            var sLength = skill.Length;
            var time = 0L;
            var tmpMax = 0L;
            var progressivelySkill = new long[sLength + 1];

            for (int i = 0; i < sLength; i++)
            {
                progressivelySkill[i + 1] = progressivelySkill[i] + skill[i];
            }

            for (int j = 0; j < mLength - 1; j++)
            {
                tmpMax = 0;

                for (int i = 0; i < sLength; i++)
                {
                    tmpMax = Math.Max(tmpMax, time + mana[j] * progressivelySkill[i + 1] - mana[j + 1] * progressivelySkill[i]);
                }

                time = tmpMax;
            }

            return time + mana[mLength - 1] * progressivelySkill[sLength];

            //Output Limit Exceeded
            //var dp = new long[mana.Length + 1, skill.Length + 1];
            //var tmpSkill = new long[skill.Length + 1];

            //for (int i = 0; i < skill.Length; i++)
            //{
            //    tmpSkill[i + 1] = tmpSkill[i] + skill[i];
            //}

            //for (var i = 1; i < mana.Length; i++)
            //{
            //    for (var j = 1; j <= skill.Length; j++)
            //    {
            //        dp[i, j] = dp[i, j - 1] + mana[i - 1] * skill[j - 1];

            //        dp[i + 1, 0] = Math.Max(dp[i + 1, 0], dp[i, j] - tmpSkill[j - 1] * mana[i]);
            //    }

            //}

            //void extra(int iSkillIdx, int iManaIdx, long iSec)
            //{
            //    for (var i = iSkillIdx; i > 0; i--)
            //    {
            //        dp[iManaIdx, i] += iSec;
            //    }
            //}

            //for (var i = 0; i <= mana.Length; i++)
            //{
            //    for (var j = 0; j <= skill.Length; j++)
            //    {
            //        Console.Write(dp[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //return dp[mana.Length, 0] + mana[mana.Length - 1] * tmpSkill[skill.Length];

        }
    }
}
