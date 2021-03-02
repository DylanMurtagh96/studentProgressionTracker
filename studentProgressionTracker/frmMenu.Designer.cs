
namespace studentProgressionTracker
{
    partial class frmMenu
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.moduleBtn = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnAssingment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courseInfoBtn = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWelcome.Location = new System.Drawing.Point(153, 44);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 32);
            this.lblWelcome.TabIndex = 0;
            // 
            // moduleBtn
            // 
            this.moduleBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.moduleBtn.Location = new System.Drawing.Point(91, 119);
            this.moduleBtn.Name = "moduleBtn";
            this.moduleBtn.Size = new System.Drawing.Size(234, 43);
            this.moduleBtn.TabIndex = 4;
            this.moduleBtn.Text = "Module Information";
            this.moduleBtn.UseVisualStyleBackColor = true;
            this.moduleBtn.Click += new System.EventHandler(this.moduleBtn_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStudent.Location = new System.Drawing.Point(91, 213);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(234, 43);
            this.btnStudent.TabIndex = 5;
            this.btnStudent.Text = "Student Information";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnAssingment
            // 
            this.btnAssingment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssingment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAssingment.Location = new System.Drawing.Point(91, 261);
            this.btnAssingment.Name = "btnAssingment";
            this.btnAssingment.Size = new System.Drawing.Size(234, 43);
            this.btnAssingment.TabIndex = 6;
            this.btnAssingment.Text = "Task Records";
            this.btnAssingment.UseVisualStyleBackColor = true;
            this.btnAssingment.Click += new System.EventHandler(this.taskBtn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(91, 309);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(234, 43);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::studentProgressionTracker.Properties.Resources.killester;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 90);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // courseInfoBtn
            // 
            this.courseInfoBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseInfoBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.courseInfoBtn.Location = new System.Drawing.Point(91, 166);
            this.courseInfoBtn.Name = "courseInfoBtn";
            this.courseInfoBtn.Size = new System.Drawing.Size(234, 43);
            this.courseInfoBtn.TabIndex = 9;
            this.courseInfoBtn.Text = "Course Information";
            this.courseInfoBtn.UseVisualStyleBackColor = true;
            this.courseInfoBtn.Click += new System.EventHandler(this.courseInfoBtn_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 24);
            this.txtName.TabIndex = 10;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.courseInfoBtn);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAssingment);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.moduleBtn);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button moduleBtn;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnAssingment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button courseInfoBtn;
        private System.Windows.Forms.TextBox txtName;
    }
}