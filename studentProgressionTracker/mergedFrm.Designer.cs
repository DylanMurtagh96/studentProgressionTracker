
namespace studentProgressionTracker
{
    partial class mergedFrm
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
            this.moduleIDTbx = new System.Windows.Forms.TextBox();
            this.moduleNameTbx = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.recordTrackerTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // moduleIDTbx
            // 
            this.moduleIDTbx.Location = new System.Drawing.Point(192, 52);
            this.moduleIDTbx.Name = "moduleIDTbx";
            this.moduleIDTbx.Size = new System.Drawing.Size(213, 22);
            this.moduleIDTbx.TabIndex = 0;
            // 
            // moduleNameTbx
            // 
            this.moduleNameTbx.Location = new System.Drawing.Point(190, 120);
            this.moduleNameTbx.Name = "moduleNameTbx";
            this.moduleNameTbx.Size = new System.Drawing.Size(543, 22);
            this.moduleNameTbx.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(90, 335);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(102, 38);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // recordTrackerTbx
            // 
            this.recordTrackerTbx.Location = new System.Drawing.Point(185, 265);
            this.recordTrackerTbx.Name = "recordTrackerTbx";
            this.recordTrackerTbx.Size = new System.Drawing.Size(139, 22);
            this.recordTrackerTbx.TabIndex = 3;
            // 
            // mergedFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recordTrackerTbx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.moduleNameTbx);
            this.Controls.Add(this.moduleIDTbx);
            this.Name = "mergedFrm";
            this.Text = "SQL Query Form";
            this.Load += new System.EventHandler(this.mergedFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox moduleIDTbx;
        private System.Windows.Forms.TextBox moduleNameTbx;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox recordTrackerTbx;
    }
}