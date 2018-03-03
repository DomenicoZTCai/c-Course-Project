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
using Ntier2015.ScoreManager;


namespace Ntier2015.CourseManager
{
    public partial class OpenCourseForm : Form
    {
        bool isUpdate = false;

        public OpenCourseForm()
        {
            Hashtable htcNo = new Hashtable();
            Hashtable htcName = new Hashtable();
            InitializeComponent();
            this.Text = "开设课程";
            tbTeachCourseNo.Enabled = true;
            cbCourseName.Enabled = true;
            isUpdate = false;
            btnAdd.Text = "开课";
            ScoreManageAction.getCourseList(htcNo, htcName);
            foreach (DictionaryEntry de in htcName)
                cbCourseName.Items.Add(de.Key);
        }
        public OpenCourseForm(Course c)
        {
            InitializeComponent();
            this.Text = "开设课程";
            tbTeachCourseNo.Enabled = true;
            isUpdate = false;
            btnAdd.Text = "开课";
            cbCourseName.Text = c.courseName;
            tbCourseNo.Text = CourseManageAction.QuerycourseNo(c.courseName);
        }
        public OpenCourseForm(OpenCourse oc)
        {
            InitializeComponent();
            this.Text = "修改开课";
            tbTeachCourseNo.Enabled = false;
            tbTeachCourseNo.Text = oc.teachCourseNo;
            cbCourseName.Text = oc.courseName;
            tbTeacher.Text = oc.teacher;
            tbAmount.Text = oc.amount.ToString();
            cbStartWeek.Text = oc.startWeek.ToString();
            cbEndWeek.Text = oc.endWeek.ToString();
            isUpdate = true;
            btnAdd.Text = "保存修改";;
            tbCourseNo.Text = CourseManageAction.QuerycourseNo(oc.courseName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (tbTeachCourseNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("开课号不能为空", "提示");
                tbTeachCourseNo.Focus();
                return;
            }
            if (tbAmount.Text.Trim().Equals(""))
            {
                MessageBox.Show("学分不能为空", "提示");
                tbAmount.Focus();
                return;
            }
            if (tbTeacher.Text.Trim().Equals(""))
            {
                MessageBox.Show("学分不能为空", "提示");
                tbTeacher.Focus();
                return;
            }
            OpenCourse oc = new OpenCourse(tbTeachCourseNo.Text, cbCourseName.Text, tbTeacher.Text, int.Parse(tbAmount.Text), int.Parse(cbStartWeek.Text), int.Parse(cbEndWeek.Text));
            CourseManageAction cma = new CourseManageAction();
            cma.setOpenCourse(oc);
            if (isUpdate == false)
            {
                i = cma.addOpenCourse();
                if (i > 0)
                {
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
                i = cma.updateOpenCourse();
                if (i > 0)
                {
                    MessageBox.Show(string.Format("更新了{0}条记录", i));
                    this.Close();
                }
                else MessageBox.Show("更新不成功");
            }
            this.Close();
        }

        private void cbStartWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStartWeek.Text == "10")
            {
                cbEndWeek.Enabled = false;
                cbEndWeek.Text = "17";
            }
            else if (cbStartWeek.Text == "1")
            {
                cbEndWeek.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTeacher_Leave(object sender, EventArgs e)
        {
            tbWorkerNo.Text = CourseManageAction.QueryWorkerNo(tbTeacher.Text);
            if (tbWorkerNo.Text=="")
            {
                MessageBox.Show("不存在该教师");
                tbTeacher.Text = "";
                return;
            }
        }

        private void tbWorkerNo_Leave(object sender, EventArgs e)
        {
            tbTeacher.Text = CourseManageAction.QueryWorkerName(tbWorkerNo.Text);
            if (tbTeacher.Text=="")
            {
                MessageBox.Show("不存在该教师");
                tbWorkerNo.Text = "";
                return;
            }
        }

    }
}
