
namespace studentProgressionTracker
{
    partial class Form1
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
            this.moduleTasksDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moduleTasksDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleTasksDgv
            // 
            this.moduleTasksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moduleTasksDgv.Location = new System.Drawing.Point(29, 82);
            this.moduleTasksDgv.Name = "moduleTasksDgv";
            this.moduleTasksDgv.RowHeadersWidth = 51;
            this.moduleTasksDgv.RowTemplate.Height = 24;
            this.moduleTasksDgv.Size = new System.Drawing.Size(735, 319);
            this.moduleTasksDgv.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moduleTasksDgv);
            this.Name = "Form1";
            this.Text = "Merged Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moduleTasksDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView moduleTasksDgv;
    }
}