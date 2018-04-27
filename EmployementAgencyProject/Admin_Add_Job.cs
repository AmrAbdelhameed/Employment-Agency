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
    public partial class Admin_Add_Job : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        int i = 0;
        int[] fields_ID = new int[1000];
        int[] companies_ID = new int[1000];

        public Admin_Add_Job()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert_Job";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Job_id", i);
            cmd.Parameters.Add("Job_Title", txtTitle.Text);
            cmd.Parameters.Add("Job_Salary", txtSalary.Text);
            cmd.Parameters.Add("Job_Description", txtDescription.Text);
            cmd.Parameters.Add("Job_Year_of_Experience", txtYExperience.Text);
            cmd.Parameters.Add("ApplicantField_ID", fields_ID[comboBoxFields.SelectedIndex]);
            cmd.Parameters.Add("ApplicantCompany_ID", companies_ID[comboBoxCompanies.SelectedIndex]);
            
            cmd.ExecuteNonQuery();

            MessageBox.Show("New Job is Added");
            ++i;
        }

        private void Admin_Add_Job_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select max(Job_id) from Jobs";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString().Equals(""))
                    i = 0;
                else
                    i = Convert.ToInt32(dr[0]);
                ++i;
            }

            dr.Close();
            
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Fields";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd.ExecuteReader();
            int b = 0;
            while (dr2.Read())
            {
                fields_ID[b] = Convert.ToInt32(dr2[0]);
                comboBoxFields.Items.Add(dr2[1]);
                ++b;
            }
            
            dr2.Close();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Companies";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr3 = cmd.ExecuteReader();
            b = 0;
            while (dr3.Read())
            {
                companies_ID[b] = Convert.ToInt32(dr3[0]);
                comboBoxCompanies.Items.Add(dr3[1]);
                ++b;
            }

            dr3.Close();
        }
    }
}
