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
    public partial class frmMenu : Form
    {
        OleDbConnection conn;
        OleDbCommand studentCommand;
        OleDbDataAdapter studentAdapter;
        DataTable studentTable;
        String username;

        public frmMenu(String un)
        {
            username = un;
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
                          @"Data Source = ..\..\..\courseModuleDB.accdb;";


            conn = new OleDbConnection(connString);
            conn.Open();

            //create command object and pass SQL command and connection object 
            studentCommand = new OleDbCommand("Select * from student where studentID='" + username + "'", conn);
            //create a data table
            studentAdapter = new OleDbDataAdapter();
            studentAdapter.SelectCommand = studentCommand;
            //create table
            studentTable = new DataTable();
            //fill the data table witht the info returned from the query using the data adapter
            studentAdapter.Fill(studentTable);

            //dataBinding
            txtName.DataBindings.Add("Text", studentTable, "studentName");
            String name = txtName.Text;
            var names = name.Split(' ');
            lblWelcome.Text = ("Welcome, "  + names[0]);
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
            this.Hide();
            moduleInformationFrm moduleForm = new moduleInformationFrm(username);
            //moduleForm.Closed += (s, args) => this.Close();
            //moduleForm.ShowDialog();

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
