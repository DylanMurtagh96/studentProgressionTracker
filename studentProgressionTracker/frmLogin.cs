using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
                           @"Data Source = ..\..\..\courseModuleDB.accdb;";

            var cmdText = "select Count(*) from student where studentID=? and [password]=?";
            using (OleDbConnection con = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p2", txtPassword.Text);  
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    String username = txtUsername.Text;
                    this.Hide();
                    frmMenu menuForm = new frmMenu(username);
                    menuForm.Closed += (s, args) => this.Close();
                    menuForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ERROR: Please enter the correct user name and password", "Invalid Input", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                }

            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
