using System;
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
    public partial class CheckCourseForm : Form
    {
        StudentManageAction sc = new StudentManageAction();
        Student st;

        public CheckCourseForm()
        {
            InitializeComponent();
        }

        public CheckCourseForm(Student st)
        {
            InitializeComponent();
            this.st = st;
            st.loadSelectedCourseToTimetable(dataGridView1);
            st.loadMyTimetable(lvMyTimetable);
        }
    }
}
