﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentProgressionTracker
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void picboxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menuForm = new frmMenu();
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }
    }
}
