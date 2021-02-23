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
    public partial class frmStudentInfo : Form
    {
        OleDbConnection conn;
        OleDbCommand studentCommand;
        OleDbDataAdapter studentAdapter;
        DataTable studentTable;
        String username;

        public frmStudentInfo(String un)
        {
            username = un;
            InitializeComponent();
        }

        private void picboxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menuForm = new frmMenu(username);
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
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
            txtStudentName.DataBindings.Add("Text", studentTable, "studentName");
            txtStudentID.DataBindings.Add("Text", studentTable, "studentID");
            txtCurrentCourse.DataBindings.Add("Text", studentTable, "courseID");
            txtStartDate.DataBindings.Add("Text", studentTable, "startDate");
            txtProgress.DataBindings.Add("Text", studentTable, "currentProgress");
        }
    }
}
