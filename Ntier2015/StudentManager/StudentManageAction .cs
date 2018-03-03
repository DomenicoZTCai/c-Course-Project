using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Ntier2015.StudentManager
{
    class StudentManageAction: DAL.OleDbConn 
    {
        Student student;
        public void setStudent(Student st)
        {
            this.student = st;
        }
        /// <summary>
        /// 从数据库中查询<院系名,院系代码>，并加入到哈希表中
        /// </summary>
        /// <returns></returns>
        public static Hashtable getDeptList()
        {
            string sql = "select deptId,deptName from Department order by deptId";
            Hashtable ht = getHashtable(sql);
            return ht;
        }
        public static void getDeptList(Hashtable htDeptId, Hashtable htDeptName)
        {
            string sql = "select deptId,deptName from Department order by deptId";
            List<Object[]> list = executeReader(sql);
            if (list == null) return;
            foreach (Object[] o in list)
            {
                htDeptId.Add(o[0].ToString(), o[1].ToString());
                htDeptName.Add(o[1].ToString(), o[0].ToString());
            }
        }
        //查询表student,department,显示所有学生信息到ListView中
        public static void loadAllStudent(ListView lv)
        {
            string sql = "select * from student s, department  d where s.deptId=d.deptId";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }
        //查询表student,department，显示模糊匹配的学生信息到ListView中
        public static void loadAllStudent(ListView lv, string name,string no,string faculty)
        {
            string sql = "select studentNo as  学号, studentName as 姓名, sex as 性别, birthday as 生日, deptName as 所在院系 from student s ";
            sql += "inner join department d on s.deptId = d.deptId where 1=1 ";
            if (!name.Equals(""))
                sql += " and studentName like '%" + name + "%' ";
            if (!no.Equals(""))
                sql += " and studentNo like '%" + no + "%' ";
            if (!faculty.Equals(""))
                sql += " and deptName like '%" + faculty + "%' ";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }
        //查询表student,根据学号查询姓名
        public string QueryStudentName(string sNo)
        {
            string sql = "select studentName from student where studentNo= '" +sNo+"'";
            return (string)executeScalar(sql);  //直接调用父类方法
        }
        //查询表student,根据姓名查询学号
        public string QueryStudentNo(string sName)
        {
            string sql = "select studentNo from student where studentName='" + sName + "'";
            return (string)executeScalar(sql); //直接调用父类方法
        }
        //查询表student,根据学号查询学生信息
        public static Student QueryStudentInfo(string sNo)
        {
            string sql = "select studentNo,studentName,birthday,sex,deptId from student " +
                "where studentNo = '" + sNo + "'";
            ArrayList ll = execQuery(sql);  //调用父类方法
            if (ll.Count == 0) return null;
            object[] o = (object[])ll[0];
            Student st= new Student ( o[0].ToString(),o[1].ToString(),o[3].ToString(),
                Convert.ToDateTime(o[2]).ToShortDateString(),o[4].ToString());
            return st;
        }
        /// <summary>
        /// 查询表selectcourse,teachcourse,course, teacher,
        /// 根据学号精确查询某学生的选课信息，显示在ListView中
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="sNo"></param>
        public static void loadSelectedCourse(ListView lv, string sNo)
        {
            string sql = " select sc.teachCourseNo, c.courseName,t.workerName " +
                "from ((selectcourse sc " +  //ACCESS中必须用inner join 不能只用join
                "inner join TeachCourse tc on tc.teachCourseNo=sc.teachCourseNo) " +
                "inner join course c on c.courseNo=tc.courseNo) " +
                "inner join teacher t on t.workerNo=tc.workerNo " +
                " where studentNo = '" + sNo + "'";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }
        /// <summary>
        /// 查询表selectcourse,teachcourse,course, teacher,
        /// 根据学号查询某学生未选课信息，显示在ListView
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="sNo"></param>
        public static void loadUnselectedCourse(ListView lv, string sNo)
        {
            string sql = " select tc.teachCourseNo as 开课序号,c.courseName as 课名,t.workerName as 教师,count(sc.teachCourseNo) as 选课人数, amount as 上限 " +
                "from ((TeachCourse  tc left join SelectCourse sc on tc.teachCourseNo=sc.teachCourseNo) " +
                " inner join course c on c.courseNo=tc.courseNo) " +
            "inner join teacher t on t.workerNo=tc.workerNo " +
            " where tc.teachCourseNo not in  " +
            "(select sc.teachCourseNo from selectcourse sc " +
            " where  studentNo ='" + sNo + "') " +
            "  group by tc.teachCourseNo,c.courseName,t.workerName,amount ";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }
        /// <summary>
        /// 添加一个学生记录到表Student中
        /// </summary>
        /// <returns></returns>
        public static int addStudent(Student st)
        {
            string sql = " insert into Student(studentNo,studentName,sex,birthday,deptId) ";
            sql += "values('" + st.studentNo + "','" + st.studentName + "','" + st.sex + "','";
            sql += st.birthday + "','" + st.deptId + "')";
            return execNonQuery(sql);
        }
        public int addStudent()
        {
            return addStudent(student);
        }
        //删除表Student中的一条学生记录
        public static int delStudent(string sNo)
        {
            string sql = " delete from Student where studentNo = '" +
                sNo + "'";
            return execNonQuery(sql);
        }

        /// <summary>
        /// 更新表Student中的一条学生记录
        /// </summary>
        /// <returns></returns>
        public static int updateStudent(Student st)
        {
            string sql = "update Student set studentName= '" + st.studentName;
            sql += "',sex='" + st.sex + "', birthday='" + st.birthday;
            sql += "',deptId='" + st.deptId + "' where studentNo='" + st.studentNo + "'";
            return execNonQuery(sql);
        }
        public int updateStudent()
        {
            return updateStudent(student);
        }
        /// <summary>
        /// 查询表SelectCourse,根据开课号统计选课人数
        /// </summary>
        /// <param name="tcNo"></param>
        /// <returns></returns>
        public static int countSelectedCourse(string tcNo)
        {
            string sql = "select count(*) from selectcourse ";
            sql +="where teachCourseNo ='"+tcNo +"'";
            return (int)executeScalar(sql);  //直接调用父类方法
        }
        /// <summary>
        /// 增加一条选课记录到表SelectCourse
        /// </summary>
        /// <param name="sNo"></param>
        /// <param name="tcNo"></param>
        /// <returns></returns>
        public static int selectCourse(string sNo, string tcNo)
        {
            string sql1 = "select courseNo from selectCourse sc left join teachCourse tc " +
                "on sc.teachCourseNo=tc.teachCourseNo where studentNo='"+
                sNo +"' and courseNo in " +
                "(select courseNo from teachCourse where teachCourseNo = '" +
                tcNo + "')";
            object o = executeScalar(sql1);
            if (o != null) return 0;
            string sql = "insert into selectcourse( studentNo, teachCourseNo) values ('";
            sql += sNo + "','" + tcNo + "')";
            return execNonQuery(sql);   ////直接调用父类方法
        }
        //删除表SelectCourse中的一条选课记录
        public static int deselectCourse(string sNo,string tcNo)
        {
            string sql = "delete from selectcourse where studentNo='" +
                 sNo + "' and teachCourseNo = '" +
                 tcNo + "'";
            return execNonQuery(sql);   ////直接调用父类方法
        }

        public static void loadSelectedCourseToTimetable(DataGridView dt, string sNo)
        {
            string sql = " select  c.courseName,tc.Monday,tc.Tuesday,tc.Wednesday,tc.Thursday,tc.Friday,tc.startWeek,tc.endWeek " +
                "from ((selectcourse sc " +  
                "inner join TeachCourse tc on tc.teachCourseNo=sc.teachCourseNo) " +
                "inner join course c on c.courseNo=tc.courseNo) " +
              "inner join teacher t on t.workerNo=tc.workerNo " +
             " where studentNo = '" + sNo + "'";
            ReaderToDataGridView(dt, sql);
        }

        public static void loadMyTimetable(ListView lv, string sNo)
        {
            string sql = " select tc.teachCourseNo as 课程号,c.courseName as 课程名称,c.testMethod as 考查方式,c.point as 学分,t.workerName as 教师,tc.startWeek as 起始周,tc.endWeek as 结束周 " +
                "from ((selectcourse sc " +
                "inner join teachcourse tc on tc.teachCourseNo=sc.teachCourseNo) " +
                "inner join course c on c.courseNo=tc.courseNo) " +
                "inner join teacher t on t.workerNo=tc.workerNo " +
                "where studentNo ='" + sNo + "'";
            ReaderMyTimetable(lv, sql);
        }


        public static void loadCompulsoryCourse(ListView lv, string deptId)
        {
            string sql = " select courseNo as 课号, courseName as 课程名, point as 学分,testMethod as 考查方式 from course" +
                         " where [" + deptId + "] =true"; //数据库逻辑问题
            ReaderToListView(lv, sql);   //直接调用父类方法
        }//fede


        //提取学生学院名
        public static string getDeptName(string sNo)
        {
            string sql = "select deptName from department d inner join student s on s.deptId = d.deptId";
            return (string)executeScalar(sql);
        }//fede

        public static void loadSelectedCompulsoryCourse(ListView lv, Hashtable ht)
        {
            foreach (DictionaryEntry de in ht)
            {
                string courseNoWanted = de.Value.ToString();
                string sql = " select courseNo, courseName, point,testMethod from course" +
                             " where courseNo = '" + courseNoWanted + "'";
                appendToListview(lv, sql);
            }
        }

        public static void loadSelectedCompulsoryCourse(ListView lv, string cNo)
        {
            string sql = " select tc.teachCourseNo as 开课序号,c.courseName as 课名,t.workerName as 教师,count(sc.teachCourseNo) as 选课人数, amount as 上限 " +
                "from ((TeachCourse  tc left join SelectCourse sc on tc.teachCourseNo=sc.teachCourseNo) " +
                " inner join course c on c.courseNo=tc.courseNo) " +
            "inner join teacher t on t.workerNo=tc.workerNo " +
            " where tc.courseNo = '" + cNo + "'"+
            "group by tc.teachCourseNo,c.courseName,t.workerName,amount";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }
    }
}
