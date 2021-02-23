
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
            this.moduleIDLbl = new System.Windows.Forms.Label();
            this.moduleTitleLbl = new System.Windows.Forms.Label();
            this.moduleOutlineLbl = new System.Windows.Forms.Label();
            this.moduleOutlineTbx = new System.Windows.Forms.TextBox();
            this.firstBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.lastBtn = new System.Windows.Forms.Button();
            this.moduleTasksDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moduleTasksDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleIDTbx
            // 
            this.moduleIDTbx.Location = new System.Drawing.Point(129, 89);
            this.moduleIDTbx.Name = "moduleIDTbx";
            this.moduleIDTbx.Size = new System.Drawing.Size(68, 22);
            this.moduleIDTbx.TabIndex = 0;
            // 
            // moduleNameTbx
            // 
            this.moduleNameTbx.Location = new System.Drawing.Point(129, 127);
            this.moduleNameTbx.Name = "moduleNameTbx";
            this.moduleNameTbx.Size = new System.Drawing.Size(543, 22);
            this.moduleNameTbx.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(841, 779);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(160, 37);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // recordTrackerTbx
            // 
            this.recordTrackerTbx.Location = new System.Drawing.Point(384, 790);
            this.recordTrackerTbx.Name = "recordTrackerTbx";
            this.recordTrackerTbx.Size = new System.Drawing.Size(65, 22);
            this.recordTrackerTbx.TabIndex = 3;
            // 
            // moduleIDLbl
            // 
            this.moduleIDLbl.AutoSize = true;
            this.moduleIDLbl.Location = new System.Drawing.Point(12, 89);
            this.moduleIDLbl.Name = "moduleIDLbl";
            this.moduleIDLbl.Size = new System.Drawing.Size(71, 17);
            this.moduleIDLbl.TabIndex = 4;
            this.moduleIDLbl.Text = "Module ID";
            // 
            // moduleTitleLbl
            // 
            this.moduleTitleLbl.AutoSize = true;
            this.moduleTitleLbl.Location = new System.Drawing.Point(12, 130);
            this.moduleTitleLbl.Name = "moduleTitleLbl";
            this.moduleTitleLbl.Size = new System.Drawing.Size(95, 17);
            this.moduleTitleLbl.TabIndex = 5;
            this.moduleTitleLbl.Text = "Module Name";
            // 
            // moduleOutlineLbl
            // 
            this.moduleOutlineLbl.AutoSize = true;
            this.moduleOutlineLbl.Location = new System.Drawing.Point(12, 169);
            this.moduleOutlineLbl.Name = "moduleOutlineLbl";
            this.moduleOutlineLbl.Size = new System.Drawing.Size(103, 17);
            this.moduleOutlineLbl.TabIndex = 6;
            this.moduleOutlineLbl.Text = "Module Outline";
            // 
            // moduleOutlineTbx
            // 
            this.moduleOutlineTbx.Location = new System.Drawing.Point(129, 166);
            this.moduleOutlineTbx.Multiline = true;
            this.moduleOutlineTbx.Name = "moduleOutlineTbx";
            this.moduleOutlineTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.moduleOutlineTbx.Size = new System.Drawing.Size(766, 98);
            this.moduleOutlineTbx.TabIndex = 7;
            // 
            // firstBtn
            // 
            this.firstBtn.Location = new System.Drawing.Point(145, 781);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(102, 40);
            this.firstBtn.TabIndex = 8;
            this.firstBtn.Text = "&First";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(263, 781);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(102, 40);
            this.previousBtn.TabIndex = 9;
            this.previousBtn.Text = "&Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(468, 781);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(102, 40);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "&Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lastBtn
            // 
            this.lastBtn.Location = new System.Drawing.Point(588, 781);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(102, 40);
            this.lastBtn.TabIndex = 11;
            this.lastBtn.Text = "&Last";
            this.lastBtn.UseVisualStyleBackColor = true;
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click);
            // 
            // moduleTasksDgv
            // 
            this.moduleTasksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moduleTasksDgv.Location = new System.Drawing.Point(57, 331);
            this.moduleTasksDgv.Name = "moduleTasksDgv";
            this.moduleTasksDgv.RowHeadersWidth = 51;
            this.moduleTasksDgv.RowTemplate.Height = 24;
            this.moduleTasksDgv.Size = new System.Drawing.Size(855, 261);
            this.moduleTasksDgv.TabIndex = 12;
            // 
            // mergedFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 831);
            this.Controls.Add(this.moduleTasksDgv);
            this.Controls.Add(this.lastBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.firstBtn);
            this.Controls.Add(this.moduleOutlineTbx);
            this.Controls.Add(this.moduleOutlineLbl);
            this.Controls.Add(this.moduleTitleLbl);
            this.Controls.Add(this.moduleIDLbl);
            this.Controls.Add(this.recordTrackerTbx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.moduleNameTbx);
            this.Controls.Add(this.moduleIDTbx);
            this.Name = "mergedFrm";
            this.Text = "SQL Query Form";
            this.Load += new System.EventHandler(this.mergedFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moduleTasksDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox moduleIDTbx;
        private System.Windows.Forms.TextBox moduleNameTbx;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox recordTrackerTbx;
        private System.Windows.Forms.Label moduleIDLbl;
        private System.Windows.Forms.Label moduleTitleLbl;
        private System.Windows.Forms.Label moduleOutlineLbl;
        private System.Windows.Forms.TextBox moduleOutlineTbx;
        private System.Windows.Forms.Button firstBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button lastBtn;
        private System.Windows.Forms.DataGridView moduleTasksDgv;
    }
}