using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1211_Queries_Quality_and_Percentage
    {
        //select query_name,
        //round(sum(rating / position) / count(position), 2) as quality, 
        //round(sum(case when rating<3 then 1 else 0 end)/count(rating)*100,2) as poor_query_percentage
        //from Queries
        //group by query_name;
    }
}
