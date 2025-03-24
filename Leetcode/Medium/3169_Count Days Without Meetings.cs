using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3169_Count_Days_Without_Meetings
    {
        public int CountDays(int days, int[][] meetings)
        {
            //runtime 100%
            //先將會議依照開始時間排序
            //比較後項的開始時間是否小於等於前項的結束時間
            //若是則更新結束時間
            //若否則更新沒有會議的天數
            //最後減去最後一個會議天數
            Array.Sort(meetings, (a, b) => a[0] - b[0]);
            var begin = meetings[0][0];
            var end = meetings[0][1];

            for (var i = 1; i < meetings.Length; i++)
            {
                if (meetings[i][0] <= end)
                {
                    end = Math.Max(end, meetings[i][1]);
                }
                else
                {
                    days -= end - begin + 1;
                    begin = meetings[i][0];
                    end = meetings[i][1];
                }
            }

            return days - end + begin - 1;

            //TLE
            //var meetingDays = new HashSet<int>();

            //foreach (var meeting in meetings)
            //{
            //    for (var i = meeting[0]; i <= meeting[1]; i++)
            //    {
            //        meetingDays.Add(i);
            //    }
            //}

            //return days - meetingDays.Count;
        }
    }
}
