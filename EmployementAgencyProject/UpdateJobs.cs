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
    public partial class UpdateJobs : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        int id;

        public UpdateJobs()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update_Job";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Job_idp", id);
            cmd.Parameters.Add("Job_Titlep", txtTitle.Text);
            cmd.Parameters.Add("Job_Salaryp", txtSalary.Text);
            cmd.Parameters.Add("Job_Descriptionp", txtDescription.Text);
            cmd.Parameters.Add("Job_Year_of_Experiencep", txtYExperience.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
        }

        private void UpdateJobs_Load(object sender, EventArgs e)
        {
            id = ControlID.ID;

            conn = new OracleConnection(ordb);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetJob";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("Job_idp", id);
            cmd.Parameters.Add("Job_Salaryp", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("Job_Year_of_Experiencep", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            txtTitle.Text = ControlID.str1;
            txtSalary.Text = cmd.Parameters["Job_Salaryp"].Value.ToString();
            txtDescription.Text = ControlID.str2;
            txtYExperience.Text = cmd.Parameters["Job_Year_of_Experiencep"].Value.ToString();
        }
    }
}
