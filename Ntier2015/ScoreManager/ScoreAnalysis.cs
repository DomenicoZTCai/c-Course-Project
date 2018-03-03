using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Ntier2015.TeacherManager;
using Ntier2015.CourseManager;

namespace Ntier2015.ScoreManager
{
    public partial class ScoreAnalysis : Form
    {
        public ScoreAnalysis()
        {

            InitializeComponent();
        }
        
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = ScoreManageAction.getCourseName(textBox1.Text);
            textBox3.Text = CourseManageAction.NumberInClass(textBox1.Text).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScoreManageAction.scoreAnalysis(listView1, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text=="") return;
            for(int i=0; i<int.Parse(textBox3.Text);i++)
                ScoreManageAction.getClass(listView1,listView1.Items[i].SubItems[2].Text);
            ScoreManageAction.scoreAnalysis(listView1,textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

