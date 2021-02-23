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
        String username;
        public frmMenu(String un)
        {
            username = un;
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = ("Welcome, "  + username);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.ShowDialog();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            //this.Hide();
            moduleInformationFrm moduleForm = new moduleInformationFrm(username);
            moduleForm.Closed += (s, args) => this.Close();
            moduleForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourseInfo courseForm = new frmCourseInfo(username);
            courseForm.Closed += (s, args) => this.Close();
            courseForm.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentInfo studentForm = new frmStudentInfo(username);
            studentForm.Closed += (s, args) => this.Close();
            studentForm.ShowDialog();
        }

        private void btnAssingment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAssingmentRecs assingmentForm = new frmAssingmentRecs(username);
            assingmentForm.Closed += (s, args) => this.Close();
            assingmentForm.ShowDialog();
        }
    }
}
