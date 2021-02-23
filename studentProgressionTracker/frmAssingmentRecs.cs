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
//using System.Data.SqlClient;

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
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\courseModuleDB.accdb;";
            //+ @" Jet OLEDB:Database Password = killester";

            conn = new OleDbConnection(connString);
            conn.Open();
                   
            recordTrackerTbx.Text = conn.State.ToString();

            //create command object and pass SQL command and connection object 
            String cmdTxt = "Select * from assignmentsTbl Where assignmentsTbl.moduleID = 'M02'";
            taskCommand = new OleDbCommand(cmdTxt, conn);
            taskAdapter = new OleDbDataAdapter();
            taskAdapter.SelectCommand = taskCommand;
            taskTable = new DataTable();
            taskAdapter.Fill(taskTable);
            
            ////dataBinding
            taskIDTbx.DataBindings.Add("Text", taskTable, "taskID");
            courseIDTbx.DataBindings.Add("Text", taskTable, "courseID");
            moduleIDTbx.DataBindings.Add("Text", taskTable, "moduleID");
            ////weekBeginningTbx.DataBindings.Add("Text", moduleTable, "weekBeginning");
            ////durationTbx.DataBindings.Add("Text", moduleTable, "moduleDuration");
            taskNameTbx.DataBindings.Add("Text", taskTable, "taskName");
            taskValueTbx.DataBindings.Add("Text", taskTable, "taskValue");
            taskOutlineTbx.DataBindings.Add("Text", taskTable, "taskOutline");

            ////dateRegisteredTbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", carTable, "DateRegistered", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd/MM/yyyy"));
            ////rentalPerDayTbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", carTable, "RentalPerDay", true, DataSourceUpdateMode.OnPropertyChanged, null, "c2"));
            ////availableCbx.DataBindings.Add("CheckState", carTable, "Available", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Unchecked);

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

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.EndCurrentEdit();
                //create and use a command builder to generate the sql statement needed by the data adapter to update the database
                taskCommBuilder = new OleDbCommandBuilder(taskAdapter);
                //the data adapter update method updates values in the database
                taskAdapter.Update(taskTable);
                recordCount();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.AddNew();
                MessageBox.Show("Populate the text boxes and Click the Save button when you have finished entering the data",
                      "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //user will get new blank slot to populate and then can save new record by pressing save

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult response;
            //the yes and no buttons return a dialog response
            response = MessageBox.Show("Are you sure you wish to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //if no is clicked do nothing i.e. dont delete
            if (response == DialogResult.No)
            {
                return;
            }
            try
            {
                taskManager.RemoveAt(taskManager.Position);
                taskCommBuilder = new OleDbCommandBuilder(taskAdapter);
                taskAdapter.Update(taskTable);
                MessageBox.Show("Record has been deleted", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recordCount();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deleting record", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            taskManager.CancelCurrentEdit();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (!dbError)
            {
                conn.Close();
                conn.Dispose();
                taskCommand.Dispose();
                taskAdapter.Dispose();
                taskTable.Dispose();
            }
            this.Close();
            this.Hide();
            frmMenu menuForm = new frmMenu();
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }

        private void picboxHome_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            mergedFrm mergedFrm = new mergedFrm();
            mergedFrm.Closed += (s, args) => this.Close();
            mergedFrm.ShowDialog();
        }
    }
}
