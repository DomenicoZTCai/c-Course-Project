using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Ntier2015.CourseManager
{
    class CourseManageAction : DAL.OleDbConn 
    {
        Course course;
        public void setCourse(Course c)
        {
            this.course=c;
        }

        OpenCourse oc;
        public void setOpenCourse(OpenCourse oc)
        {
            this.oc = oc;
        }
        //选课表
        public static void loadAllCourse(ListView lv)
        {
            string sql = " select CourseNo as 课程号,CourseName as 课程名称,point as 学分 from course ";
            ReaderToListView(lv, sql);
        }

        //模糊匹配查找
        public static void loadAllCourse(ListView lv, string courseNo, string courseName)
        {
            string sql = " select courseNo as 课程号,courseName as 课程名称,point as 学分 from course where 1=1 ";
            if(!courseNo.Equals(""))
                sql += " and courseNo like '%" + courseNo + "%' ";
            if(!courseName.Equals(""))
                sql += " and courseName like '%" + courseName + "%' ";
            ReaderToListView(lv, sql);
        }

        //查询表course，根据课程号查课程名
        public static string QuerycourseName(string cNo)
        {
            string sql = "select courseName from course where courseNo= '" + cNo + "'";
            return (string)executeScalar(sql);
        }

        //查询表course，根据课程名查课程号
        public static string QuerycourseNo(string cName)
        {
            string sql = "select courseNo from course where courseName='" + cName + "'";
            return (string)executeScalar(sql);
        }

        //根据课程号查课程信息
        public static Course QueryCourseInfo(string cNo)
        {
            string sql = "select courseNo,courseName,point from course " +
                "where courseNo = '" + cNo + "'";
            ArrayList ll = execQuery(sql);  //调用父类方法
            if (ll.Count == 0) return null;
            object[] o = (object[])ll[0];
            Course c = new Course(o[0].ToString(), o[1].ToString(), float.Parse(o[2].ToString()));
            return c;
        }

        //添加一条课程记录到course表
        public static int addCourse(Course c)
        {
            string sql = " insert into course(courseNo,courseName,point) "
            +"values('" + c.courseNo + "','" + c.courseName + "','" + c.point +"')";
            return execNonQuery(sql);
        }
        public int addCourse()
        {
            return addCourse(course);
        }

        //删除表Course中的一条课程记录
        public static int delCourse(string cNo)
        {
            string sql = " delete from course where courseNo = '" +
                cNo + "'";
            return execNonQuery(sql);
        }

        //开课表(Search Course Form)
        public static void loadOpenCourse(ListView lv,string cNo)
        {
            string sql = " select tc.teachCourseNo as 开课号,courseName as 课程名称,workername as 任课教师,amount as 容纳人数 from (teachcourse tc"
                + " inner join course c on c.courseNo=tc.courseNo)"
                + " inner join teacher t on t.workerNo=tc.workerNo"
                + " where c.courseNo ='" + cNo + "'";
            ReaderToListView(lv, sql);
        }

        //删除表teachcourse中的一条课程记录
        public static int delopenCourse(string cNo)
        {
            string sql = " delete from teachcourse where teachcourseNo = '" +
                cNo + "'";
            return execNonQuery(sql);
        }

        //添加一条课程记录到teachcourse表
        public static int addOpenCourse(OpenCourse oc)
        {
            string wn = QueryWorkerNo(oc.teacher);
            string cn = QuerycourseNo(oc.courseName);
            string sql = " insert into teachcourse(teachcourseNo,courseNo,workerNo,amount,startWeek,endWeek) "
            + "values('" + oc.teachCourseNo + "','" + cn + "','" + wn + "','" + oc.amount + "','" + oc.startWeek + "','" + oc.endWeek + "')";
            return execNonQuery(sql);
        }
        public int addOpenCourse()
        {
            return addOpenCourse(oc);
        }

        //更新一条记录到course表
        public static int updateCourse(Course c)
        {
            string sql = "update Course set courseName= '" + c.courseName;
            sql += "',point='" + c.point + "'";
            sql += " where courseNo='" + c.courseNo + "'";
            return execNonQuery(sql);
        }
        public int updateCourse()
        {
            return updateCourse(course);
        }

        //根据开课号查询开课信息
        public static OpenCourse QueryOpenCourseInfo(string tcNo)
        {
            string sql = "select teachCourseNo,courseName,workerName,amount,startWeek,endWeek from (teachcourse tc"
                + " inner join teacher t on tc.workerNo=t.workerNo)"
                + " inner join course c on c.courseNo=tc.courseNo"
                + " where teachCourseNo='" + tcNo + "'";
            ArrayList ll = execQuery(sql);  //调用父类方法
            if (ll.Count == 0) return null;
            object[] o = (object[])ll[0];
            OpenCourse oc = new OpenCourse(o[0].ToString(), o[1].ToString(), o[2].ToString(), int.Parse(o[3].ToString()), int.Parse(o[4].ToString()), int.Parse(o[5].ToString()));
            return oc;
        }

        //更新一条记录到teachcourse表
        public static int updateOpenCourse(OpenCourse oc)
        {
            string wn = QueryWorkerNo(oc.teacher);
            string cn = QuerycourseNo(oc.courseName);
            string sql = "update teachcourse set "
                + "amount='" + oc.amount
                + "',courseNo='" + cn
                + "',startWeek='" + oc.startWeek
                + "',endWeek='" + oc.endWeek
                + "',workerNo='" + wn +"'"
                + " where teachCourseNo='" + oc.teachCourseNo + "'";
            return execNonQuery(sql);
        }
        public int updateOpenCourse()
        {
            return updateOpenCourse(oc);
        }

        //根据教师名找工号
        public static string QueryWorkerNo(string wname)
        {
            string sql = "select workerNo from teacher where workerName= '" + wname + "'";
            return (string)executeScalar(sql);
        }
        //根据工号找教师名
        public static string QueryWorkerName(string wn)
        {
            string sql = "select workerName from teacher where workerNo='" + wn + "'";
            return (string)executeScalar(sql);
        }

        //加载选课学生表
        public static void loadStudentInClass(ListView lv, string tcNo)
        {
            string sql = "select sc.studentNo as 学号, studentName as 姓名, deptName as 院系 from (selectcourse sc"
                + " inner join student s on s.studentNo=sc.studentNo)"
                + " inner join department d on s.deptId=d.deptId"
                + " where teachcourseNo='" + tcNo + "'";
            ReaderToListView(lv, sql);
        }

        //选课人数
        public static int NumberInClass(string tcNo)
        {
            string sql = " select count(teachCourseNo) from selectcourse where teachCourseNo='" + tcNo+"'";
            return (int)executeScalar(sql);
        }

        //容纳人数
        public static int getAmount(string tcNo)
        {
            string sql = " select amount from teachcourse where teachCourseNo='" + tcNo+"'";
            return (Int16)executeScalar(sql);
        }

        //从课程中删除一位学生
        public static void delStudentInClass(string tcNo,string sNo)
        {
            string sql = "delete * from selectcourse where teachCourseNo='" + tcNo 
                + "' and studentNo='"+sNo+"'";
            execNonQuery(sql);
        }

        //将选课人数调整到容纳人数
        public static void controllAmount(ListView lv,string tcNo)
        {
            Random ran = new Random();
            int n = NumberInClass(tcNo);
            int amount = getAmount(tcNo);
            while(n>amount)
            {
                int i = ran.Next(0,n);
                delStudentInClass(tcNo, lv.Items[i].SubItems[0].Text);
                n--;
            }
        }

        //获取院系数量
        public static int getAmountOfDept()
        {
            string sql = "select count(deptId) from department";
            return (int)executeScalar(sql);
        }

        //更新课程所包含的学院
        public int updateDept(Course c,bool[] dept)
        {
            string sql = "update course set [403]=" + dept[0] + ",[409]=" + dept[1] + ",[411]=" + dept[2]+" where courseNo='"+c.courseNo+"'";
            return execNonQuery(sql);
        }

        //获取课程所包含的学院
        public static bool[] getDept(Course c)
        {
            bool[] dept = new bool[getAmountOfDept()];
            string sql = "select [403] from course where courseNo='" + c.courseNo + "'";
            dept[0]=(bool)executeScalar(sql);
            string sql1 = "select [409] from course where courseNo='" + c.courseNo + "'";
            dept[1] = (bool)executeScalar(sql1);
            string sql2 = "select [411] from course where courseNo='" + c.courseNo + "'";
            dept[2] = (bool)executeScalar(sql2);
            return dept;
        }

        }
    
}
