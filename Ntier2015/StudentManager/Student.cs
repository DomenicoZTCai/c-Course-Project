using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Ntier2015.StudentManager
{
    public class Student
    {
        public String studentNo, studentName, sex, birthday, deptId;
        public Student(string sNo, string sName, string sex,string birthday,string deptId)
        {
            studentNo = sNo; studentName = sName; this.sex = sex;
            this.deptId = deptId; this.birthday = birthday;
        }
        public Student()
        {
        }
        public int selectCourse(string tcno)
        {
            return StudentManageAction.selectCourse(studentNo, tcno);
        }
        public int deselectCourse(string tcno)
        {
            return StudentManageAction.deselectCourse(studentNo, tcno);
        }

        public void loadSelectCourse(ListView lv)
        {
            StudentManageAction.loadSelectedCourse(lv, studentNo);
        }
        public void loadUnselectCourse(ListView lv)
        {
            StudentManageAction.loadUnselectedCourse(lv, studentNo);
        }
        public void loadSelectedCourseToTimetable(DataGridView dt)
        {
            StudentManageAction.loadSelectedCourseToTimetable(dt, studentNo);
        }
        public void loadMyTimetable(ListView lv)
        {
            StudentManageAction.loadMyTimetable(lv, studentNo);
        }

        public void loadCompulsoryCourse(ListView lv)
        {
            StudentManageAction.loadCompulsoryCourse(lv, deptId);
        }//fede

        public void loadSelectedCompulsoryCourse(ListView lv, Hashtable ht)
        {
            StudentManageAction.loadSelectedCompulsoryCourse(lv, ht);
        }//Dome 16.1.7

        public void loadSelectedCompulsoryCourse(ListView lv, string cNo)
        {
            StudentManageAction.loadSelectedCompulsoryCourse(lv, cNo);
        }
    }
}
