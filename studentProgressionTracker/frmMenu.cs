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
            //this.Hide();
            moduleInformationFrm moduleForm = new moduleInformationFrm();
            moduleForm.Closed += (s, args) => this.Close();
            moduleForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourseInfo courseForm = new frmCourseInfo();
            courseForm.Closed += (s, args) => this.Close();
            courseForm.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentInfo studentForm = new frmStudentInfo();
            studentForm.Closed += (s, args) => this.Close();
            studentForm.ShowDialog();
        }

        private void btnAssingment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAssingmentRecs assingmentForm = new frmAssingmentRecs();
            assingmentForm.Closed += (s, args) => this.Close();
            assingmentForm.ShowDialog();
        }
    }
}
