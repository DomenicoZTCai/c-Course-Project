using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using Ntier2015.StudentManager;

namespace Ntier2015.TeacherManager
{
    public partial class InputTeacherForm : Form
    {
        Hashtable htDeptId = new Hashtable();
        Hashtable htDeptName = new Hashtable();
        bool isUpdate = false;  //初始为增加窗体
        TeacherManageAction0 sma = new TeacherManageAction0();
        public InputTeacherForm()
            : this(null)
        {
        }
        public InputTeacherForm(Teacher tea)
        {//st非空为修改窗体；否则为增加窗体
            InitializeComponent();
            //   htDept = TeacherManageAction0.getDeptList();
            StudentManageAction.getDeptList(htDeptId, htDeptName);
            foreach (DictionaryEntry de in htDeptName)
                cbDept.Items.Add(de.Key);
            if (tea == null)
            {
                tbWorkerNo.Enabled = true;
                this.Text = "增加教师";
                isUpdate = false;
                btAdd.Text = "增加";
            }
            else
            {
                this.Text = "修改教师信息";
                tbWorkerNo.Enabled = false;

                tbWorkerNo.Text = tea.workerNo;
                tbWorkerName.Text = tea.workerName;
                cbSex.Text = tea.sex;
                string deptName = (string)htDeptId[tea.deptId];
                int i = cbDept.Items.IndexOf(deptName);
                if (i >= 0) cbDept.SelectedIndex = i;
                cbDept.Text = deptName;
                isUpdate = true;
                btAdd.Text = "保存修改";
            }
        }

        //增加
        private void btAdd_Click_1(object sender, EventArgs e)
        {
            string deptId = (string)htDeptName[cbDept.Text];
            int i = 0;
            if (tbWorkerNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("工号不能为空", "提示");
                tbWorkerName.Focus();
                return;
            }
            Teacher teacher = new Teacher(tbWorkerNo.Text, tbWorkerName.Text, cbSex.Text, deptId);
            TeacherManageAction0 tma = new TeacherManageAction0();
            tma.setTeacher(teacher);
            if (isUpdate == false)
            {
                i = tma.addTeacher();
                if (i > 0)
                {
                    MessageBox.Show(string.Format("增加了{0}条记录", i));
                    foreach (Control ctrl in groupBox1.Controls)
                    {
                        if (!(ctrl is Label)) ctrl.Text = "";
                    }
                }
                else MessageBox.Show("添加不成功");
            }
            else
            {
                i = tma.updateTeacher();
                if (i > 0)
                {
                    MessageBox.Show(string.Format("更新了{0}条记录", i));
                    this.Close();
                }
                else MessageBox.Show("更新不成功");
            }

        }

        //关闭窗口
        private void btClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }    
}
