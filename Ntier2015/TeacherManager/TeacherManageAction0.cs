using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Ntier2015.TeacherManager
{
    class TeacherManageAction0 : DAL.OleDbConn
    {
        Teacher teacher;
        public void setTeacher(Teacher tea)
        {
            this.teacher = tea;
        }

        /// <summary>
        /// 从数据库中查询<院系名,院系代码>，并加入到哈希表中
        /// </summary>
        /// <returns></returns>
        /// 
 
        //查询表teacher,department,显示所有学生信息到ListView中
        public static void loadAllTeacher(ListView lv)
        {
            string sql = "select workerNo as 工号,workerName as 姓名, sex as 性别, deptName as 所在学院 from teacher t, department d where t.deptId=d.deptId";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }
        
        //查询表teacher,department，显示模糊匹配的学生信息到ListView中
        public static void loadAllTeacher(ListView lv, string name, string no, string faculty)
        {
            string sql = "select workerNo, workerName, sex, deptName from teacher t ";
            sql += "inner join department d on t.deptId = d.deptId where 1=1 ";
            if (!name.Equals(""))
                sql += " and workerName like '%" + name + "%' ";
            if (!no.Equals(""))
                sql += " and workerNo like '%" + no + "%' ";
            if (!faculty.Equals(""))
                sql += " and deptName like '%" + faculty + "%' ";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }

        //查询表teacher,根据学号查询姓名
        public string QueryTeacherName(string tNo)
        {
            string sql = "select workerName from teacher where workerNo= '" + tNo + "'";
            return (string)executeScalar(sql);  //直接调用父类方法
        }
  
        //查询表teacher,根据姓名查询学号
        public string QueryTeacherNo(string tName)
        {
            string sql = "select workerNo from teacher where workerName='" + tName + "'";
            return (string)executeScalar(sql); //直接调用父类方法
        }

        //查询表student,根据学号查询学生信息
        public static Teacher QueryTeacherInfo(string tNo)
        {
            string sql = "select workerNo,workerName,sex,deptId from teacher where workerNo = '" + tNo + "'";
            ArrayList ll = execQuery(sql);  //调用父类方法
            if (ll.Count == 0) return null;
            object[] o = (object[])ll[0];
            Teacher tea = new Teacher(o[0].ToString(), o[1].ToString(), o[2].ToString(),o[3].ToString());
            return tea;
        }


        /// <summary>
        /// 查询表selectcourse,teachcourse,course, teacher,
        /// 根据学号精确查询某学生的选课信息，显示在ListView中
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="tNo"></param>
        /// 


        public static void loadSelectedCourse(ListView lv, string tNo)
        {
            string sql = "select teachCourseNo as 开课号,courseName as 课程名,workerName as 任课老师,amount as 容纳人数 "+
                 "from (teachcourse tc " +            
                 "inner join course c on c.courseNo=tc.courseNo) " +
                 "inner join teacher t on t.workerNo=tc.workerNo " +
                 "where tc.workerNo = '" + tNo + "'";
            ReaderToListView(lv, sql);   //直接调用父类方法
        }

        /// 添加一个学生记录到表Student中
        /// </summary>
        /// <returns></returns>
        public static int addTeacher(Teacher tea)
        {
            string sql = " insert into teacher(workerNo,workerName,sex,deptId) ";
            sql += "values('" + tea.workerNo + "','" + tea.workerName + "','" + tea.sex + "','" + tea.deptId + "')";
            return execNonQuery(sql);
        }
        public int addTeacher()
        {
            return addTeacher(teacher);
        }

        //删除表Teacher中的一条学生记录
        public static int delTeacher(string tNo)
        {
            string sql = " delete from teacher where workerNo = '" + tNo + "'";
            return execNonQuery(sql);
        }

        /// <summary>
        /// 更新表teacher中的一条学生记录
        /// </summary>
        /// <returns></returns>
        public static int updateTeacher(Teacher tea)
        {
            string sql = "update teacher set workerName= '" + tea.workerName;
            sql += "',sex='" + tea.sex;
            sql += "',deptId='" + tea.deptId + "' where workerNo='" + tea.workerNo + "'";
            return execNonQuery(sql);
        }
        public int updateTeacher()
        {
            return updateTeacher(teacher);
        }

    }
}
