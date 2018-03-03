
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
    public partial class SearchCourseForm : Form
    {
        public SearchCourseForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lvLessons.SelectedItems.Count == 0) return;
            OpenCourse oc = CourseManageAction.QueryOpenCourseInfo(lvLessons.SelectedItems[0].SubItems[0].Text);
            studentInClass SIC = new studentInClass(oc);
            SIC.MdiParent = this.MdiParent;
            SIC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course c = CourseManageAction.QueryCourseInfo(tbCourseNo.Text);
            CourseManager.OpenCourseForm ocf = new OpenCourseForm(c);
            ocf.MdiParent = this.MdiParent;
            ocf.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CourseManager.InputCourseForm ic = new InputCourseForm ();
            ic.MdiParent = this.MdiParent;
            ic.Show();           
        }

        private void button1_Click(object sender, EventArgs e)//btRearch
        {
            string cNo = tbCourseNo.Text;
            string cName = tbCourseName.Text;
            lvCourse.Items.Clear();
            CourseManageAction.loadAllCourse(lvCourse, cNo, cName);
        }

        //刷新表lvLessons
        private void button6_Click(object sender, EventArgs e)
        {
            CourseManageAction.loadOpenCourse(lvLessons,tbCourseNo.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Course c = CourseManageAction.QueryCourseInfo(tbCourseNo.Text);
            InputCourseForm acf = new InputCourseForm(c);
            acf.MdiParent = this.MdiParent;
            acf.Show();
        }

        //课程列表行改变时的事件响应函数
        private void lvCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCourse.SelectedItems.Count == 0) return; //未选中任何一行
            string cNo = lvCourse.SelectedItems[0].Text;  //取选中行中的第一行的第一列文本
            tbCourseNo.Text = cNo;
            tbCourseName.Text = lvCourse.SelectedItems[0].SubItems[1].Text;
            CourseManageAction.loadOpenCourse(lvLessons, cNo);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbCourseNo.Text == "") return;

            if (MessageBox.Show("确定要删除吗?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = CourseManageAction.delCourse(tbCourseNo.Text.Trim());
                MessageBox.Show(i + " row(s) affected");
            }
        }

        private void btnReUpdate_Click(object sender, EventArgs e)
        {
            CourseManageAction.loadAllCourse(lvCourse);
        }

        private void btoDelete_Click(object sender, EventArgs e)
        {
            if (lvLessons.SelectedItems.Count == 0) return;

            if (MessageBox.Show("确定要删除吗?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = CourseManageAction.delopenCourse(lvLessons.SelectedItems[0].SubItems[0].Text.Trim());
                MessageBox.Show(i + " row(s) affected");
            }
            CourseManageAction.loadAllCourse(lvCourse);
        }

        private void btoRevise_Click(object sender, EventArgs e)
        {
            if (lvLessons.SelectedItems.Count == 0) return;
            OpenCourse oc = CourseManageAction.QueryOpenCourseInfo(lvLessons.SelectedItems[0].SubItems[0].Text);
            CourseManager.OpenCourseForm ocf = new OpenCourseForm(oc);
            ocf.MdiParent = this.MdiParent;
            ocf.Show();
        }

        private void lvLessons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
