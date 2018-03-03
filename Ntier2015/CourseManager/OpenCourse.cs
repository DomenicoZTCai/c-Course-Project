using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier2015.CourseManager
{
    public class OpenCourse:Course
    {
        public string teachCourseNo,teacher;
        public int startWeek, endWeek,amount;

        public OpenCourse(string teachCourseNo, string courseName, string teacher,int amount, int startWeek, int endWeek)
        {
            this.teachCourseNo = teachCourseNo; this.courseName = courseName; this.endWeek = endWeek; this.startWeek = startWeek;
            this.teacher = teacher;this.amount =amount ;
        }
    }
}
