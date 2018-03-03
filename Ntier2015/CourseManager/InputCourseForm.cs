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
using System.Data.OleDb;

namespace Ntier2015.CourseManager
{

    public partial class InputCourseForm : Form
    {
        bool[] dept = new bool[CourseManageAction.getAmountOfDept()];
        CourseManager.Faculty faculty;
        bool isUpdate = false;  //初始为增加窗体

        public InputCourseForm():this(null)
        { }
        public InputCourseForm(Course c)
        {//c非空为修改窗体；否则为增加窗体
            InitializeComponent();
            if (c == null)
            {
                tbCourseNo.Enabled = true;
                this.Text = "增加课程";
                isUpdate = false;
                btnAdd.Text = "增加";
            }
            else
            {
                this.Text = "修改课程信息";
                tbCourseNo.Enabled = false;

                tbCourseNo.Text = c.courseNo;
                tbCourseName.Text = c.courseName;
                tbPoint.Text = c.point.ToString("0.0");
                isUpdate = true;
                btnAdd.Text = "保存修改";
                dept = CourseManageAction.getDept(c);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faculty= new CourseManager.Faculty(ref dept); 
           // faculty.MdiParent = this;
            faculty.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (tbCourseNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("不能为空", "提示");
                tbCourseNo.Focus();
                return;
            }
            Course course = new Course(tbCourseNo.Text, tbCourseName.Text, float.Parse(tbPoint.Text));
            CourseManageAction cma = new CourseManageAction();
            cma.setCourse(course);
            if (isUpdate == false)
            {
                i=cma.addCourse();
                if (i > 0)
                {
                    cma.updateDept(course,dept);
                    MessageBox.Show(string.Format("增加了{0}条记录", i));
                    foreach (Control ctrl in groupBox2.Controls)
                    {
                        if (!(ctrl is Label)) ctrl.Text = "";
                    }
                }
                else MessageBox.Show("添加不成功");
            }
            else
            {
                i=cma.updateCourse();
                if (i > 0)
                {
                    MessageBox.Show(string.Format("更新了{0}条记录", i));
                    this.Close();
                }
                else MessageBox.Show("更新不成功");
            }
            faculty.Close();
            this.Close();
        }


    }
}
