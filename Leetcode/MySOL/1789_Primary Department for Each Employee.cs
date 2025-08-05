using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1789_Primary_Department_for_Each_Employee
    {
        //select employee_id, department_id from Employee
        //where
        //primary_flag = 'Y'
        //or
        //employee_id in (select employee_id from Employee group by employee_id having count(employee_id)=1)

        //或是

        //select employee_id, department_id from Employee
        //where primary_flag = 'Y'
        //union
        //select employee_id,department_id from Employee
        //group by employee_id
        //having count(employee_id)=1

    }
}
