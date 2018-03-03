using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ntier2015.CourseManager;

namespace Ntier2015.TeacherManager
{
    public partial class SearchCourseForm : Form
    {
        Teacher t;

        public SearchCourseForm()
        {
            InitializeComponent();
        }

        public SearchCourseForm(Teacher t)
        {
            InitializeComponent();
            this.t = t;
            t.loadSelectCourse(lvSResult);
            label3.Text = t.workerNo;
            label4.Text = t.workerName;
        }
        //查看选课学生
        private void button4_Click(object sender, EventArgs e)
        {
            if (lvSResult.SelectedItems.Count == 0) return;
            OpenCourse oc = CourseManageAction.QueryOpenCourseInfo(lvSResult.SelectedItems[0].SubItems[0].Text);
            studentInClass SIC = new studentInClass(oc,"教师");
            SIC.MdiParent = this.MdiParent;
            SIC.Show();
        }

        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
