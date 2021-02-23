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
    public partial class mergedFrm : Form
    {
        OleDbConnection conn;
        OleDbCommand taskCommand;
        OleDbDataAdapter taskAdapter;
        DataSet taskTable;
        //DataTable taskTable;
        CurrencyManager taskManager;
        OleDbCommandBuilder taskCommBuilder;

        bool dbError = false;

        public mergedFrm()
        {
            InitializeComponent();
        }

        private void mergedFrm_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\courseModuleDB.accdb;";
            //+ @" Jet OLEDB:Database Password = killester";

            conn = new OleDbConnection(connString);
            conn.Open();

            //recordTrackerTbx.Text = conn.State.ToString();

            //create command object and pass SQL command and connection object 
            String cmdTxt = "Select assignmentsTbl.moduleID, courseModules.moduleTitle from assignmentsTbl, courseModules Where assignmentsTbl.moduleID = courseModules.moduleID and courseModules.moduleID = 'M02'";
            taskAdapter = new OleDbDataAdapter();
            taskCommand = new OleDbCommand(cmdTxt, conn);
            //taskCommand = new SqlCommand(taskCommand1, conn);
            DataSet taskDataSet = new DataSet();
            taskAdapter.SelectCommand = taskCommand;
            taskAdapter.Fill(taskDataSet, "Tables[0]");
            //taskAdapter.SelectCommand.CommandText = taskCommand2;
            // taskAdapter = new OleDbDataAdapter();
            //taskAdapter.SelectCommand = taskCommand;
            //taskTable = new DataSet();
            //taskTable = new DataTable();
            //taskAdapter.Fill(taskTable);
            //taskAdapter.Dispose();
            //taskCommand.Dispose();
            //conn.Close();
            //taskDataSet.Tables[0].Merge(taskDataSet.Tables[1]);
            //taskTable = taskDataSet.Tables[0];
            //for (int i = 0; i <= taskDataSet.Tables[0].Rows.Count - 1; i++)
            //{
            //    MessageBox.Show(taskDataSet.Tables[0].Rows[i].ItemArray[0] + " -- " + taskDataSet.Tables[0].Rows[i].ItemArray[1]);
            // }
            //retrieve second table data 
            //for (int i = 0; i <= taskDataSet.Tables[1].Rows.Count - 1; i++)
            // {
            //     MessageBox.Show(taskDataSet.Tables[1].Rows[i].ItemArray[0] + " -- " + //taskDataSet.Tables[1].Rows[i].ItemArray[1]);

            // }



            ////taskCommand2 = new SqlCommand("Select * from courseModules", conn);
            ////taskCommand = new OleDbCommand("Select * from assignmentsTbl, courseModules where assignmentsTbl.moduleID = courseModules.moduleID and assignmentTbl.moduleID = 'M02'", conn);
            ////create a data table
            ////taskAdapter = new OleDbDataAdapter();
            ////taskAdapter.SelectCommand = taskCommand;
            ////create table
            ////taskTable = new DataTable();
            //taskDataSet = new DataSet();
            ////fill the data table witht the info returned from the query using the data adapter
            //taskAdapter.Fill(taskTable);

            ////dataBinding
            //taskIDTbx.DataBindings.Add("Text", taskTable.Table(0), "taskID");
            //courseIDTbx.DataBindings.Add("Text", taskTable, "courseID");
            moduleIDTbx.DataBindings.Add("Text", taskDataSet.Tables[0], "moduleID");
            moduleNameTbx.DataBindings.Add("Text", taskDataSet.Tables[0], "moduleTitle");
            ////weekBeginningTbx.DataBindings.Add("Text", moduleTable, "weekBeginning");
            ////durationTbx.DataBindings.Add("Text", moduleTable, "moduleDuration");
            //taskNameTbx.DataBindings.Add("Text", taskTable, "taskName");
            //taskValueTbx.DataBindings.Add("Text", taskTable, "taskValue");
            //taskOutlineTbx.DataBindings.Add("Text", taskTable, "taskOutline");

            ////dateRegisteredTbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", carTable, "DateRegistered", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd/MM/yyyy"));
            ////rentalPerDayTbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", carTable, "RentalPerDay", true, DataSourceUpdateMode.OnPropertyChanged, null, "c2"));
            ////availableCbx.DataBindings.Add("CheckState", carTable, "Available", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Unchecked);

            taskManager = (CurrencyManager)BindingContext[taskDataSet.Tables[0]];
            recordCount();
        }

        //Code keeps record count updated
        private void recordCount()
        {
            recordTrackerTbx.Text = (taskManager.Position + 1) + " of " + taskManager.Count;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (!dbError)
            {
                conn.Close();
                conn.Dispose();
                //moduleCommand.Dispose();
                //moduleAdapter.Dispose();
                //moduleTable.Dispose();
            }
            this.Close();
            this.Hide();
            frmMenu menuForm = new frmMenu();
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }
    }
}
