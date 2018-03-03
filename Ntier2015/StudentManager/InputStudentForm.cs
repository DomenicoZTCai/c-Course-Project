using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace Ntier2015.StudentManager
{
    public partial class InputStudentForm : Form
    {
        Hashtable htDeptId = new Hashtable();
        Hashtable htDeptName = new Hashtable();
        bool isUpdate = false;  //初始为增加窗体
        StudentManageAction sma = new StudentManageAction();
        public InputStudentForm():this(null)
        {
        }
        public InputStudentForm(Student st)
        {//st非空为修改窗体；否则为增加窗体
            InitializeComponent();
         //   htDept = StudentManageAction.getDeptList();
            StudentManageAction.getDeptList(htDeptId,htDeptName);
            foreach (DictionaryEntry de in htDeptName)
                cbDept.Items.Add(de.Key);
            if (st == null)
            {
                tbStudentNo.Enabled = true;
                this.Text = "增加学生";
                isUpdate = false;
                btnAdd.Text = "增加";
            }
            else
            {
                this.Text = "修改学生信息";
                tbStudentNo.Enabled = false;

                tbStudentNo.Text = st.studentNo;
                tbStudentName.Text = st.studentName;
                //      tbBirthday.Text = st.birthday ;
                cbSex.Text = st.sex;
                string deptName = (string)htDeptId[st.deptId];
                int i = cbDept.Items.IndexOf(deptName);
                if (i >= 0) cbDept.SelectedIndex = i;
                cbDept.Text = deptName;
          //      cbZhuanye.Text = st.zhuanye;
                tbBirthday.Text = st.birthday ;
                isUpdate = true;
                btnAdd.Text = "保存修改";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string deptId = (string)htDeptName[cbDept.Text];
            int i = 0;
            if (tbStudentNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("学号不能为空", "提示");
                tbStudentNo.Focus();
                return;
            }
            Student student = new Student(tbStudentNo.Text, tbStudentName.Text, cbSex.Text, tbBirthday .Text, deptId);
            StudentManageAction sma = new StudentManageAction();
            sma.setStudent(student);
            if (isUpdate == false)
            {
                i=sma.addStudent();
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
                i=sma.updateStudent();
                if (i > 0)
                {
                    MessageBox.Show(string.Format("更新了{0}条记录", i));
                    this.Close();
                }
                else MessageBox.Show("更新不成功");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void InputStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}