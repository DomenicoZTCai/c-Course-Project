using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ntier2015.StudentManager
{
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
            this.Size = new Size(780, 360);
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sNo = tbStudentNo.Text;
            string sName = tbStudentName.Text;
            string faculty = cbFaculty.Text;
            lvStudentList.Items.Clear();
            StudentManageAction.loadAllStudent(lvStudentList, sName, sNo,faculty);
        }
        //学生列表行改变时的事件响应函数
        private void lvStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudentList.SelectedItems.Count == 0) return; //未选中任何一行
            string sno = lvStudentList.SelectedItems[0].Text;  //取选中行中的第一行的第一列文本
            tbStudentNo.Text = sno;
            tbStudentName.Text = lvStudentList.SelectedItems[0].SubItems[1].Text;
            cbFaculty.Text = lvStudentList.SelectedItems[0].SubItems[4].Text;
            StudentManageAction.loadSelectedCourse(lvSelectedCourse, sno);   //与课本不同，多一个参数
            StudentManageAction.loadUnselectedCourse(lvUnselectedCourse, sno);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student st = StudentManageAction.QueryStudentInfo(tbStudentNo .Text);
            InputStudentForm asf = new InputStudentForm(st);
            asf.MdiParent = this.MdiParent;
            asf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbStudentNo.Text == "") return;

            if (MessageBox.Show("确定要删除吗?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = StudentManageAction.delStudent(tbStudentNo.Text.Trim ());
                MessageBox.Show(i + " row(s) affected");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Size = new Size(780, 600);
                this.groupBox3.Visible = true;
                this.groupBox4.Visible = true;
            }
            else
            {
                this.Size = new Size(780, 360);
                this.groupBox3.Visible = false;
                this.groupBox4.Visible = false;
            }
        }

        private void lvUnselectedCourse_DoubleClick(object sender, EventArgs e)
        {
            //string sno = tbStudentNo.Text;
            //string teachCourseNo = lvUnselectedCourse.SelectedItems[0].Text;
            //StudentManageAction.selectCourse(sno, teachCourseNo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbStudentName.Text = "";
            tbStudentNo.Text = "";
            cbFaculty.Text = "";
            lvSelectedCourse.Items.Clear();
            lvUnselectedCourse.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student st = StudentManageAction.QueryStudentInfo(tbStudentNo.Text);
            if (st == null) return;
            SelectCourseForm scf = new SelectCourseForm(st);
            scf.MdiParent = this.MdiParent;
            scf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputStudentForm isf = new InputStudentForm();
            isf.MdiParent = this.MdiParent;
            isf.Show();
        }

        private void lvUnselectedCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentManageAction.loadAllStudent(lvStudentList);
        }
    }
}