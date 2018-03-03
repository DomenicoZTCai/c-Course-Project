using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier2015.CourseManager
{
    public class Course
    {
        public string courseNo, courseName;
        public float point;
        public int startWeek, endWeek;
        public string mon, tue, wed, thur, fri;
        public bool validInTimetable = true;

        public Course(string courseNo, string courseName, float point)
        {
            this.courseNo = courseNo; this.courseName = courseName;this.point = point;
        }

        public Course(string courseName, string mon, string tue ,string wed,string thur,string fri,int startWeek, int endWeek)
        {
            this.courseName = courseName; this.startWeek = startWeek; this.endWeek = endWeek;
            this.mon = mon; this.tue = tue; this.wed = wed; this.thur = thur; this.fri = fri;
        }

        public Course()
        { }

        public string getIntoGridView()
        {
            return courseName + "(" + startWeek.ToString() + "-" + endWeek.ToString() + ")";
        }

    }
}
