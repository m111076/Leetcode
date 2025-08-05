using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1075_Project_Employees_I
    {
        //select p.project_id, round(sum(experience_years)/count(experience_years),2) as average_years
        //from Project as p
        //join Employee as e
        //on p.employee_id = e.employee_id
        //group by project_id
    }
}
