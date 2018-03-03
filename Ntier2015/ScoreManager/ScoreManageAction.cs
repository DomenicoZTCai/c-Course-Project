using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;



namespace Ntier2015.ScoreManager
{
    class ScoreManageAction : DAL.OleDbConn 
    {
        Score sc;
        public void setScore(Score sc)
        {
            this.sc = sc;
        }
        public static Hashtable getCourseList()
        {
            string sql = "select courseNo,courseName from Course order by courseNo";
            Hashtable ht = getHashtable(sql);
            return ht;
        }
        public static void getCourseList(Hashtable htCourseNo, Hashtable htCourseName,string workerNo)
        {
            string sql = "select c.courseNo,courseName from course c inner join teachcourse tc on tc.courseNo=c.courseNo where tc.workerNo='"+workerNo +"'";
            List<Object[]> list = executeReader(sql);
            if (list == null) return;
            foreach (Object[] o in list)
            {
                htCourseNo.Add(o[0].ToString(), o[1].ToString());
                htCourseName.Add(o[1].ToString(), o[0].ToString());
            }
        }
        public static void getCourseList(Hashtable htCourseNo, Hashtable htCourseName)
        {
            string sql = "select courseNo,courseName from Course order by courseNo";
            List<Object[]> list = executeReader(sql);
            if (list == null) return;
            foreach (Object[] o in list)
            {
                htCourseNo.Add(o[0].ToString(), o[1].ToString());
                htCourseName.Add(o[1].ToString(), o[0].ToString());
            }
        }
        public static void loadAllStudent(ListView lv)
        {
            string sql = "select * from student s, department  d where s.deptId=d.deptId";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }

        public static void loadAllStudent(ListView lv, string tcn)
        {
            string sql = "select s.studentNo as 学号, studentName as 姓名,grade as 成绩 from (student s ";
            sql += "inner join selectcourse sc on s.studentNo = sc.studentNo) inner join teachcourse tc on tc.teachCourseNo=sc.teachCourseNo where sc.teachcourseNo='"+tcn+"' ";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }

        public static void QueryScoreInfo(ListView lv, string sNo)
        {
            string sql = "select courseName,point,grade from (course c inner join teachcourse tc on c.courseNo=tc.courseNo) inner join selectcourse sc on tc.teachCourseNo=sc.teachCourseNo where studentNo='" + sNo + "'";
            ReaderToListView(lv, sql);
        }

       

        public static string  getCourseNo(string text, string workerNo)
        {
       
            string sql = "select teachcourseNo from teachcourse tc inner join course c on tc.courseNo=c.courseNo where tc.workerNo='" + workerNo + "'and c.courseName='"+text+"'";
            return (string)executeScalar(sql);
        }

        public static string getCourseName(string text)
        {
            string sql = "select courseName from course c inner join teachcourse tc on tc.courseNo=c.courseNo where tc.teachcourseNo='" + text + "'";
            return (string)executeScalar(sql);
        }

        

        public static int getClass(ListView lv,string s)
        {
            string sql = "";
            double sc = Double.Parse(s);
            if (sc >= 90)
                sql = "update selectcourse set class='优' where grade=" + s;
            else if (sc >= 80)
                sql = "update selectcourse set class='良' where grade=" + s;
            else if (sc >= 70)
                sql = "update selectcourse set class='中' where grade=" + s;
            else if (sc >= 60)
                sql = "update selectcourse set class='及格' where grade=" + s ;
            else if (sc < 60)
                sql = "update selectcourse set class='不及格' where grade=" + s;
            return execNonQuery(sql);
            
        }

        public static void scoreAnalysis(ListView lv, string tcn)
        {
            string sql = "select s.studentNo as 学号, studentName as 姓名,grade as 成绩,class as 等第 from (student s inner join selectcourse sc on s.studentNo = sc.studentNo) inner join teachcourse tc on tc.teachCourseNo=sc.teachCourseNo where sc.teachcourseNo='" + tcn + "' ";
            ReaderToListView(lv, sql);
        }

        
        
    }
}
