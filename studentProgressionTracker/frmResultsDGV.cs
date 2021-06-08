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
            try //try catch to prevent form from crashing in the event of a error
            {
                var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
                           @"Data Source = ..\..\..\courseModuleDB.accdb;";
                conn = new OleDbConnection(connString);
                conn.Open();
                //This creates a connection object which which reads the connection string 
                String sql = $"Select AwardBy, NFQLvl, moduleTitle, result from {username}_Results";
                searchCommand = new OleDbCommand(sql, conn);
                searchAdapter = new OleDbDataAdapter();
                searchAdapter.SelectCommand = searchCommand;
                searchTable = new DataTable();
                searchAdapter.Fill(searchTable);
                dataGridView.DataSource = searchTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: Database could not open", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResult resultForm = new frmResult(username);
            resultForm.Closed += (s, args) => this.Close();
            resultForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menuForm = new frmMenu(username);
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }
    }
}
