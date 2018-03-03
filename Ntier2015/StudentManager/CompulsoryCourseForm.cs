using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ntier2015.StudentManager;
using Ntier2015.UserManager;


namespace Ntier2015.StudentManager
{
    public partial class CompulsoryCourseForm : Form
    {
        Student stu;

        public CompulsoryCourseForm()
        {
            InitializeComponent();
        }

        public CompulsoryCourseForm(Student stu)
        {
            InitializeComponent();
            this.stu = stu;
            label1.Text = stu.studentNo;
            label2.Text = stu.studentName;
            string deptName = StudentManageAction.getDeptName(stu.studentNo);
            label3.Text = deptName;
            stu.loadCompulsoryCourse(lvCCF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
