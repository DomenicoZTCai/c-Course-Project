using Ntier2015.UserManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ntier2015
{
    public partial class LoginForm : Form
    {
        private User user = null;
        private Form parentForm = null;
        public LoginForm()
        {
            InitializeComponent();
            textBox1.Text = "蔡中天：学生选课，我的课表\r\n陈德立：我的专业课表，学生管理，教师管理\r\n施震宇：课程，开课管理\r\n曾佳丽：成绩管理";

        }
        public LoginForm(Form fm)
        {
            InitializeComponent();
            parentForm = fm;
            textBox1.Text = "蔡中天：学生选课，我的课表\r\n陈德立：我的专业课表，学生管理，教师管理\r\n施震宇：课程，开课管理\r\n曾佳丽：成绩管理";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = tbAccount.Text;
            string pwd = tbPassword.Text;
            string a = tbValidate.Text; string b = lbValidate.Text;
            if (account == "" || pwd == "" || a == "")
                lblErrorMessage.Text = "不能为空！";
            else if (!a.Equals(b))
            {
                lblErrorMessage.Text = "验证码有误！";
                tbValidate.Text = "";
            }
            else
            {
                user = UserManageAction.validUser(account, pwd);
                //得到当前user
                if (user != null)
                {
                    this.Close();
                }
                else
                {
                    lblErrorMessage.Text = "用户名和密码不匹配";
                    tbValidate.Clear(); tbPassword.Clear(); tbAccount.Clear();
                }
            }
        }
        public User getUser()
        {
            return this.user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.lbValidate.Text = RandomNum(4);
            this.tbValidate.Text = this.lbValidate.Text; //测试时用，不用输入
        }
        public string RandomNum(int n)
        {
            string str = "0,1,2,3,4,5,6,7,8,9";
            string[] VcArry = str.Split(',');
            string VNum = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < n + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(9);
                if (temp != -1 && temp == t)
                    return RandomNum(n);
                temp = t; VNum += VcArry[t];
            }
            return VNum;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.lbValidate.Text = RandomNum(4);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.parentForm.Show();
        }


    }
}
