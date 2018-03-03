using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntier2015.StudentManager
{
    public partial class selectCompulsoryCourseForm : Form
    {
        StudentManageAction sc = new StudentManageAction();
        Student st;
        Hashtable hashSelectedCompulsory;
        SelectCourseForm form;
        public selectCompulsoryCourseForm()
        {
            InitializeComponent();
        }

        public selectCompulsoryCourseForm(Student st, Hashtable ht,SelectCourseForm form)
        {
            InitializeComponent();
            this.st = st; this.hashSelectedCompulsory = ht; this.form = form;
            textBox1.Text = st.studentNo; textBox2.Text = st.studentName;
            lvCCF.CheckBoxes = true;
            st.loadCompulsoryCourse(lvCCF);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hashSelectedCompulsory.Clear();
            int i = 1;
            foreach (ListViewItem o in lvCCF.Items)
            {
                if (o.Checked == true) hashSelectedCompulsory.Add(i++, o.SubItems[0].Text.ToString());
            }
            this.form.Close();
            SelectCourseForm newform = new SelectCourseForm(st, hashSelectedCompulsory);
            newform.MdiParent = this.MdiParent;
            newform.Show();
            this.Close();
        }

    }
}
