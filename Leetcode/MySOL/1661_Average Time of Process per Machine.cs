using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1661_Average_Time_of_Process_per_Machine
    {
        public void MySQL()
        {
            //select m1.machine_id ,round(avg(m2.timestamp - m1.timestamp), 3) as processing_time
            //from Activity as m1
            //join Activity as m2
            //on m1.machine_id = m2.machine_id
            //and m1.process_id = m2.process_id
            //and m1.activity_type = 'start'
            //and m2.activity_type = 'end'
            //group by m1.machine_id
        }
    }
}
