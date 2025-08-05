using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1731_The_Number_of_Employees_Which_Report_to_Each_Employee
    {
        //select e.employee_id, e.name, count(r.reports_to) as reports_count, round(avg(r.age ),0) as average_age
        //from Employees e
        //join Employees r
        //on e.employee_id = r.reports_to
        //group by employee_id
        //order by employee_id
    }
}
