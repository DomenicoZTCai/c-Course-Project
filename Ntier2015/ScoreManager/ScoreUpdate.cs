using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ntier2015.TeacherManager;
using System.Collections;
using Ntier2015.CourseManager;

namespace Ntier2015.ScoreManager
{
    public partial class ScoreUpdate : Form
    {
        public ScoreUpdate()
        {

            InitializeComponent();
        }
        Teacher t;
        public ScoreUpdate(Teacher t)
        {
            this.t= t;
            InitializeComponent();

            Hashtable htCourseNo = new Hashtable();
            Hashtable htCourseName = new Hashtable();
            ScoreManageAction.getCourseList(htCourseNo, htCourseName,t.workerNo);
            foreach (DictionaryEntry de in htCourseName)
                comboBox2.Items.Add(de.Key);
        }

        private void ScoreUpdate_Load(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = ScoreManageAction.getCourseNo(comboBox2.Text, t.workerNo);
            textBox1.Text = CourseManageAction.NumberInClass(textBox2.Text).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScoreManageAction.loadAllStudent(listView1, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
