using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
                 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourseInfo courseForm = new frmCourseInfo();
            courseForm.Closed += (s, args) => this.Close();
            courseForm.ShowDialog();

        }
    }
}
