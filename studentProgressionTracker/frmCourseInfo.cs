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
    public partial class frmCourseInfo : Form
    {
        OleDbConnection conn;
        OleDbCommand courseCommand;
        OleDbDataAdapter courseAdapter;
        DataTable courseTable;
        CurrencyManager courseManager;
        OleDbCommandBuilder courseCommBuilder;

        public frmCourseInfo()
        {
            InitializeComponent();
        }

        private void frmCourseInfo_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
                            @"Data Source = ..\..\..\courseModuleDB.accdb;";
            

            conn = new OleDbConnection(connString);
            conn.Open();
           
            //create command object and pass SQL command and connection object 
            courseCommand = new OleDbCommand("Select * from course", conn);
            //create a data table
            courseAdapter = new OleDbDataAdapter();
            courseAdapter.SelectCommand = courseCommand;
            //create table
            courseTable = new DataTable();
            //fill the data table witht the info returned from the query using the data adapter
            courseAdapter.Fill(courseTable);

            //dataBinding
            txtCourseName.DataBindings.Add("Text", courseTable, "courseName");
            txtID.DataBindings.Add("Text", courseTable, "courseID");
            txtTutor.DataBindings.Add("Text", courseTable, "tutor");
            txtAddress.DataBindings.Add("Text", courseTable, "address");
           
            
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
