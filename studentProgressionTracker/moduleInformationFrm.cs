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
    public partial class moduleInformationFrm : Form
    {
        OleDbConnection conn;
        OleDbCommand moduleCommand;
        OleDbDataAdapter moduleAdapter;
        DataTable moduleTable;
        CurrencyManager moduleManager;
        OleDbCommandBuilder moduleCommBuilder;

        bool dbError = false;
        String username;

        //OleDbConnection conn;
        OleDbCommand resultsCommand;
        OleDbDataAdapter resultsAdapter;
        //DataSet resultsDataSet;
        DataSet resultsDataSet = new DataSet();
        //DataTable taskTable;
        //CurrencyManager taskManager;
        //OleDbCommandBuilder taskCommBuilder;
        //String username;
        //String modId;
        //OleDbCommand searchCommand;
        //OleDbDataAdapter searchAdapter;
        //DataTable searchTable;

        //bool dbError = false;

        public moduleInformationFrm(String un)
        {
            username = un;
            InitializeComponent();
        }
        ////This code is run each time the application is opened it connects to the database and
        //binds the data to the text boxes
        private void moduleInformationFrm_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
                            @"Data Source = ..\..\..\courseModuleDB.accdb;";
            //+ @" Jet OLEDB:Database Password = killester";

            conn = new OleDbConnection(connString);
            conn.Open();
            recordTrackerTbx.Text = conn.State.ToString();

            //create command object and pass SQL command and connection object 
            moduleCommand = new OleDbCommand("Select * from courseModules", conn);
            //create a data table
            moduleAdapter = new OleDbDataAdapter();
            moduleAdapter.SelectCommand = moduleCommand;
            //create table
            moduleTable = new DataTable();
            //fill the data table witht the info returned from the query using the data adapter
            moduleAdapter.Fill(moduleTable);

            //dataBinding
            moduleIDTbx.DataBindings.Add("Text", moduleTable, "moduleID");
            courseIDTbx.DataBindings.Add("Text", moduleTable, "courseID");
            weekBeginningTbx.DataBindings.Add("Text", moduleTable, "weekBeginning");
            durationTbx.DataBindings.Add("Text", moduleTable, "moduleDuration");
            moduleTitleTbx.DataBindings.Add("Text", moduleTable, "moduleTitle");
            NFQLvlTbx.DataBindings.Add("Text", moduleTable, "NFQLvl");
            awardByTbx.DataBindings.Add("Text", moduleTable, "awardBy");
            semesterTbx.DataBindings.Add("Text", moduleTable, "semester");
            moduleOutlineTbx.DataBindings.Add("Text", moduleTable, "moduleOutline");

            //dateRegisteredTbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", carTable, "DateRegistered", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd/MM/yyyy"));
            //rentalPerDayTbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", carTable, "RentalPerDay", true, DataSourceUpdateMode.OnPropertyChanged, null, "c2"));
            //availableCbx.DataBindings.Add("CheckState", carTable, "Available", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Unchecked);

            moduleManager = (CurrencyManager)BindingContext[moduleTable];
            //recordCount();

            //var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" +
            // @"Data Source = ..\..\..\courseModuleDB.accdb;";

            //conn = new OleDbConnection(connString);
            //conn.Open();


            //moduleCommand = new OleDbCommand($"Select * from {username}_Results", conn);
            resultsGbx.Text = $"Results for {username} in the above module is";
            String cmdTxt = $"Select * from {username}_Results";
            resultsAdapter = new OleDbDataAdapter();
            resultsCommand = new OleDbCommand(cmdTxt, conn);
            
            resultsAdapter.SelectCommand = resultsCommand;
            resultsAdapter.Fill(resultsDataSet, "results");
            //DataRow[] record = resultsDataSet.Tables[0].Select("ModuleID = " + moduleIDTbx.Text);
            //moduleResultTbx.DataBindings.Add("Text", resultsDataSet.Tables[0], "result");
            //moduleIDTbx.DataBindings.Add("Text", taskDataSet.Tables[0], "moduleID");
            //moduleNameTbx.DataBindings.Add("Text", taskDataSet.Tables[0], "moduleTitle");
            //moduleOutlineTbx.DataBindings.Add("Text", taskDataSet.Tables[0], "moduleOutline");
            //taskManager = (CurrencyManager)BindingContext[taskDataSet.Tables[0]];
            recordCount();
        }

        //Code keeps record count updated
        private void recordCount()
        {
            recordTrackerTbx.Text = (moduleManager.Position + 1) + " of " + moduleManager.Count;
            String moduleID = moduleIDTbx.Text;
            getResult(moduleID);
            
        }

        private void getResult(String modId)
        {
            DataTable resultsTable = resultsDataSet.Tables[0];
            String expression;
            expression = $"ModuleID = '{modId}'";
            DataRow[] matchingIds;

            matchingIds = resultsTable.Select(expression);
            if (matchingIds[0][10] != null)
            {
                moduleResultTbx.Text = matchingIds[0][10].ToString();
            }
            else
            {
                moduleResultTbx.Text = "Not available";
            }

        }
        private void firstBtn_Click(object sender, EventArgs e)
        {
            if (moduleManager.Position != 0)
            {
                moduleManager.Position = 0;
                recordCount();
            }
            else
            {
                MessageBox.Show("You are already at the first record", "First Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (moduleManager.Position != moduleManager.Count - 1)
            {
                moduleManager.Position++;
                recordCount();
            }
            else
            {
                MessageBox.Show("You are at the last record", "Last Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (moduleManager.Position != 0)
            {
                moduleManager.Position--;
                recordCount();
            }
            else
            {
                MessageBox.Show("You are at the first record", "First Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            if (moduleManager.Position != moduleManager.Count - 1)
            {
                moduleManager.Position = moduleManager.Count - 1;
                recordCount();
            }
            else
            {
                MessageBox.Show("You are already at the last record", "Last Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                moduleManager.EndCurrentEdit();
                //create and use a command builder to generate the sql statement needed by the data adapter to update the database
                moduleCommBuilder = new OleDbCommandBuilder(moduleAdapter);
                //the data adapter update method updates values in the database
                moduleAdapter.Update(moduleTable);
                recordCount();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                moduleManager.RemoveAt(moduleManager.Position);
                moduleCommBuilder = new OleDbCommandBuilder(moduleAdapter);
                moduleAdapter.Update(moduleTable);
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
            moduleManager.CancelCurrentEdit();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (!dbError)
            {
                conn.Close();
                conn.Dispose();
                moduleCommand.Dispose();
                moduleAdapter.Dispose();
                moduleTable.Dispose();
            }
            this.Close();
            this.Hide();
            frmMenu menuForm = new frmMenu(username);
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }

        private void courseTitleLbl_Click(object sender, EventArgs e)
        {

        }

        private void picboxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menuForm = new frmMenu(username);
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }

        private void taskBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            moduleTaskInfoFrm ModuleTaskForm = new moduleTaskInfoFrm(username, moduleIDTbx.Text);
            //ModuleTaskForm.Closed += (s, args) => this.Close();
            ModuleTaskForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                moduleManager.AddNew();
                MessageBox.Show("Populate the text boxes and Click the Save button when you have finished entering the data",
                      "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //user will get new blank slot to populate and then can save new record by pressing save

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void moduleStartTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultsGbx_Enter(object sender, EventArgs e)
        {

        }
    }

    
}
