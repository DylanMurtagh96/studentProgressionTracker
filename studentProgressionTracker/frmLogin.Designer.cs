
namespace studentProgressionTracker
{
    partial class frmLogin
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
            this.gblogIn = new System.Windows.Forms.GroupBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gblogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gblogIn
            // 
            this.gblogIn.BackColor = System.Drawing.SystemColors.Control;
            this.gblogIn.Controls.Add(this.btnSignin);
            this.gblogIn.Controls.Add(this.label1);
            this.gblogIn.Controls.Add(this.txtPassword);
            this.gblogIn.Controls.Add(this.txtUsername);
            this.gblogIn.Controls.Add(this.lblPassword);
            this.gblogIn.Controls.Add(this.lblUsername);
            this.gblogIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gblogIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gblogIn.Location = new System.Drawing.Point(189, 93);
            this.gblogIn.Name = "gblogIn";
            this.gblogIn.Size = new System.Drawing.Size(365, 238);
            this.gblogIn.TabIndex = 0;
            this.gblogIn.TabStop = false;
            this.gblogIn.Enter += new System.EventHandler(this.gblogIn_Enter);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSignin.Location = new System.Drawing.Point(154, 169);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(178, 23);
            this.btnSignin.TabIndex = 5;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(154, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(178, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password1";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(154, 92);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(178, 24);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "AWG001";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(38, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(38, 92);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User Name:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentProgressionTracker.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 453);
            this.Controls.Add(this.gblogIn);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLogin";
            this.Text = "Student Tracker";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gblogIn.ResumeLayout(false);
            this.gblogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gblogIn;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}

