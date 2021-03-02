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
    public partial class frmResultsDGV : Form
    {
        String username;
        OleDbConnection conn;
        OleDbCommand searchCommand;
        OleDbDataAdapter searchAdapter;
        DataTable searchTable;

        public frmResultsDGV(String un)
        {
            InitializeComponent();
            username = un;
        }

        private void frmResultsDGV_Load(object sender, EventArgs e)
        {
            String cmdTxt1 = $"Select moduleTitle, result from {username}_Results";
            searchCommand = new OleDbCommand(cmdTxt1, conn);
            searchAdapter = new OleDbDataAdapter();
            searchAdapter.SelectCommand = searchCommand;
            searchTable = new DataTable();
            searchAdapter.Fill(searchTable);
            dataGridView.DataSource = searchTable;
        }
    }
}
