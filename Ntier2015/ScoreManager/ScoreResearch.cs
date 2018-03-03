using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ntier2015.StudentManager;

namespace Ntier2015.ScoreManager
{
    public partial class ScoreResearch : Form
    {
        Student s;
        public ScoreResearch()
        {
            
        }

        public ScoreResearch (Student s)
        {
            InitializeComponent();
            this.s =s ;
            ScoreManageAction.QueryScoreInfo(listView1, s.studentNo);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "关闭";
            this.Close();
        }
        
    }
}
