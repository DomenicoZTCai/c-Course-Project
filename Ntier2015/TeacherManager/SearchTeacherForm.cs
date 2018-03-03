using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntier2015.TeacherManager
{
    public partial class SearchTeacherForm : Form
    {
        public SearchTeacherForm()
        {
            InitializeComponent();
        }


        //查询
        private void btSearch_Click_1(object sender, EventArgs e)
        {
            string tNo = tbWorkerNo.Text;
            string tName = tbWorkerName.Text;
            string deptId = cbFaculty.Text;
            lvWorkerList.Items.Clear();
            TeacherManageAction0.loadAllTeacher(lvWorkerList, tName, tNo,deptId);
        }

        private void lvWorkerList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvWorkerList.SelectedItems.Count == 0) return; //未选中任何一行
            string tno = lvWorkerList.SelectedItems[0].Text;  //取选中行中的第一行的第一列文本
            tbWorkerNo.Text = tno;
            tbWorkerName.Text = lvWorkerList.SelectedItems[0].SubItems[1].Text;
            cbFaculty.Text = lvWorkerList.SelectedItems[0].SubItems[3].Text;
            TeacherManageAction0.loadSelectedCourse(lvCourse, tno);   //与课本不同，多一个参数
        }

        //修改
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Teacher t = TeacherManageAction0.QueryTeacherInfo(tbWorkerNo.Text);
            InputTeacherForm asf = new InputTeacherForm(t);
            asf.MdiParent = this.MdiParent;
            asf.Show();
            TeacherManageAction0.loadAllTeacher(lvWorkerList, "", "","");
        }

        //删除一条教师记录
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (tbWorkerNo.Text == "") return;

            if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = TeacherManageAction0.delTeacher(tbWorkerNo.Text.Trim());
                MessageBox.Show(i + " row(s) affected");
            }
            TeacherManageAction0.loadAllTeacher(lvWorkerList, "", "","");
        }

        //清除查询项
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbWorkerNo.Text = "";
            tbWorkerName.Text = "";
            cbFaculty.Text = "";
        }

        //增加一条教师记录
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            InputTeacherForm itf = new InputTeacherForm();
            itf.MdiParent = this.MdiParent;
            itf.Show();
        }

        private void btnReUpdate_Click(object sender, EventArgs e)
        {
            TeacherManageAction0.loadAllTeacher(lvWorkerList, "", "","");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Size = new Size(780, 600);
                this.groupBox3.Visible = true;
            }
            else
            {
                this.Size = new Size(780, 360);
                this.groupBox3.Visible = false;
            }
        }

        private void SearchTeacherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
