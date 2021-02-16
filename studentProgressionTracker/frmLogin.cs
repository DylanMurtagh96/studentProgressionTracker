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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Shauna Doyle") && txtPassword.Text.Equals("Password1"))
            {
                this.Hide();
                frmMenu menuForm = new frmMenu();
                menuForm.Closed += (s, args) => this.Close();
                menuForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR: Please enter the correct user name and password", "Invalid Input", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
