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
    public partial class Company_Applicants_Report : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        int[] companies_ID = new int[1000];
        CrystalReport1 CR;

        public Company_Applicants_Report()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, companies_ID[comboCompanies.SelectedIndex]);
            crystalReportViewer1.ReportSource = CR;
        }

        private void Company_Applicants_Report_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();

            conn = new OracleConnection(ordb);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Companies";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            int b = 0;
            while (dr.Read())
            {
                companies_ID[b] = Convert.ToInt32(dr[0]);
                comboCompanies.Items.Add(dr[1]);
                ++b;
            }
            dr.Close();
        }
    }
}
