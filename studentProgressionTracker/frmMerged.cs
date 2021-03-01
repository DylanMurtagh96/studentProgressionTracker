using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentProgressionTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source =..\..\..\courseModuleDB.accdb");
            SqlDataAdapter da = new SqlDataAdapter("Select * from tasksTbl", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "as");
            da = new SqlDataAdapter("Select * from courseModules", conn);
            da.Fill(ds, "cm");
            moduleTasksDgv.DataSource = ds.Tables["as"];
            //moduleTasksDgv.DataBindings();
            moduleTasksDgv.DataSource = ds.Tables["cm"];


        }
    }
}
