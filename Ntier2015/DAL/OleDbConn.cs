using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Ntier2015.CourseManager;

namespace Ntier2015.DAL
{
    public class OleDbConn
    {
        private static string _Access2007ConStr = 
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            Application.StartupPath  + "\\ntier.accdb"; //这是Access2007以后的数据库
        private static string _Access2003ConStr =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
            Application.StartupPath + "\\ntier.mdb"; //这是Access2003的数据库
        //若出现异常：“ 未在本地计算机上注册“Microsoft.Jet.OLEDB.4.0”提供程序”。解决：platform:X86 不要选any computer
        private static string _SqlConStr =
            "Provider=SQLNCLI11;Data Source=.\\SQLEXPRESS;integrated security=SSPI;initial catalog=ntier.mdb"; //这是SQLServer的数据库
 
        protected static OleDbConnection conn = new OleDbConnection();
        static OleDbConn()  //静态构造函数，不能含参数
        {
            conn.ConnectionString = _Access2003ConStr;
        }
        protected static OleDbConnection getConn()
        {
            return conn;
        }

        protected static void ReaderToListView(ListView lv, string sql)
        {
            OleDbCommand command = new OleDbCommand(sql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                OleDbDataReader reader = command.ExecuteReader();
                //下面设置标题栏
                lv.Columns.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    ColumnHeader ch = new ColumnHeader();
                    ch.Text = reader.GetName(i);
                 //   ch.Width = 80;  
                    lv.Columns.Add(ch);
                }
                
                lv.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems[0].Text = reader[0].ToString();
                    for (int i = 1; i < reader.FieldCount; i++)
                        lvi.SubItems.Add(reader[i].ToString());
                    lv.Items.Add(lvi);
                } 
                conn.Close();
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message); }
            for (int i = 0; i < lv.Columns.Count; i++)
            {
                lv.Columns[i].Width = -2;
            }
        }
        protected static void appendToListview(ListView lv, string sql)
        {
            OleDbCommand command = new OleDbCommand(sql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed){ conn.Open(); }               
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems[0].Text = reader[0].ToString();
                    for (int i = 1; i < reader.FieldCount; i++)
                        lvi.SubItems.Add(reader[i].ToString());
                    lv.Items.Add(lvi);
                }
                conn.Close();
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message); }
            for (int i = 0; i < lv.Columns.Count; i++)
            {
                lv.Columns[i].Width = -2;
            }
        }
        protected static int execNonQuery(string sql)
        {
            int i = 0;
            try
            {
                conn.Open();  //conn 是类变量
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                i = cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                conn.Close();
                //不管数据库操作结果如何，执行完毕都关闭数据库联接     
            }
            return i;
        }
        protected static object executeScalar(string sql)
        {
            object result = null;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = cmd.ExecuteScalar();
            }
            catch (OleDbException ex)
            {
                string s = ex.ToString();
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        protected static List<Object[]> executeReader(string sql)
        {
            List<Object[]> result = new List<object[]>();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Object[] values = new Object[reader.FieldCount];
                    reader.GetValues(values);
                    result.Add(values);
                }
            }
            catch (OleDbException ex)
            {
                string s = ex.ToString();
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        protected static ArrayList execQuery(string sql)
        {
            ArrayList result = new ArrayList();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //                conn.Open();
                OleDbDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    object[] values = new object[dbReader.FieldCount]; // 对应一条记录
                    dbReader.GetValues(values);//将一行的数据读进values数组中
                    result.Add(values);
                }
            }
            catch (OleDbException ex)
            {
                string s = ex.ToString();
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        protected static Hashtable getHashtable(string sql)
        {
            Hashtable ht = new Hashtable();
            //   string sql = "select deptId,deptName from Department order by deptId";
            
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string key = reader[0].ToString(); //取键
                    string value = reader[1].ToString(); //取值
                    ht.Add(key, value);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return ht;
        }
        protected static DataTable ReaderToDataGridView(DataGridView dataGridView1, string sql)
        {


            DataTable dt = new DataTable("subject");
            dt.Columns.Add("周数/节数", typeof(string));   //添加列集，下面都是
            dt.Columns.Add("周一", typeof(string));
            dt.Columns.Add("周二", typeof(string));
            dt.Columns.Add("周三", typeof(string));
            dt.Columns.Add("周四", typeof(string));
            dt.Columns.Add("周五", typeof(string));
            dt.Columns.Add("周六", typeof(string));
            dt.Columns.Add("周日", typeof(string));


            for (int i = 0; i < 11; i++)  //用循环添加4个行集~
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
            }
            dt.Rows[0][0] = "第1节";  //向第一行里的第一个格中添加一个“第1节”
            dt.Rows[1][0] = "第2节";  //向第二行里的第一个格中添加一个“第 2 节”
            dt.Rows[2][0] = "第3节";  //向第三行里的第一个格中添加一个“第3节”
            dt.Rows[3][0] = "第4节";  //向第四行里的第一个格中添加一个“第4节”
            dt.Rows[4][0] = "第5节";
            dt.Rows[5][0] = "第6节";
            dt.Rows[6][0] = "第7节";
            dt.Rows[7][0] = "第8节";
            dt.Rows[8][0] = "第9节";
            dt.Rows[9][0] = "第10节";
            dt.Rows[10][0] = "第11节";

            OleDbCommand command = new OleDbCommand(sql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                OleDbDataReader reader = command.ExecuteReader();
                Course[,] courseTable = new Course[11, 6];
                Course[,] courseTableLayer2 = new Course[11, 6];

                while (reader.Read())
                {
                    Course course = new Course(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                        reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()), int.Parse(reader[7].ToString()));
                    for (int t = 1; t <= 5; t++)
                    {
                        string time = reader[t].ToString();
                        for (int j = 0; j <= 4; j++)
                        {
                            if (time == "") continue;
                            else
                            {
                                if (j != 4)
                                {
                                    if (time[j] == '1')
                                    {
                                        if (courseTable[2 * j, (t - 1)] == null)
                                            courseTable[2 * j, (t - 1)] = courseTable[(2 * j + 1), (t - 1)] = course;
                                        else
                                        {
                                            if ((course.endWeek < courseTable[2 * j, (t - 1)].startWeek) || course.startWeek > courseTable[2 * j, (t - 1)].endWeek)
                                            { courseTableLayer2[2 * j, (t - 1)] = courseTableLayer2[(2 * j + 1), (t - 1)] = course; }
                                            else
                                            {
                                                courseTableLayer2[2 * j, (t - 1)] = courseTableLayer2[(2 * j + 1), (t - 1)] = course;
                                                courseTableLayer2[2 * j, (t - 1)].validInTimetable = courseTableLayer2[(2 * j + 1), (t - 1)].validInTimetable = false;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (time[j] == '1')
                                    {
                                        if (courseTable[8, (t - 1)] == null)
                                            courseTable[8, (t - 1)] = courseTable[9, (t - 1)] = course;
                                        else
                                        {
                                            if (course.endWeek < courseTable[8, (t - 1)].startWeek || course.startWeek > courseTable[8, (t - 1)].endWeek)
                                            { courseTableLayer2[8, (t - 1)] = courseTableLayer2[9, (t - 1)] = course; }
                                            else
                                            {
                                                courseTableLayer2[8, (t - 1)] = courseTableLayer2[9, (t - 1)] = course;
                                                courseTableLayer2[8, (t - 1)].validInTimetable = courseTableLayer2[9, (t - 1)].validInTimetable = false;
                                            }
                                        }
                                    }
                                    else if (time[j] == '2')
                                    {
                                        if (courseTable[8, (t - 1)] == null)
                                            courseTable[8, (t - 1)] = courseTable[9, (t - 1)] = courseTable[10, (t - 1)] = course;
                                        else
                                        {
                                            if (course.endWeek < courseTable[8, (t - 1)].startWeek || course.startWeek > courseTable[8, (t - 1)].endWeek)
                                            { courseTableLayer2[8, (t - 1)] = courseTableLayer2[9, (t - 1)] = courseTableLayer2[10, (t - 1)] = course; }
                                            else
                                            {
                                                courseTableLayer2[8, (t - 1)] = courseTableLayer2[9, (t - 1)] = courseTableLayer2[10, (t - 1)] = course;
                                                courseTableLayer2[8, (t - 1)].validInTimetable = courseTableLayer2[9, (t - 1)].validInTimetable
                                                    = courseTableLayer2[10, (t - 1)].validInTimetable = false;
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                conn.Close();
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (courseTable[i, j] != null)
                        {
                            if (courseTableLayer2[i, j] == null)
                            { dt.Rows[i][j + 1] = courseTable[i, j].getIntoGridView(); }
                            else
                            {
                                dt.Rows[i][j + 1] = courseTable[i, j].getIntoGridView() + courseTableLayer2[i, j].getIntoGridView();
                            }
                        }
                    }
                }//table中的文字
              
                dataGridView1.DataSource = dt;

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (courseTableLayer2[i, j] != null)
                        {
                            if (!courseTableLayer2[i, j].validInTimetable)
                            { dataGridView1.Rows[i].Cells[j + 1].Style.ForeColor = Color.Red; }
                        }
                    }
                }//重复选课的文字变红

                dataGridView1.ReadOnly = true;
                foreach (DataGridViewColumn e in dataGridView1.Columns)
                { e.ReadOnly = true; e.SortMode = DataGridViewColumnSortMode.NotSortable; }
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    dataGridView1.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message); }

            return dt;
        }
         
        //protected static DataTable ReaderToDataGridView(DataGridView dataGridView1, string sql)
        //{


        //    DataTable dt = new DataTable("subject");
        //    dt.Columns.Add("周数/节数", typeof(string));   //添加列集，下面都是
        //    dt.Columns.Add("周一", typeof(string));
        //    dt.Columns.Add("周二", typeof(string));
        //    dt.Columns.Add("周三", typeof(string));
        //    dt.Columns.Add("周四", typeof(string));
        //    dt.Columns.Add("周五", typeof(string));
        //    dt.Columns.Add("周六", typeof(string));
        //    dt.Columns.Add("周日", typeof(string));


        //    for (int i = 0; i < 11; i++)  //用循环添加4个行集~
        //    {
        //        DataRow dr = dt.NewRow();
        //        dt.Rows.Add(dr);
        //    }
        //    dt.Rows[0][0] = "第1节";  //向第一行里的第一个格中添加一个“第1节”
        //    dt.Rows[1][0] = "第2节";  //向第二行里的第一个格中添加一个“第 2 节”
        //    dt.Rows[2][0] = "第3节";  //向第三行里的第一个格中添加一个“第3节”
        //    dt.Rows[3][0] = "第4节";  //向第四行里的第一个格中添加一个“第4节”
        //    dt.Rows[4][0] = "第5节";
        //    dt.Rows[5][0] = "第6节";
        //    dt.Rows[6][0] = "第7节";
        //    dt.Rows[7][0] = "第8节";
        //    dt.Rows[8][0] = "第9节";
        //    dt.Rows[9][0] = "第10节";
        //    dt.Rows[10][0] = "第11节";

        //    OleDbCommand command = new OleDbCommand(sql, conn);
        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }

        //        OleDbDataReader reader = command.ExecuteReader();
        //        //int i = 1;
        //        while (reader.Read())
        //        {
        //            for (int t = 2; t <= 6; t++)
        //            {
        //                string time = reader[t].ToString();
        //                for (int j = 0; j <= 4; j++)
        //                {
        //                    if (time == "") continue;
        //                    else
        //                    {
        //                        if (j != 4)
        //                        {
        //                            if (time[j] == '1')
        //                            {
        //                                if (dt.Rows[2 * j][t - 1].ToString() == "")
        //                                    dt.Rows[2 * j][t - 1] = dt.Rows[2 * j + 1][t - 1] = reader[0].ToString() + weeksToString(reader[7], reader[8]);
        //                                else
        //                                {
        //                                    dt.Rows[2 * j][t - 1] = dt.Rows[2 * j + 1][t - 1] += "\r\n" + reader[0].ToString() + weeksToString(reader[7], reader[8]);
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            if (time[j] == '1')
        //                            {
        //                                if (dt.Rows[8][t - 1].ToString() == "")
        //                                    dt.Rows[8][t - 1] = dt.Rows[9][t - 1] = reader[0].ToString() + weeksToString(reader[7], reader[8]);
        //                                else
        //                                {
        //                                    dt.Rows[8][t - 1] = dt.Rows[9][t - 1] += "\r\n" + reader[0].ToString() + weeksToString(reader[7], reader[8]);
        //                                }
        //                            }
        //                            else if (time[j] == '2')
        //                            {
        //                                if (dt.Rows[8][t - 1].ToString() == "")
        //                                    dt.Rows[8][t - 1] = dt.Rows[9][t - 1] = dt.Rows[10][t - 1] = reader[0].ToString() + weeksToString(reader[7], reader[8]);
        //                                else
        //                                {
        //                                    dt.Rows[8][t - 1] = dt.Rows[9][t - 1] = dt.Rows[10][t - 1] += "\r\n" + reader[0].ToString() + weeksToString(reader[7], reader[8]);
        //                                }

        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            // i++;
        //        }
        //        conn.Close();
        //        dataGridView1.DataSource = dt;
        //        dataGridView1.ReadOnly = true;
        //        foreach (DataGridViewColumn e in dataGridView1.Columns)
        //        { e.ReadOnly = true; e.SortMode = DataGridViewColumnSortMode.NotSortable; }
        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //            dataGridView1.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //        //dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //        dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        //    }
        //    catch (OleDbException ex)
        //    { MessageBox.Show(ex.Message); }

        //    return dt;
        //}


        protected static string weeksToString(object start, object end)
        {
            string weeks; weeks = "(" + start.ToString() + "-" + end.ToString() + ")";
            return weeks;
        }
        protected static void ReaderMyTimetable(ListView lv, string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                OleDbDataReader reader = cmd.ExecuteReader();
                lv.Columns.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    ColumnHeader ch = new ColumnHeader();
                    ch.Text = reader.GetName(i);
                    //   ch.Width = 80;  
                    lv.Columns.Add(ch);
                }
                lv.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems[0].Text = reader[0].ToString();
                    for (int i = 1; i < reader.FieldCount; i++)
                        lvi.SubItems.Add(reader[i].ToString());
                    lv.Items.Add(lvi);
                }
                conn.Close();
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
