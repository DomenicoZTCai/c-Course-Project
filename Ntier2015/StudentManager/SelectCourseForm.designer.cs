namespace Ntier2015.StudentManager
{
    partial class SelectCourseForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvSelectedCourse = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvUnselectedCourse = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.lvSelectedCompulsoryCourse = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvSelectedCourse);
            this.groupBox3.Location = new System.Drawing.Point(12, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 268);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "已选课程（双击退课）";
            // 
            // lvSelectedCourse
            // 
            this.lvSelectedCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
            this.lvSelectedCourse.FullRowSelect = true;
            this.lvSelectedCourse.GridLines = true;
            this.lvSelectedCourse.Location = new System.Drawing.Point(20, 20);
            this.lvSelectedCourse.MultiSelect = false;
            this.lvSelectedCourse.Name = "lvSelectedCourse";
            this.lvSelectedCourse.Size = new System.Drawing.Size(316, 233);
            this.lvSelectedCourse.TabIndex = 0;
            this.lvSelectedCourse.UseCompatibleStateImageBehavior = false;
            this.lvSelectedCourse.View = System.Windows.Forms.View.Details;
            this.lvSelectedCourse.DoubleClick += new System.EventHandler(this.lvSelectedCourse_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "开课号";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "课程名称";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "任课教师";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "成绩";
            this.columnHeader8.Width = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvUnselectedCourse);
            this.groupBox4.Location = new System.Drawing.Point(604, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 268);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "待选课程（双击选课）";
            // 
            // lvUnselectedCourse
            // 
            this.lvUnselectedCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader13,
            this.columnHeader1,
            this.columnHeader2});
            this.lvUnselectedCourse.FullRowSelect = true;
            this.lvUnselectedCourse.GridLines = true;
            this.lvUnselectedCourse.Location = new System.Drawing.Point(17, 20);
            this.lvUnselectedCourse.MultiSelect = false;
            this.lvUnselectedCourse.Name = "lvUnselectedCourse";
            this.lvUnselectedCourse.Size = new System.Drawing.Size(386, 233);
            this.lvUnselectedCourse.TabIndex = 1;
            this.lvUnselectedCourse.UseCompatibleStateImageBehavior = false;
            this.lvUnselectedCourse.View = System.Windows.Forms.View.Details;
            this.lvUnselectedCourse.DoubleClick += new System.EventHandler(this.lvUnselectedCourse_DoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "开课号";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "课程名称";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "任课教师";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "选课人数";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "容量";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "姓名";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(139, 21);
            this.textBox2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "查询公共选修课";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(721, 294);
            this.dataGridView1.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "选择计划中的课程";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lvSelectedCompulsoryCourse
            // 
            this.lvSelectedCompulsoryCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader12});
            this.lvSelectedCompulsoryCourse.FullRowSelect = true;
            this.lvSelectedCompulsoryCourse.GridLines = true;
            this.lvSelectedCompulsoryCourse.Location = new System.Drawing.Point(211, 68);
            this.lvSelectedCompulsoryCourse.MultiSelect = false;
            this.lvSelectedCompulsoryCourse.Name = "lvSelectedCompulsoryCourse";
            this.lvSelectedCompulsoryCourse.Size = new System.Drawing.Size(316, 233);
            this.lvSelectedCompulsoryCourse.TabIndex = 29;
            this.lvSelectedCompulsoryCourse.UseCompatibleStateImageBehavior = false;
            this.lvSelectedCompulsoryCourse.View = System.Windows.Forms.View.Details;
            this.lvSelectedCompulsoryCourse.DoubleClick += new System.EventHandler(this.lvSelectedCompulsoryCourse_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "课号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "课名";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "任课教师";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "考查方式";
            // 
            // SelectCourseForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1122, 628);
            this.Controls.Add(this.lvSelectedCompulsoryCourse);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "SelectCourseForm";
            this.Text = "SelectCourse";
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvSelectedCourse;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvUnselectedCourse;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lvSelectedCompulsoryCourse;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}