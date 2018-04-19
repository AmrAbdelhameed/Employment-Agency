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
using CrystalDecisions.Shared;

namespace EmployementAgencyProject
{
    public partial class Job_Applicants_Report : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        CrystalReport2 CR;

        public Job_Applicants_Report()
        {
            InitializeComponent();
        }

        private void Job_Applicants_Report_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();

            conn = new OracleConnection(ordb);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Jobs";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboJobs.Items.Add(dr[1]);
            }
            dr.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboJobs.Text.ToString());
            crystalReportViewer2.ReportSource = CR;
        }
    }
}
