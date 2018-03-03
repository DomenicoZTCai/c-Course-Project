using Ntier2015.UserManager;
using Ntier2015;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ntier2015.StudentManager;
using Ntier2015.TeacherManager;

namespace Ntier2015
{
    public partial class MainForm : Form
    {
        User user;
        public MainForm()
        {
            InitializeComponent();
        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm(this);
            lf.ShowDialog();
            user = lf.getUser();
            if (user == null)
            {
                this.Close();
            }
            else
            {
                setMenuShow();
            }

        }

        private void setMenuShow()
        {
            foreach (ToolStripMenuItem ct in this.menuStrip1.Items)
            {
                ct.Visible = false;
            }
            退出ToolStripMenuItem.Visible = true;
            if (user.isRole("学生"))
            {
                学生管理ToolStripMenuItem.Visible = true;
                foreach (ToolStripMenuItem mi in 学生管理ToolStripMenuItem.DropDownItems)
                    mi.Visible = false;
                课程管理ToolStripMenuItem.Visible = true;
                foreach (ToolStripMenuItem mi in 课程管理ToolStripMenuItem.DropDownItems)
                    mi.Visible = false;
                选课ToolStripMenuItem.Visible = true;
                查看我的课表ToolStripMenuItem.Visible = true;
                查看我的专业课程ToolStripMenuItem.Visible = true;
         //       教师管理ToolStripMenuItem.Visible = false;
                成绩管理ToolStripMenuItem.Visible = true;
                foreach (ToolStripMenuItem mi in 成绩管理ToolStripMenuItem.DropDownItems)
                    mi.Visible = false;
                成绩查询ToolStripMenuItem.Visible = true;
                StudentManageAction sm = new StudentManageAction();
                string s = sm.QueryStudentName(user.getAccount());
                this.Text = string.Format("欢迎！"+s+"同学", user.getAccount());
            }
            else if (user.isRole("教务员"))
            {
                foreach (ToolStripMenuItem ct in this.menuStrip1.Items)
                {
                    ct.Visible = true;
                    foreach (ToolStripMenuItem mi in ct.DropDownItems)
                        mi.Visible = true;
                }
                //    成绩查询ToolStripMenuItem.Visible = true;
                选课ToolStripMenuItem.Visible = false;
                成绩输入ToolStripMenuItem.Visible = false;
                成绩查询ToolStripMenuItem.Visible = false;
                开课查询ToolStripMenuItem.Visible = false;
                查看我的课表ToolStripMenuItem.Visible = false;
                查看我的专业课程ToolStripMenuItem.Visible = false;
                this.Text = "欢迎教务员";
            }
            else
            {
                教师管理ToolStripMenuItem.Visible = true;
                foreach (ToolStripMenuItem mi in 教师管理ToolStripMenuItem.DropDownItems)
                    mi.Visible = false;
                开课查询ToolStripMenuItem.Visible = true;
                成绩管理ToolStripMenuItem.Visible = true;
                foreach (ToolStripMenuItem mi in 成绩管理ToolStripMenuItem.DropDownItems)
                    mi.Visible = false;
                成绩输入ToolStripMenuItem.Visible = true;
                TeacherManageAction0 sm = new TeacherManageAction0();
                string s = sm.QueryTeacherName(user.getAccount());
                this.Text = string.Format("欢迎！" + s + "老师", user.getAccount());
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form fm in this.MdiChildren)
                fm.Close();//关闭所有子窗口
            MainForm_Load(sender, e);
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStudentForm isf = new InputStudentForm();
            isf.MdiParent = this;
            isf.Show();
            
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentForm ssf = new SearchStudentForm();
            ssf.MdiParent = this;
            ssf.Show();
            
        }

        private void 选课ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (user .isRole ("学生"))
            {
                Student st = StudentManageAction.QueryStudentInfo(user.getAccount());
                SelectCourseForm scf = new SelectCourseForm (st);
                scf.MdiParent = this;
                scf.Show();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentForm ssf = new SearchStudentForm();
            ssf.MdiParent = this;
            ssf.Show();
        }

        private void 成绩输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreManager.ScoreUpdate su = new ScoreManager.ScoreUpdate();
            su.MdiParent = this;
            su.Show();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student st = StudentManageAction.QueryStudentInfo(user.getAccount());
            ScoreManager.ScoreResearch sr = new ScoreManager.ScoreResearch(st);
            sr.MdiParent = this;
            sr.Show();
        }

        private void 成绩分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreManager.ScoreAnalysis sa = new ScoreManager.ScoreAnalysis();
            sa.MdiParent = this;
            sa.Show();
        }

        private void 增加ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TeacherManager.InputTeacherForm it = new TeacherManager.InputTeacherForm();
            it.MdiParent = this;
            it.Show();
        }

        private void 修改ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TeacherManager.SearchTeacherForm tf = new TeacherManager.SearchTeacherForm();
            tf.MdiParent = this;
            tf.Show();
        }

        private void 增加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CourseManager.InputCourseForm icf = new CourseManager.InputCourseForm();
            icf.MdiParent = this;
            icf.Show();
        }


        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CourseManager.SearchCourseForm scf = new CourseManager.SearchCourseForm();
            scf.MdiParent = this;
            scf.Show();
            scf.Text = "课程查询";
        }

        private void 开设课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseManager.OpenCourseForm openCourse = new CourseManager.OpenCourseForm();
            openCourse.MdiParent = this;
            openCourse.Show();
        }

        private void 开课查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Teacher t = TeacherManageAction0.QueryTeacherInfo(user.getAccount());
            TeacherManager.SearchCourseForm scf= new TeacherManager.SearchCourseForm(t);
            scf.MdiParent = this;
            scf.Show();
        }

        private void 查看我的课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student st = StudentManageAction.QueryStudentInfo(user.getAccount());
            StudentManager.CheckCourseForm ccf = new CheckCourseForm(st);
            ccf.MdiParent = this;
            ccf.Show();
        }

        private void 查看我的专业课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student st = StudentManageAction.QueryStudentInfo(user.getAccount());
            StudentManager.CompulsoryCourseForm ccf = new CompulsoryCourseForm(st);
            ccf.MdiParent = this;
            ccf.Show();
        }
    }
}
