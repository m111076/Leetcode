using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1141_User_Activity_for_the_Past_30_Days_I
    {
        //select activity_date as day,count(distinct user_id) as active_users from Activity
        //where activity_date between date_sub('2019-07-27' , interval 29 day) and '2019-07-27'
        //group by activity_date;
    }
}
