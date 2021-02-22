
namespace studentProgressionTracker
{
    partial class frmAssingmentRecs
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
            this.taskIDTbx = new System.Windows.Forms.TextBox();
            this.courseIDTbx = new System.Windows.Forms.TextBox();
            this.moduleIDTbx = new System.Windows.Forms.TextBox();
            this.assignmentsGbx = new System.Windows.Forms.GroupBox();
            this.taskValueTbx = new System.Windows.Forms.TextBox();
            this.taskNameTbx = new System.Windows.Forms.TextBox();
            this.taskOutlineTbx = new System.Windows.Forms.TextBox();
            this.taskIDLbl = new System.Windows.Forms.Label();
            this.courseIDLbl = new System.Windows.Forms.Label();
            this.moduleIDLbl = new System.Windows.Forms.Label();
            this.taskNameLbl = new System.Windows.Forms.Label();
            this.taskValueLbl = new System.Windows.Forms.Label();
            this.taskOutlineLbl = new System.Windows.Forms.Label();
            this.recordTrackerTbx = new System.Windows.Forms.TextBox();
            this.firstBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.lastBtn = new System.Windows.Forms.Button();
            this.assignmentsGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskIDTbx
            // 
            this.taskIDTbx.Location = new System.Drawing.Point(202, 32);
            this.taskIDTbx.Name = "taskIDTbx";
            this.taskIDTbx.Size = new System.Drawing.Size(100, 22);
            this.taskIDTbx.TabIndex = 0;
            // 
            // courseIDTbx
            // 
            this.courseIDTbx.Location = new System.Drawing.Point(202, 74);
            this.courseIDTbx.Name = "courseIDTbx";
            this.courseIDTbx.Size = new System.Drawing.Size(100, 22);
            this.courseIDTbx.TabIndex = 1;
            // 
            // moduleIDTbx
            // 
            this.moduleIDTbx.Location = new System.Drawing.Point(202, 114);
            this.moduleIDTbx.Name = "moduleIDTbx";
            this.moduleIDTbx.Size = new System.Drawing.Size(100, 22);
            this.moduleIDTbx.TabIndex = 2;
            // 
            // assignmentsGbx
            // 
            this.assignmentsGbx.Controls.Add(this.moduleIDLbl);
            this.assignmentsGbx.Controls.Add(this.courseIDLbl);
            this.assignmentsGbx.Controls.Add(this.taskIDLbl);
            this.assignmentsGbx.Controls.Add(this.taskIDTbx);
            this.assignmentsGbx.Controls.Add(this.moduleIDTbx);
            this.assignmentsGbx.Controls.Add(this.courseIDTbx);
            this.assignmentsGbx.Location = new System.Drawing.Point(67, 131);
            this.assignmentsGbx.Name = "assignmentsGbx";
            this.assignmentsGbx.Size = new System.Drawing.Size(329, 163);
            this.assignmentsGbx.TabIndex = 3;
            this.assignmentsGbx.TabStop = false;
            // 
            // taskValueTbx
            // 
            this.taskValueTbx.Location = new System.Drawing.Point(561, 210);
            this.taskValueTbx.Name = "taskValueTbx";
            this.taskValueTbx.Size = new System.Drawing.Size(100, 22);
            this.taskValueTbx.TabIndex = 4;
            // 
            // taskNameTbx
            // 
            this.taskNameTbx.Location = new System.Drawing.Point(561, 163);
            this.taskNameTbx.Name = "taskNameTbx";
            this.taskNameTbx.Size = new System.Drawing.Size(100, 22);
            this.taskNameTbx.TabIndex = 5;
            // 
            // taskOutlineTbx
            // 
            this.taskOutlineTbx.Location = new System.Drawing.Point(67, 346);
            this.taskOutlineTbx.Multiline = true;
            this.taskOutlineTbx.Name = "taskOutlineTbx";
            this.taskOutlineTbx.Size = new System.Drawing.Size(608, 172);
            this.taskOutlineTbx.TabIndex = 6;
            // 
            // taskIDLbl
            // 
            this.taskIDLbl.AutoSize = true;
            this.taskIDLbl.Location = new System.Drawing.Point(29, 33);
            this.taskIDLbl.Name = "taskIDLbl";
            this.taskIDLbl.Size = new System.Drawing.Size(56, 17);
            this.taskIDLbl.TabIndex = 3;
            this.taskIDLbl.Text = "Task ID";
            // 
            // courseIDLbl
            // 
            this.courseIDLbl.AutoSize = true;
            this.courseIDLbl.Location = new System.Drawing.Point(29, 79);
            this.courseIDLbl.Name = "courseIDLbl";
            this.courseIDLbl.Size = new System.Drawing.Size(70, 17);
            this.courseIDLbl.TabIndex = 4;
            this.courseIDLbl.Text = "Course ID";
            // 
            // moduleIDLbl
            // 
            this.moduleIDLbl.AutoSize = true;
            this.moduleIDLbl.Location = new System.Drawing.Point(29, 119);
            this.moduleIDLbl.Name = "moduleIDLbl";
            this.moduleIDLbl.Size = new System.Drawing.Size(71, 17);
            this.moduleIDLbl.TabIndex = 5;
            this.moduleIDLbl.Text = "Module ID";
            // 
            // taskNameLbl
            // 
            this.taskNameLbl.AutoSize = true;
            this.taskNameLbl.Location = new System.Drawing.Point(440, 166);
            this.taskNameLbl.Name = "taskNameLbl";
            this.taskNameLbl.Size = new System.Drawing.Size(80, 17);
            this.taskNameLbl.TabIndex = 7;
            this.taskNameLbl.Text = "Task Name";
            // 
            // taskValueLbl
            // 
            this.taskValueLbl.AutoSize = true;
            this.taskValueLbl.Location = new System.Drawing.Point(441, 210);
            this.taskValueLbl.Name = "taskValueLbl";
            this.taskValueLbl.Size = new System.Drawing.Size(79, 17);
            this.taskValueLbl.TabIndex = 8;
            this.taskValueLbl.Text = "Task Value";
            // 
            // taskOutlineLbl
            // 
            this.taskOutlineLbl.AutoSize = true;
            this.taskOutlineLbl.Location = new System.Drawing.Point(78, 315);
            this.taskOutlineLbl.Name = "taskOutlineLbl";
            this.taskOutlineLbl.Size = new System.Drawing.Size(88, 17);
            this.taskOutlineLbl.TabIndex = 9;
            this.taskOutlineLbl.Text = "Task Outline";
            // 
            // recordTrackerTbx
            // 
            this.recordTrackerTbx.Location = new System.Drawing.Point(322, 541);
            this.recordTrackerTbx.Name = "recordTrackerTbx";
            this.recordTrackerTbx.Size = new System.Drawing.Size(97, 22);
            this.recordTrackerTbx.TabIndex = 10;
            // 
            // firstBtn
            // 
            this.firstBtn.Location = new System.Drawing.Point(70, 532);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(105, 40);
            this.firstBtn.TabIndex = 11;
            this.firstBtn.Text = "&First";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click_1);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(193, 532);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(105, 40);
            this.previousBtn.TabIndex = 12;
            this.previousBtn.Text = "&Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click_1);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(443, 532);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(105, 40);
            this.nextBtn.TabIndex = 13;
            this.nextBtn.Text = "&Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click_1);
            // 
            // lastBtn
            // 
            this.lastBtn.Location = new System.Drawing.Point(570, 532);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(105, 40);
            this.lastBtn.TabIndex = 14;
            this.lastBtn.Text = "&Last";
            this.lastBtn.UseVisualStyleBackColor = true;
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click_1);
            // 
            // frmAssingmentRecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 595);
            this.Controls.Add(this.lastBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.firstBtn);
            this.Controls.Add(this.recordTrackerTbx);
            this.Controls.Add(this.taskOutlineLbl);
            this.Controls.Add(this.taskValueLbl);
            this.Controls.Add(this.taskNameLbl);
            this.Controls.Add(this.taskOutlineTbx);
            this.Controls.Add(this.taskNameTbx);
            this.Controls.Add(this.taskValueTbx);
            this.Controls.Add(this.assignmentsGbx);
            this.Name = "frmAssingmentRecs";
            this.Text = "Assignments informtation";
            this.Load += new System.EventHandler(this.frmAssingmentRecs_Load);
            this.assignmentsGbx.ResumeLayout(false);
            this.assignmentsGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskIDTbx;
        private System.Windows.Forms.TextBox courseIDTbx;
        private System.Windows.Forms.TextBox moduleIDTbx;
        private System.Windows.Forms.GroupBox assignmentsGbx;
        private System.Windows.Forms.Label moduleIDLbl;
        private System.Windows.Forms.Label courseIDLbl;
        private System.Windows.Forms.Label taskIDLbl;
        private System.Windows.Forms.TextBox taskValueTbx;
        private System.Windows.Forms.TextBox taskNameTbx;
        private System.Windows.Forms.TextBox taskOutlineTbx;
        private System.Windows.Forms.Label taskNameLbl;
        private System.Windows.Forms.Label taskValueLbl;
        private System.Windows.Forms.Label taskOutlineLbl;
        private System.Windows.Forms.TextBox recordTrackerTbx;
        private System.Windows.Forms.Button firstBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button lastBtn;
    }
}