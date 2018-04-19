using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace EmployementAgencyProject
{
    public partial class ShowFields : Form
    {
        string constr = "data source=orcl; user id=hr; password=hr;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public ShowFields()
        {
            InitializeComponent();
        }

        private void ShowFields_Load(object sender, EventArgs e)
        {
            string cmdstr = "select * from Fields";

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewFields.DataSource = ds.Tables[0];
        }

        private void dataGridViewFields_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Successfully Updated");
        }
    }
}
