﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1280_Students_and_Examinations
    {
        public void MySQL()
        {
            //select s.student_id ,s.student_name ,sub.subject_name ,count(e.student_id) as attended_exams
            //from Students as s
            //cross join Subjects as sub
            //left join Examinations as e
            //on s.student_id = e.student_id
            //and sub.subject_name = e.subject_name
            //group by s.student_id ,s.student_name, sub.subject_name
            //order by s.student_id ,s.student_name, sub.subject_name;
        }
    }
}
