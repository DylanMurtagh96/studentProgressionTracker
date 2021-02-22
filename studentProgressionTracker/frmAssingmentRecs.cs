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
    public partial class frmAssingmentRecs : Form
    {
        OleDbConnection conn;
        OleDbCommand taskCommand;
        OleDbDataAdapter taskAdapter;
        DataTable taskTable;
        CurrencyManager taskManager;
        OleDbCommandBuilder taskCommBuilder;

        bool dbError = false;

        public frmAssingmentRecs()
        {
            InitializeComponent();
        }

        ///This code is run each time the application is opened it connects to the database and
        //binds the data to the text boxes
        private void frmAssingmentRecs_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
                            @"Data Source = ..\..\..\courseModuleDB.accdb;";
            //+ @" Jet OLEDB:Database Password = killester";

            conn = new OleDbConnection(connString);
            conn.Open();
            recordTrackerTbx.Text = conn.State.ToString();

            //create command object and pass SQL command and connection object 
            taskCommand = new OleDbCommand("Select * from assignmentsTbl", conn);
            //create a data table
            taskAdapter = new OleDbDataAdapter();
            taskAdapter.SelectCommand = taskCommand;
            //create table
            taskTable = new DataTable();
            //fill the data table witht the info returned from the query using the data adapter
            taskAdapter.Fill(taskTable);

            //dataBinding
            taskIDTbx.DataBindings.Add("Text", taskTable, "taskID");
            courseIDTbx.DataBindings.Add("Text", taskTable, "courseID");
            moduleIDTbx.DataBindings.Add("Text", taskTable, "moduleID");
            //weekBeginningTbx.DataBindings.Add("Text", moduleTable, "weekBeginning");
            //durationTbx.DataBindings.Add("Text", moduleTable, "moduleDuration");
            taskNameTbx.DataBindings.Add("Text", taskTable, "taskName");
            taskValueTbx.DataBindings.Add("Text", taskTable, "taskValue");
            taskOutlineTbx.DataBindings.Add("Text", taskTable, "taskOutline");

            //dateRegisteredTbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", carTable, "DateRegistered", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd/MM/yyyy"));
            //rentalPerDayTbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", carTable, "RentalPerDay", true, DataSourceUpdateMode.OnPropertyChanged, null, "c2"));
            //availableCbx.DataBindings.Add("CheckState", carTable, "Available", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Unchecked);

            taskManager = (CurrencyManager)BindingContext[taskTable];
            recordCount();
        }

        //Code keeps record count updated
        private void recordCount()
        {
            recordTrackerTbx.Text = (taskManager.Position + 1) + " of " + taskManager.Count;
        }

        private void firstBtn_Click_1(object sender, EventArgs e)
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

        private void previousBtn_Click_1(object sender, EventArgs e)
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

        private void nextBtn_Click_1(object sender, EventArgs e)
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

        private void lastBtn_Click_1(object sender, EventArgs e)
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
    }
}
