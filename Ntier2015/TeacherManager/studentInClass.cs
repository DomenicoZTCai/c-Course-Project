using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntier2015.CourseManager
{
    public partial class studentInClass : Form
    {
        public studentInClass()
        {
        }
        public studentInClass(OpenCourse oc,string role="教务员")
        {
            InitializeComponent();
            label5.Text = oc.teachCourseNo;
            label6.Text = oc.courseName;
            label7.Text = oc.teacher;
            label8.Text = CourseManageAction.NumberInClass(oc.teachCourseNo).ToString() + "/" + CourseManageAction.getAmount(oc.teachCourseNo).ToString();
            CourseManageAction.loadStudentInClass(lvSIC, oc.teachCourseNo);
            if (role == "教师")
                button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseManageAction.controllAmount(lvSIC, label5.Text);
            label8.Text = CourseManageAction.NumberInClass(label5.Text).ToString() + "/" + CourseManageAction.getAmount(label5.Text).ToString();
            CourseManageAction.loadStudentInClass(lvSIC, label5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
