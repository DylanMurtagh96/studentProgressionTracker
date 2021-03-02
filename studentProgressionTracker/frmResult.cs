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
    public partial class frmResult : Form
    {
        String username;

        OleDbConnection conn;
        OleDbCommand moduleCommand;
        OleDbDataAdapter moduleAdapter;
        DataTable moduleTable;
        CurrencyManager moduleManager;
        OleDbCommandBuilder moduleCommBuilder;

        public frmResult(String un)
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
            
       
            moduleCommand = new OleDbCommand($"Select * from {username}_Results", conn);
         
            moduleAdapter = new OleDbDataAdapter();
            moduleAdapter.SelectCommand = moduleCommand;
           
            moduleTable = new DataTable();
            
            moduleAdapter.Fill(moduleTable);

            //dataBinding
            txtModuleID.DataBindings.Add("Text", moduleTable, "moduleTitle");
            txtResult.DataBindings.Add("Text", moduleTable, "result");
           
          

            moduleManager = (CurrencyManager)BindingContext[moduleTable];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (moduleManager.Position != 0)
            {
                moduleManager.Position--;
            }
            else
            {
                MessageBox.Show("You are at the first record", "First Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (moduleManager.Position != moduleManager.Count - 1)
            {
                moduleManager.Position++;
            }
            else
            {
                MessageBox.Show("You are at the last record", "Last Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                moduleManager.EndCurrentEdit();
                moduleCommBuilder = new OleDbCommandBuilder(moduleAdapter);
                moduleAdapter.Update(moduleTable);
                MessageBox.Show("You have successfully updated your results", "Results updated", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picboxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menuForm = new frmMenu(username);
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }

        private void btnAllResults_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResultsDGV menuForm = new frmResultsDGV(username);
            menuForm.Closed += (s, args) => this.Close();
            menuForm.ShowDialog();
        }
    }
}
