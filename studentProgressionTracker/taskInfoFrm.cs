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
    public partial class taskInfoFrm : Form
    {
        OleDbConnection conn;
        OleDbCommand taskCommand;
        OleDbDataAdapter taskAdapter;
        DataTable taskTable;
        CurrencyManager taskManager;
        OleDbCommandBuilder taskCommBuilder;

        bool dbError = false;
        //String username;
        String searchTask;
        String ModuleTitle;

        public taskInfoFrm(String ModTitle, String taskID)
        {
            //username = un;
            searchTask = taskID;
            ModuleTitle = ModTitle;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void taskInfoFrm_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\courseModuleDB.accdb;";
            //+ @" Jet OLEDB:Database Password = killester";

            conn = new OleDbConnection(connString);
            conn.Open();

            //recordTrackerTbx.Text = conn.State.ToString();

            //create command object and pass SQL command and connection object 
            String cmdTxt = $"Select * from assignmentsTbl Where assignmentsTbl.taskID = '{searchTask}'";
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
            moduleNameTbx.Text = ModuleTitle;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (!dbError)
            {
                conn.Close();
                conn.Dispose();
                taskTable.Dispose();
                taskCommand.Dispose();
                taskAdapter.Dispose();
                //taskDataSet.Dispose();
            }
            this.Close();
           
        }
    }
}
