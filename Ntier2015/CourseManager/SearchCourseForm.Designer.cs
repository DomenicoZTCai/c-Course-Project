namespace Ntier2015.CourseManager
{
    partial class SearchCourseForm
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
            this.lvLessons = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCheckStudentLst = new System.Windows.Forms.Button();
            this.btoOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvCourse = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCourseNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btoDelete = new System.Windows.Forms.Button();
            this.btoRevise = new System.Windows.Forms.Button();
            this.btoUpdate = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvLessons);
            this.groupBox3.Location = new System.Drawing.Point(37, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 163);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "对应已开设的课";
            // 
            // lvLessons
            // 
            this.lvLessons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvLessons.FullRowSelect = true;
            this.lvLessons.GridLines = true;
            this.lvLessons.Location = new System.Drawing.Point(5, 20);
            this.lvLessons.MultiSelect = false;
            this.lvLessons.Name = "lvLessons";
            this.lvLessons.Size = new System.Drawing.Size(501, 128);
            this.lvLessons.TabIndex = 0;
            this.lvLessons.UseCompatibleStateImageBehavior = false;
            this.lvLessons.View = System.Windows.Forms.View.Details;
            this.lvLessons.SelectedIndexChanged += new System.EventHandler(this.lvLessons_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "开课号";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "课程名称";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "任课老师";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "容纳人数";
            this.columnHeader6.Width = 78;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "上课时间";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 124;
            // 
            // btCheckStudentLst
            // 
            this.btCheckStudentLst.Location = new System.Drawing.Point(464, 303);
            this.btCheckStudentLst.Name = "btCheckStudentLst";
            this.btCheckStudentLst.Size = new System.Drawing.Size(96, 23);
            this.btCheckStudentLst.TabIndex = 8;
            this.btCheckStudentLst.Text = "已选学生名单";
            this.btCheckStudentLst.UseVisualStyleBackColor = true;
            this.btCheckStudentLst.Click += new System.EventHandler(this.button3_Click);
            // 
            // btoOpen
            // 
            this.btoOpen.Location = new System.Drawing.Point(573, 353);
            this.btoOpen.Name = "btoOpen";
            this.btoOpen.Size = new System.Drawing.Size(75, 23);
            this.btoOpen.TabIndex = 7;
            this.btoOpen.Text = "添加开课";
            this.btoOpen.UseVisualStyleBackColor = true;
            this.btoOpen.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvCourse);
            this.groupBox2.Location = new System.Drawing.Point(37, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 151);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // lvCourse
            // 
            this.lvCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8});
            this.lvCourse.FullRowSelect = true;
            this.lvCourse.GridLines = true;
            this.lvCourse.Location = new System.Drawing.Point(6, 20);
            this.lvCourse.MultiSelect = false;
            this.lvCourse.Name = "lvCourse";
            this.lvCourse.Size = new System.Drawing.Size(501, 117);
            this.lvCourse.TabIndex = 0;
            this.lvCourse.UseCompatibleStateImageBehavior = false;
            this.lvCourse.View = System.Windows.Forms.View.Details;
            this.lvCourse.SelectedIndexChanged += new System.EventHandler(this.lvCourse_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "课程号";
            this.columnHeader1.Width = 208;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "课程名称";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "学分";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbCourseName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCourseNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 搜索条件";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(536, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(295, 28);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(156, 21);
            this.tbCourseName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程名称";
            // 
            // tbCourseNo
            // 
            this.tbCourseNo.Location = new System.Drawing.Point(82, 28);
            this.tbCourseNo.Name = "tbCourseNo";
            this.tbCourseNo.Size = new System.Drawing.Size(77, 21);
            this.tbCourseNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号";
            // 
            // btnReUpdate
            // 
            this.btnReUpdate.Location = new System.Drawing.Point(573, 250);
            this.btnReUpdate.Name = "btnReUpdate";
            this.btnReUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnReUpdate.TabIndex = 35;
            this.btnReUpdate.Text = "刷新";
            this.btnReUpdate.UseVisualStyleBackColor = true;
            this.btnReUpdate.Click += new System.EventHandler(this.btnReUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(573, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(573, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(573, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btoDelete
            // 
            this.btoDelete.Location = new System.Drawing.Point(573, 387);
            this.btoDelete.Name = "btoDelete";
            this.btoDelete.Size = new System.Drawing.Size(75, 23);
            this.btoDelete.TabIndex = 36;
            this.btoDelete.Text = "删除开课";
            this.btoDelete.UseVisualStyleBackColor = true;
            this.btoDelete.Click += new System.EventHandler(this.btoDelete_Click);
            // 
            // btoRevise
            // 
            this.btoRevise.Location = new System.Drawing.Point(573, 422);
            this.btoRevise.Name = "btoRevise";
            this.btoRevise.Size = new System.Drawing.Size(75, 23);
            this.btoRevise.TabIndex = 37;
            this.btoRevise.Text = "修改";
            this.btoRevise.UseVisualStyleBackColor = true;
            this.btoRevise.Click += new System.EventHandler(this.btoRevise_Click);
            // 
            // btoUpdate
            // 
            this.btoUpdate.Location = new System.Drawing.Point(573, 457);
            this.btoUpdate.Name = "btoUpdate";
            this.btoUpdate.Size = new System.Drawing.Size(75, 23);
            this.btoUpdate.TabIndex = 38;
            this.btoUpdate.Text = "刷新";
            this.btoUpdate.UseVisualStyleBackColor = true;
            this.btoUpdate.Click += new System.EventHandler(this.button6_Click);
            // 
            // SearchCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 504);
            this.Controls.Add(this.btoUpdate);
            this.Controls.Add(this.btoRevise);
            this.Controls.Add(this.btoDelete);
            this.Controls.Add(this.btnReUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btCheckStudentLst);
            this.Controls.Add(this.btoOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchCourseForm";
            this.Text = "SearchCourseForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvLessons;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btCheckStudentLst;
        private System.Windows.Forms.Button btoOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvCourse;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCourseNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btoDelete;
        private System.Windows.Forms.Button btoRevise;
        private System.Windows.Forms.Button btoUpdate;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}