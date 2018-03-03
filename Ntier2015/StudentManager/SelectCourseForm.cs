using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntier2015.StudentManager
{
    public partial class SelectCourseForm : Form
    {
        StudentManageAction sc = new StudentManageAction();
        Student st;
        Hashtable hashSelectedCompulsory = new Hashtable();


        public SelectCourseForm()
        {
            InitializeComponent();
        }
        public SelectCourseForm(Student st)
        {
            InitializeComponent();
            this.st = st;
            textBox1.Text = st.studentNo; textBox2.Text = st.studentName;
            st.loadSelectCourse(lvSelectedCourse);
            //st.loadSelectedCompulsoryCourse(lvSelectedCompulsoryCourse, hashSelectedCompulsory);
            st.loadSelectedCourseToTimetable(dataGridView1);
        }

        public SelectCourseForm(Student st,Hashtable ht)
        {
            this.hashSelectedCompulsory = ht;
            InitializeComponent();
            this.st = st;
            textBox1.Text = st.studentNo; textBox2.Text = st.studentName;
            st.loadSelectCourse(lvSelectedCourse);
            st.loadSelectedCompulsoryCourse(lvSelectedCompulsoryCourse, hashSelectedCompulsory);
            st.loadSelectedCourseToTimetable(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.loadUnselectCourse (lvUnselectedCourse);
            lvSelectedCompulsoryCourse.Clear();
        }

        private void lvUnselectedCourse_DoubleClick(object sender, EventArgs e)
        {

            if (lvUnselectedCourse .SelectedItems  .Count ==0) return;
            string tcNo = lvUnselectedCourse.SelectedItems [0].Text;
            int j=st.selectCourse(tcNo);
            if (j > 0)
            {
                st.loadSelectCourse(lvSelectedCourse);
                lvUnselectedCourse.Items.Remove(lvUnselectedCourse.SelectedItems[0]);
                st.loadSelectedCourseToTimetable(dataGridView1);
            }
        }

        private void lvSelectedCourse_DoubleClick(object sender, EventArgs e)
        {
            if (lvSelectedCourse.SelectedItems.Count == 0) return;
            string tcNo = lvSelectedCourse.SelectedItems[0].Text;
            int i = st.deselectCourse(tcNo);
            if (i > 0)
            {
                //st.loadUnselectCourse(lvUnselectedCourse);
                lvSelectedCourse.Items.Remove(lvSelectedCourse.SelectedItems[0]);
                st.loadSelectedCourseToTimetable(dataGridView1);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectCompulsoryCourseForm sccf = new selectCompulsoryCourseForm(st, hashSelectedCompulsory,this);
            sccf.MdiParent = this.MdiParent;
            sccf.Show();
        }

        private void lvSelectedCompulsoryCourse_DoubleClick(object sender, EventArgs e)
        {
            if (lvSelectedCompulsoryCourse.SelectedItems.Count == 0) return;
            string cNo = lvSelectedCompulsoryCourse.SelectedItems[0].Text;
            st.loadSelectedCompulsoryCourse(lvUnselectedCourse, cNo);
        }



 
    }
}