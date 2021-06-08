
namespace studentProgressionTracker
{
    partial class moduleTaskInfoFrm
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
            this.backBtn = new System.Windows.Forms.Button();
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
            this.picboxHome = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moduleTasksDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleIDTbx
            // 
            this.moduleIDTbx.Location = new System.Drawing.Point(209, 130);
            this.moduleIDTbx.Name = "moduleIDTbx";
            this.moduleIDTbx.Size = new System.Drawing.Size(68, 22);
            this.moduleIDTbx.TabIndex = 0;
            // 
            // moduleNameTbx
            // 
            this.moduleNameTbx.Location = new System.Drawing.Point(522, 130);
            this.moduleNameTbx.Name = "moduleNameTbx";
            this.moduleNameTbx.Size = new System.Drawing.Size(543, 22);
            this.moduleNameTbx.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(905, 507);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(160, 37);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "B&ack to Module info";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // recordTrackerTbx
            // 
            this.recordTrackerTbx.Location = new System.Drawing.Point(448, 518);
            this.recordTrackerTbx.Name = "recordTrackerTbx";
            this.recordTrackerTbx.Size = new System.Drawing.Size(65, 22);
            this.recordTrackerTbx.TabIndex = 3;
            // 
            // moduleIDLbl
            // 
            this.moduleIDLbl.AutoSize = true;
            this.moduleIDLbl.Location = new System.Drawing.Point(126, 133);
            this.moduleIDLbl.Name = "moduleIDLbl";
            this.moduleIDLbl.Size = new System.Drawing.Size(71, 17);
            this.moduleIDLbl.TabIndex = 4;
            this.moduleIDLbl.Text = "Module ID";
            // 
            // moduleTitleLbl
            // 
            this.moduleTitleLbl.AutoSize = true;
            this.moduleTitleLbl.Location = new System.Drawing.Point(402, 130);
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
            this.moduleOutlineTbx.Size = new System.Drawing.Size(936, 98);
            this.moduleOutlineTbx.TabIndex = 7;
            // 
            // firstBtn
            // 
            this.firstBtn.Location = new System.Drawing.Point(209, 509);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(102, 40);
            this.firstBtn.TabIndex = 8;
            this.firstBtn.Text = "&First";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(327, 509);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(102, 40);
            this.previousBtn.TabIndex = 9;
            this.previousBtn.Text = "&Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(532, 509);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(102, 40);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "&Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lastBtn
            // 
            this.lastBtn.Location = new System.Drawing.Point(652, 509);
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
            this.moduleTasksDgv.Location = new System.Drawing.Point(129, 311);
            this.moduleTasksDgv.Name = "moduleTasksDgv";
            this.moduleTasksDgv.RowHeadersWidth = 51;
            this.moduleTasksDgv.RowTemplate.Height = 24;
            this.moduleTasksDgv.Size = new System.Drawing.Size(936, 146);
            this.moduleTasksDgv.TabIndex = 12;
            this.moduleTasksDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moduleTasksDgv_CellContentClick);
            this.moduleTasksDgv.DoubleClick += new System.EventHandler(this.moduleTasksDgv_CellContentDoubleClick);
            // 
            // picboxHome
            // 
            this.picboxHome.BackgroundImage = global::studentProgressionTracker.Properties.Resources.killester;
            this.picboxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxHome.Location = new System.Drawing.Point(45, 13);
            this.picboxHome.Margin = new System.Windows.Forms.Padding(4);
            this.picboxHome.Name = "picboxHome";
            this.picboxHome.Size = new System.Drawing.Size(152, 111);
            this.picboxHome.TabIndex = 35;
            this.picboxHome.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWelcome.Location = new System.Drawing.Point(351, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(445, 41);
            this.lblWelcome.TabIndex = 34;
            this.lblWelcome.Text = "Module Task Information";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Double click on any row to see further information about the individual tasks";
            // 
            // moduleTaskInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxHome);
            this.Controls.Add(this.lblWelcome);
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
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.moduleNameTbx);
            this.Controls.Add(this.moduleIDTbx);
            this.Name = "moduleTaskInfoFrm";
            this.Text = "Module Task Information";
            this.Load += new System.EventHandler(this.mergedFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moduleTasksDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox moduleIDTbx;
        private System.Windows.Forms.TextBox moduleNameTbx;
        private System.Windows.Forms.Button backBtn;
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
        private System.Windows.Forms.PictureBox picboxHome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
    }
}