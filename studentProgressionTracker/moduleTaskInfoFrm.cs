using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace studentProgressionTracker
{
    public partial class moduleTaskInfoFrm : Form
    {
        OleDbConnection conn;
        OleDbCommand taskCommand;
        OleDbDataAdapter taskAdapter;
        DataSet taskDataSet;
        //DataTable taskTable;
        CurrencyManager taskManager;
        OleDbCommandBuilder taskCommBuilder;
        String username;

        OleDbCommand searchCommand;
        OleDbDataAdapter searchAdapter;
        DataTable searchTable;

        bool dbError = false;

        public moduleTaskInfoFrm(String un)
        {
            username = un;
            InitializeComponent();
        }

        private void mergedFrm_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\courseModuleDB.accdb;";
            //+ @" Jet OLEDB:Database Password = killester";

            conn = new OleDbConnection(connString);
            conn.Open();

            recordTrackerTbx.Text = conn.State.ToString();

            //create command object and pass SQL command and connection object 
            String cmdTxt = "Select courseModules.moduleTitle, courseModules.moduleID, courseModules.moduleOutline from courseModules";
            taskAdapter = new OleDbDataAdapter();
            taskCommand = new OleDbCommand(cmdTxt, conn);
            DataSet taskDataSet = new DataSet();
            taskAdapter.SelectCommand = taskCommand;
            taskAdapter.Fill(taskDataSet, "Tables[0]");
            moduleIDTbx.DataBindings.Add("Text", taskDataSet.Tables[0], "moduleID");
            moduleNameTbx.DataBindings.Add("Text", taskDataSet.Tables[0], "moduleTitle");
            moduleOutlineTbx.DataBindings.Add("Text", taskDataSet.Tables[0], "moduleOutline");
            taskManager = (CurrencyManager)BindingContext[taskDataSet.Tables[0]];
            recordCount();
        }

        //Code keeps record count updated
        private void recordCount()
        {
            recordTrackerTbx.Text = (taskManager.Position + 1) + " of " + taskManager.Count;
            updateDgv();
        }

        private void updateDgv()
        {
            
            String modID = moduleIDTbx.Text;
            String cmdTxt1 = $"Select * from assignmentsTbl where moduleID = '{modID}'";
            searchCommand = new OleDbCommand(cmdTxt1, conn);
            searchAdapter = new OleDbDataAdapter();
            searchAdapter.SelectCommand = searchCommand;
            searchTable = new DataTable();
            searchAdapter.Fill(searchTable);
            moduleTasksDgv.DataSource = searchTable;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (!dbError)
            {
                conn.Close();
                conn.Dispose();
                searchCommand.Dispose();
                searchAdapter.Dispose();
                searchTable.Dispose();
                taskCommand.Dispose();
                taskAdapter.Dispose();
                taskDataSet.Dispose();
            }
            this.Close();
            //this.Hide();
            //frmMenu menuForm = new frmMenu(username);
            //menuForm.Closed += (s, args) => this.Close();
            //menuForm.ShowDialog();
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            if (taskManager.Position != 0)
            {
                taskManager.Position = 0;
                recordCount();
            }
            else
            {
                MessageBox.Show("You are already at the first record", "First Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (taskManager.Position != 0)
            {
                taskManager.Position--;
                recordCount();
            }
            else
            {
                MessageBox.Show("You are at the first record", "First Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (taskManager.Position != taskManager.Count - 1)
            {
                taskManager.Position++;
                recordCount();
            }
            else
            {
                MessageBox.Show("You are at the last record", "Last Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            if (taskManager.Position != taskManager.Count - 1)
            {
                taskManager.Position = taskManager.Count - 1;
                recordCount();
            }
            else
            {
                MessageBox.Show("You are already at the last record", "Last Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void moduleTasksDgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void moduleTasksDgv_CellContentDoubleClick(object sender, EventArgs e)
        {

        }

        private void moduleTasksDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String taskId = this.moduleTasksDgv.CurrentRow.Cells[0].Value.ToString();
            taskInfoFrm taskInfo = new taskInfoFrm(moduleNameTbx.Text, taskId);
            taskInfo.MdiParent = this.MdiParent;
            taskInfo.Show();
            
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
