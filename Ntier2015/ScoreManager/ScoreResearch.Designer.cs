﻿namespace Ntier2015.ScoreManager
{
    partial class ScoreResearch
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
            this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.Text = "课程名称";
            this.courseName.Width = 90;
            // 
            // point
            // 
            this.point.Text = "学分";
            this.point.Width = 70;
            // 
            // score
            // 
            this.score.Text = "成绩";
            this.score.Width = 69;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseName,
            this.point,
            this.score});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(60, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(329, 274);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScoreResearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "ScoreResearch";
            this.Text = "成绩查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader courseName;
        private System.Windows.Forms.ColumnHeader point;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;

    }
}