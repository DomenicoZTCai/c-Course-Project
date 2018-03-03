using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntier2015.TeacherManager
{
    public class Teacher
    {
        public String workerNo, workerName, sex, deptId;
        public Teacher(string tNo, string tName, string sex, string deptId)
        {
            workerNo = tNo; workerName = tName; this.sex = sex;
            this.deptId = deptId;
        }
        public Teacher()
        {
        }

        public void loadSelectCourse(ListView lv)
        {
            TeacherManageAction0.loadSelectedCourse(lv, workerNo);
        }

    }
}
