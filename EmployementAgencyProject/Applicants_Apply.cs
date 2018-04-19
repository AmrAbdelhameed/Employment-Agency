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
    public partial class Applicants_Apply : Form
    {
        int i = 0, job_id, field_id, company_id;
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;

        public Applicants_Apply()
        {
            InitializeComponent();
        }

        private void Applicants_Apply_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            job_id = ControlID.ID;
            field_id = ControlID.ID2;
            company_id = ControlID.ID3;

            comboBoxSex.Items.Add("Male");
            comboBoxSex.Items.Add("Female");

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(Applicants_PhoneID) from Applicants_Phone";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd.ExecuteReader();
            if (dr2.Read())
            {
                i = Convert.ToInt32(dr2[0]);
                ++i;
            }

            dr2.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"insert into Applicants values 
                (:Applicant_SSN,:Applicant_Name,:Applicant_Email,:Applicant_sex,
                    :Applicant_City,:Applicant_Street,
                    :Applicant_State,:Applicant_Education,:Applicant_Overview,:Applicant_Experience,
                    :Applicant_Skills,:ApplicantJob_ID,:ApplicantField_ID,:ApplicantCompany_ID)";

            cmd.Parameters.Add("Applicant_SSN", txtSSN.Text);
            cmd.Parameters.Add("Applicant_Name", txtName.Text);
            cmd.Parameters.Add("Applicant_Email", txtEmail.Text);
            cmd.Parameters.Add("Applicant_sex", comboBoxSex.Text);
            cmd.Parameters.Add("Applicant_City", txtCity.Text);
            cmd.Parameters.Add("Applicant_Street", txtStreet.Text);
            cmd.Parameters.Add("Applicant_State", txtState.Text);
            cmd.Parameters.Add("Applicant_Education", txtEducation.Text);
            cmd.Parameters.Add("Applicant_Overview", txtOverview.Text);
            cmd.Parameters.Add("Applicant_Experience", txtExperience.Text);
            cmd.Parameters.Add("Applicant_Skills", txtSkills.Text);
            cmd.Parameters.Add("ApplicantJob_ID", job_id);
            cmd.Parameters.Add("ApplicantField_ID", field_id);
            cmd.Parameters.Add("ApplicantCompany_ID", company_id);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Applicants_Phone values (:Applicants_PhoneID,:Applicants_PhoneNumber,:Applicant_SSN)";
                cmd.Parameters.Add("Applicants_PhoneID", i);
                cmd.Parameters.Add("Applicants_PhoneNumber", txtPhone1.Text);
                cmd.Parameters.Add("Applicant_SSN", txtSSN.Text);
                r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    ++i;
                    if (txtPhone2.Text.Length != 0)
                    {
                        cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into Applicants_Phone values (:Applicants_PhoneID,:Applicants_PhoneNumber,:Applicant_SSN)";
                        cmd.Parameters.Add("Applicants_PhoneID", i);
                        cmd.Parameters.Add("Applicants_PhoneNumber", txtPhone2.Text);
                        cmd.Parameters.Add("Applicant_SSN", txtSSN.Text);
                        r = cmd.ExecuteNonQuery();

                        if (r != -1)
                        {
                            ++i;
                            MessageBox.Show("Applied Successfully");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Applied Successfully");
                        this.Close();
                    }
                }
            }
        }
    }
}
