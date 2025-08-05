using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1633_Percentage_of_Users_Attended_a_Contest
    {
        //select r.contest_id, round(count(r.user_id)*100/(select count(*) from Users ),2) as percentage
        //from Register as r
        //group by r.contest_id
        //order by count(r.user_id ) desc, contest_id asc;
    }
}
