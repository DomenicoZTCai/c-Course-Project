namespace Ntier2015.CourseManager
{
    partial class OpenCourseForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbWorkerNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCourseNo = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.cbEndWeek = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStartWeek = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTeachCourseNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCourseName = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 24;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCourseName);
            this.groupBox2.Controls.Add(this.tbWorkerNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCourseNo);
            this.groupBox2.Controls.Add(this.tbAmount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTeacher);
            this.groupBox2.Controls.Add(this.cbEndWeek);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbStartWeek);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTeachCourseNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(42, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 191);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // tbWorkerNo
            // 
            this.tbWorkerNo.Location = new System.Drawing.Point(260, 88);
            this.tbWorkerNo.Name = "tbWorkerNo";
            this.tbWorkerNo.Size = new System.Drawing.Size(46, 21);
            this.tbWorkerNo.TabIndex = 29;
            this.tbWorkerNo.Leave += new System.EventHandler(this.tbWorkerNo_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "课程号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "教师工号";
            // 
            // tbCourseNo
            // 
            this.tbCourseNo.Enabled = false;
            this.tbCourseNo.Location = new System.Drawing.Point(260, 57);
            this.tbCourseNo.Name = "tbCourseNo";
            this.tbCourseNo.Size = new System.Drawing.Size(46, 21);
            this.tbCourseNo.TabIndex = 27;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(92, 118);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(136, 21);
            this.tbAmount.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "容纳人数";
            // 
            // tbTeacher
            // 
            this.tbTeacher.Location = new System.Drawing.Point(92, 88);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Size = new System.Drawing.Size(87, 21);
            this.tbTeacher.TabIndex = 23;
            this.tbTeacher.Leave += new System.EventHandler(this.tbTeacher_Leave);
            // 
            // cbEndWeek
            // 
            this.cbEndWeek.FormattingEnabled = true;
            this.cbEndWeek.Items.AddRange(new object[] {
            "9",
            "17"});
            this.cbEndWeek.Location = new System.Drawing.Point(198, 148);
            this.cbEndWeek.Name = "cbEndWeek";
            this.cbEndWeek.Size = new System.Drawing.Size(74, 20);
            this.cbEndWeek.TabIndex = 19;
            this.cbEndWeek.Text = "17";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "结束周";
            // 
            // cbStartWeek
            // 
            this.cbStartWeek.FormattingEnabled = true;
            this.cbStartWeek.Items.AddRange(new object[] {
            "1",
            "10"});
            this.cbStartWeek.Location = new System.Drawing.Point(60, 148);
            this.cbStartWeek.Name = "cbStartWeek";
            this.cbStartWeek.Size = new System.Drawing.Size(74, 20);
            this.cbStartWeek.TabIndex = 17;
            this.cbStartWeek.Text = "1";
            this.cbStartWeek.SelectedIndexChanged += new System.EventHandler(this.cbStartWeek_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "起始周";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "(4位数字)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开课号";
            // 
            // tbTeachCourseNo
            // 
            this.tbTeachCourseNo.Location = new System.Drawing.Point(93, 30);
            this.tbTeachCourseNo.Name = "tbTeachCourseNo";
            this.tbTeachCourseNo.Size = new System.Drawing.Size(135, 21);
            this.tbTeachCourseNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "任课教师";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 20);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCourseName
            // 
            this.cbCourseName.Enabled = false;
            this.cbCourseName.FormattingEnabled = true;
            this.cbCourseName.Location = new System.Drawing.Point(92, 58);
            this.cbCourseName.Name = "cbCourseName";
            this.cbCourseName.Size = new System.Drawing.Size(99, 20);
            this.cbCourseName.TabIndex = 30;
            // 
            // OpenCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdd);
            this.Name = "OpenCourseForm";
            this.Text = "OpenCourse";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.ComboBox cbEndWeek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStartWeek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTeachCourseNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWorkerNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCourseNo;
        private System.Windows.Forms.ComboBox cbCourseName;
    }
}