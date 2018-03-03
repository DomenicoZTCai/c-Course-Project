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
    public partial class Faculty : Form
    {
        bool[] dept;
        public Faculty()
        {
            InitializeComponent();
        }
        public Faculty(ref bool[] dept)
        {
            InitializeComponent();
            this.dept = dept;
            for (int i = 0; i < dept.Length; i++)
                if (dept[i])
                    clDept.SetItemCheckState(i, CheckState.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dept.Length; i++)
                if (clDept.GetItemChecked(i))
                    dept[i] = true;
                else
                    dept[i] = false;
            this.Hide();
        }

    }
}
