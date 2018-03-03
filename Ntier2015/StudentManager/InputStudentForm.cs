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
        bool isUpdate = false;  //��ʼΪ���Ӵ���
        StudentManageAction sma = new StudentManageAction();
        public InputStudentForm():this(null)
        {
        }
        public InputStudentForm(Student st)
        {//st�ǿ�Ϊ�޸Ĵ��壻����Ϊ���Ӵ���
            InitializeComponent();
         //   htDept = StudentManageAction.getDeptList();
            StudentManageAction.getDeptList(htDeptId,htDeptName);
            foreach (DictionaryEntry de in htDeptName)
                cbDept.Items.Add(de.Key);
            if (st == null)
            {
                tbStudentNo.Enabled = true;
                this.Text = "����ѧ��";
                isUpdate = false;
                btnAdd.Text = "����";
            }
            else
            {
                this.Text = "�޸�ѧ����Ϣ";
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
                btnAdd.Text = "�����޸�";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string deptId = (string)htDeptName[cbDept.Text];
            int i = 0;
            if (tbStudentNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("ѧ�Ų���Ϊ��", "��ʾ");
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
                    MessageBox.Show(string.Format("������{0}����¼", i));
                    foreach (Control ctrl in groupBox2.Controls)
                    {
                        if (!(ctrl is Label)) ctrl.Text = "";
                    }
                }
                else MessageBox.Show("��Ӳ��ɹ�");
            }
            else
            {
                i=sma.updateStudent();
                if (i > 0)
                {
                    MessageBox.Show(string.Format("������{0}����¼", i));
                    this.Close();
                }
                else MessageBox.Show("���²��ɹ�");
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