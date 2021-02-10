
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
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnAssingment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.lblWelcome.Size = new System.Drawing.Size(210, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Shauna ";
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCourse.Location = new System.Drawing.Point(91, 131);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(234, 43);
            this.btnCourse.TabIndex = 4;
            this.btnCourse.Text = "Course Information";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStudent.Location = new System.Drawing.Point(91, 192);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(234, 43);
            this.btnStudent.TabIndex = 5;
            this.btnStudent.Text = "Student Information";
            this.btnStudent.UseVisualStyleBackColor = true;
            // 
            // btnAssingment
            // 
            this.btnAssingment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssingment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAssingment.Location = new System.Drawing.Point(91, 250);
            this.btnAssingment.Name = "btnAssingment";
            this.btnAssingment.Size = new System.Drawing.Size(234, 43);
            this.btnAssingment.TabIndex = 6;
            this.btnAssingment.Text = "Assignment Records";
            this.btnAssingment.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(91, 310);
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAssingment);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnCourse);
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
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnAssingment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}