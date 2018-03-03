namespace Ntier2015
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看我的课表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.开设课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.开课查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.查看我的专业课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.教师管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.查看我的课表ToolStripMenuItem,
            this.查看我的专业课程ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.增加ToolStripMenuItem.Text = "增加";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查询ToolStripMenuItem.Text = "查询/修改";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 查看我的课表ToolStripMenuItem
            // 
            this.查看我的课表ToolStripMenuItem.Name = "查看我的课表ToolStripMenuItem";
            this.查看我的课表ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看我的课表ToolStripMenuItem.Text = "查看我的课表";
            this.查看我的课表ToolStripMenuItem.Click += new System.EventHandler(this.查看我的课表ToolStripMenuItem_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem1,
            this.查询ToolStripMenuItem1,
            this.开设课程ToolStripMenuItem,
            this.选课ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 增加ToolStripMenuItem1
            // 
            this.增加ToolStripMenuItem1.Name = "增加ToolStripMenuItem1";
            this.增加ToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.增加ToolStripMenuItem1.Text = "增加";
            this.增加ToolStripMenuItem1.Click += new System.EventHandler(this.增加ToolStripMenuItem1_Click);
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.查询ToolStripMenuItem1.Text = "查询/修改";
            this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.查询ToolStripMenuItem1_Click);
            // 
            // 开设课程ToolStripMenuItem
            // 
            this.开设课程ToolStripMenuItem.Name = "开设课程ToolStripMenuItem";
            this.开设课程ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.开设课程ToolStripMenuItem.Text = "开设课程";
            this.开设课程ToolStripMenuItem.Click += new System.EventHandler(this.开设课程ToolStripMenuItem_Click);
            // 
            // 选课ToolStripMenuItem
            // 
            this.选课ToolStripMenuItem.Name = "选课ToolStripMenuItem";
            this.选课ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.选课ToolStripMenuItem.Text = "选课";
            this.选课ToolStripMenuItem.Click += new System.EventHandler(this.选课ToolStripMenuItem_Click_1);
            // 
            // 教师管理ToolStripMenuItem
            // 
            this.教师管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem2,
            this.修改ToolStripMenuItem2,
            this.开课查询ToolStripMenuItem});
            this.教师管理ToolStripMenuItem.Name = "教师管理ToolStripMenuItem";
            this.教师管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.教师管理ToolStripMenuItem.Text = "教师管理";
            // 
            // 增加ToolStripMenuItem2
            // 
            this.增加ToolStripMenuItem2.Name = "增加ToolStripMenuItem2";
            this.增加ToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.增加ToolStripMenuItem2.Text = "增加";
            this.增加ToolStripMenuItem2.Click += new System.EventHandler(this.增加ToolStripMenuItem2_Click);
            // 
            // 修改ToolStripMenuItem2
            // 
            this.修改ToolStripMenuItem2.Name = "修改ToolStripMenuItem2";
            this.修改ToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.修改ToolStripMenuItem2.Text = "查询/修改";
            this.修改ToolStripMenuItem2.Click += new System.EventHandler(this.修改ToolStripMenuItem2_Click);
            // 
            // 开课查询ToolStripMenuItem
            // 
            this.开课查询ToolStripMenuItem.Name = "开课查询ToolStripMenuItem";
            this.开课查询ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.开课查询ToolStripMenuItem.Text = "开课查询";
            this.开课查询ToolStripMenuItem.Click += new System.EventHandler(this.开课查询ToolStripMenuItem1_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩输入ToolStripMenuItem,
            this.成绩查询ToolStripMenuItem,
            this.成绩分析ToolStripMenuItem});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 成绩输入ToolStripMenuItem
            // 
            this.成绩输入ToolStripMenuItem.Name = "成绩输入ToolStripMenuItem";
            this.成绩输入ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.成绩输入ToolStripMenuItem.Text = "成绩输入/修改";
            this.成绩输入ToolStripMenuItem.Click += new System.EventHandler(this.成绩输入ToolStripMenuItem_Click);
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            this.成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem_Click);
            // 
            // 成绩分析ToolStripMenuItem
            // 
            this.成绩分析ToolStripMenuItem.Name = "成绩分析ToolStripMenuItem";
            this.成绩分析ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.成绩分析ToolStripMenuItem.Text = "成绩分析";
            this.成绩分析ToolStripMenuItem.Click += new System.EventHandler(this.成绩分析ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=WLI_MARY;integrated security=SSPI;initial catalog=" +
    "exam";
            // 
            // 查看我的专业课程ToolStripMenuItem
            // 
            this.查看我的专业课程ToolStripMenuItem.Name = "查看我的专业课程ToolStripMenuItem";
            this.查看我的专业课程ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看我的专业课程ToolStripMenuItem.Text = "查看我的专业课程";
            this.查看我的专业课程ToolStripMenuItem.Click += new System.EventHandler(this.查看我的专业课程ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "教务管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 开设课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩输入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开课查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看我的课表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看我的专业课程ToolStripMenuItem;
    }
}

