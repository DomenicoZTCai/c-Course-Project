﻿namespace Ntier2015.StudentManager
{
    partial class CompulsoryCourseForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSName = new System.Windows.Forms.Label();
            this.labelSNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvCCF = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSDept = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.Location = new System.Drawing.Point(159, 43);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(65, 12);
            this.labelSName.TabIndex = 18;
            this.labelSName.Text = "学生姓名：";
            // 
            // labelSNo
            // 
            this.labelSNo.AutoSize = true;
            this.labelSNo.Location = new System.Drawing.Point(40, 43);
            this.labelSNo.Name = "labelSNo";
            this.labelSNo.Size = new System.Drawing.Size(41, 12);
            this.labelSNo.TabIndex = 17;
            this.labelSNo.Text = "学号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvCCF);
            this.groupBox1.Location = new System.Drawing.Point(43, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 229);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "我的专业课表";
            // 
            // lvCCF
            // 
            this.lvCCF.FullRowSelect = true;
            this.lvCCF.GridLines = true;
            this.lvCCF.Location = new System.Drawing.Point(31, 31);
            this.lvCCF.MultiSelect = false;
            this.lvCCF.Name = "lvCCF";
            this.lvCCF.Size = new System.Drawing.Size(315, 176);
            this.lvCCF.TabIndex = 8;
            this.lvCCF.UseCompatibleStateImageBehavior = false;
            this.lvCCF.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            // 
            // labelSDept
            // 
            this.labelSDept.AutoSize = true;
            this.labelSDept.Location = new System.Drawing.Point(300, 43);
            this.labelSDept.Name = "labelSDept";
            this.labelSDept.Size = new System.Drawing.Size(65, 12);
            this.labelSDept.TabIndex = 21;
            this.labelSDept.Text = "所属学院：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompulsoryCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.labelSNo);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompulsoryCourseForm";
            this.Text = "CompulsoryCourseForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.Label labelSNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvCCF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSDept;
        private System.Windows.Forms.Button button1;
    }
}