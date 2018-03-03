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
        /// �����ݿ��в�ѯ<Ժϵ��,Ժϵ����>�������뵽��ϣ����
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
        //��ѯ��student,department,��ʾ����ѧ����Ϣ��ListView��
        public static void loadAllStudent(ListView lv)
        {
            string sql = "select * from student s, department  d where s.deptId=d.deptId";
            ReaderToListView(lv, sql);   //ֱ�ӵ��ø��෽��
        }
        //��ѯ��student,department����ʾģ��ƥ���ѧ����Ϣ��ListView��
        public static void loadAllStudent(ListView lv, string name,string no,string faculty)
        {
            string sql = "select studentNo as  ѧ��, studentName as ����, sex as �Ա�, birthday as ����, deptName as ����Ժϵ from student s ";
            sql += "inner join department d on s.deptId = d.deptId where 1=1 ";
            if (!name.Equals(""))
                sql += " and studentName like '%" + name + "%' ";
            if (!no.Equals(""))
                sql += " and studentNo like '%" + no + "%' ";
            if (!faculty.Equals(""))
                sql += " and deptName like '%" + faculty + "%' ";
            ReaderToListView(lv, sql);   //ֱ�ӵ��ø��෽��
        }
        //��ѯ��student,����ѧ�Ų�ѯ����
        public string QueryStudentName(string sNo)
        {
            string sql = "select studentName from student where studentNo= '" +sNo+"'";
            return (string)executeScalar(sql);  //ֱ�ӵ��ø��෽��
        }
        //��ѯ��student,����������ѯѧ��
        public string QueryStudentNo(string sName)
        {
            string sql = "select studentNo from student where studentName='" + sName + "'";
            return (string)executeScalar(sql); //ֱ�ӵ��ø��෽��
        }
        //��ѯ��student,����ѧ�Ų�ѯѧ����Ϣ
        public static Student QueryStudentInfo(string sNo)
        {
            string sql = "select studentNo,studentName,birthday,sex,deptId from student " +
                "where studentNo = '" + sNo + "'";
            ArrayList ll = execQuery(sql);  //���ø��෽��
            if (ll.Count == 0) return null;
            object[] o = (object[])ll[0];
            Student st= new Student ( o[0].ToString(),o[1].ToString(),o[3].ToString(),
                Convert.ToDateTime(o[2]).ToShortDateString(),o[4].ToString());
            return st;
        }
        /// <summary>
        /// ��ѯ��selectcourse,teachcourse,course, teacher,
        /// ����ѧ�ž�ȷ��ѯĳѧ����ѡ����Ϣ����ʾ��ListView��
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="sNo"></param>
        public static void loadSelectedCourse(ListView lv, string sNo)
        {
            string sql = " select sc.teachCourseNo, c.courseName,t.workerName " +
                "from ((selectcourse sc " +  //ACCESS�б�����inner join ����ֻ��join
                "inner join TeachCourse tc on tc.teachCourseNo=sc.teachCourseNo) " +
                "inner join course c on c.courseNo=tc.courseNo) " +
                "inner join teacher t on t.workerNo=tc.workerNo " +
                " where studentNo = '" + sNo + "'";
            ReaderToListView(lv, sql);   //ֱ�ӵ��ø��෽��
        }
        /// <summary>
        /// ��ѯ��selectcourse,teachcourse,course, teacher,
        /// ����ѧ�Ų�ѯĳѧ��δѡ����Ϣ����ʾ��ListView
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="sNo"></param>
        public static void loadUnselectedCourse(ListView lv, string sNo)
        {
            string sql = " select tc.teachCourseNo as �������,c.courseName as ����,t.workerName as ��ʦ,count(sc.teachCourseNo) as ѡ������, amount as ���� " +
                "from ((TeachCourse  tc left join SelectCourse sc on tc.teachCourseNo=sc.teachCourseNo) " +
                " inner join course c on c.courseNo=tc.courseNo) " +
            "inner join teacher t on t.workerNo=tc.workerNo " +
            " where tc.teachCourseNo not in  " +
            "(select sc.teachCourseNo from selectcourse sc " +
            " where  studentNo ='" + sNo + "') " +
            "  group by tc.teachCourseNo,c.courseName,t.workerName,amount ";
            ReaderToListView(lv, sql);   //ֱ�ӵ��ø��෽��
        }
        /// <summary>
        /// ���һ��ѧ����¼����Student��
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
        //ɾ����Student�е�һ��ѧ����¼
        public static int delStudent(string sNo)
        {
            string sql = " delete from Student where studentNo = '" +
                sNo + "'";
            return execNonQuery(sql);
        }

        /// <summary>
        /// ���±�Student�е�һ��ѧ����¼
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
        /// ��ѯ��SelectCourse,���ݿ��κ�ͳ��ѡ������
        /// </summary>
        /// <param name="tcNo"></param>
        /// <returns></returns>
        public static int countSelectedCourse(string tcNo)
        {
            string sql = "select count(*) from selectcourse ";
            sql +="where teachCourseNo ='"+tcNo +"'";
            return (int)executeScalar(sql);  //ֱ�ӵ��ø��෽��
        }
        /// <summary>
        /// ����һ��ѡ�μ�¼����SelectCourse
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
            return execNonQuery(sql);   ////ֱ�ӵ��ø��෽��
        }
        //ɾ����SelectCourse�е�һ��ѡ�μ�¼
        public static int deselectCourse(string sNo,string tcNo)
        {
            string sql = "delete from selectcourse where studentNo='" +
                 sNo + "' and teachCourseNo = '" +
                 tcNo + "'";
            return execNonQuery(sql);   ////ֱ�ӵ��ø��෽��
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
            string sql = " select tc.teachCourseNo as �γ̺�,c.courseName as �γ�����,c.testMethod as ���鷽ʽ,c.point as ѧ��,t.workerName as ��ʦ,tc.startWeek as ��ʼ��,tc.endWeek as ������ " +
                "from ((selectcourse sc " +
                "inner join teachcourse tc on tc.teachCourseNo=sc.teachCourseNo) " +
                "inner join course c on c.courseNo=tc.courseNo) " +
                "inner join teacher t on t.workerNo=tc.workerNo " +
                "where studentNo ='" + sNo + "'";
            ReaderMyTimetable(lv, sql);
        }


        public static void loadCompulsoryCourse(ListView lv, string deptId)
        {
            string sql = " select courseNo as �κ�, courseName as �γ���, point as ѧ��,testMethod as ���鷽ʽ from course" +
                         " where [" + deptId + "] =true"; //���ݿ��߼�����
            ReaderToListView(lv, sql);   //ֱ�ӵ��ø��෽��
        }//fede


        //��ȡѧ��ѧԺ��
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
            string sql = " select tc.teachCourseNo as �������,c.courseName as ����,t.workerName as ��ʦ,count(sc.teachCourseNo) as ѡ������, amount as ���� " +
                "from ((TeachCourse  tc left join SelectCourse sc on tc.teachCourseNo=sc.teachCourseNo) " +
                " inner join course c on c.courseNo=tc.courseNo) " +
            "inner join teacher t on t.workerNo=tc.workerNo " +
            " where tc.courseNo = '" + cNo + "'"+
            "group by tc.teachCourseNo,c.courseName,t.workerName,amount";
            ReaderToListView(lv, sql);   //ֱ�ӵ��ø��෽��
        }
    }
}
