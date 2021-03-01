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

namespace resultProgressionTracker
{
    public partial class frmResult : Form
    {
        String username;
        OleDbConnection conn;
        OleDbCommand resultCommand;
        OleDbDataAdapter resultAdapter;
        DataTable resultTable;

        public frmResult(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
                           @"Data Source = ..\..\..\courseModuleDB.accdb;";


            conn = new OleDbConnection(connString);
            conn.Open();

            //create command object and pass SQL command and connection object 
            resultCommand = new OleDbCommand("Select * from results where resultID='" + username + "'", conn);
            //create a data table
            resultAdapter = new OleDbDataAdapter();
            resultAdapter.SelectCommand = resultCommand;
            //create table
            resultTable = new DataTable();
            //fill the data table witht the info returned from the query using the data adapter
            resultAdapter.Fill(resultTable);

            String cmdTxt1 = $"Select moduleID, result from results";
            resultCommand = new OleDbCommand(cmdTxt1, conn);
            resultAdapter = new OleDbDataAdapter();
            resultAdapter.SelectCommand = resultCommand;
            resultTable = new DataTable();
            resultAdapter.Fill(resultTable);
            moduleResultDGV.DataSource = resultTable;
        }
    }
}
