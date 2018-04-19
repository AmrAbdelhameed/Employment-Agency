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
    public partial class Applicants_Jobs : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        int[] fields_ID = new int[1000];
        int[] companies_ID = new int[1000];
        OracleDataAdapter adapter;
        DataSet ds;
        string cmdstr;
        DataGridViewButtonColumn btn;

        public Applicants_Jobs()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int field_id = comboFields.SelectedIndex;
            int company_id = comboCompanies.SelectedIndex;

            dataGridViewJobs.DataSource = null;
            dataGridViewJobs.Columns.Remove(btn);

            if (field_id != -1 && company_id != -1)
            {
                cmdstr = "select * from Jobs where ApplicantField_ID = :ApplicantField_IDp and ApplicantCompany_ID = :ApplicantCompany_IDp";
                adapter = new OracleDataAdapter(cmdstr, ordb);
                adapter.SelectCommand.Parameters.Add("ApplicantField_IDp", fields_ID[field_id]);
                adapter.SelectCommand.Parameters.Add("ApplicantCompany_IDp", companies_ID[company_id]);
            }
            else if (field_id == -1 && company_id != -1)
            {
                cmdstr = "select * from Jobs where ApplicantCompany_ID = :ApplicantCompany_IDp";
                adapter = new OracleDataAdapter(cmdstr, ordb);
                adapter.SelectCommand.Parameters.Add("ApplicantCompany_IDp", companies_ID[company_id]);
            }
            else if (field_id != -1 && company_id == -1)
            {
                cmdstr = "select * from Jobs where ApplicantField_ID = :ApplicantField_IDp";
                adapter = new OracleDataAdapter(cmdstr, ordb);
                adapter.SelectCommand.Parameters.Add("ApplicantField_IDp", fields_ID[field_id]);
            }
            else
            {
                cmdstr = "select * from Jobs";
                adapter = new OracleDataAdapter(cmdstr, ordb);
            }

            ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewJobs.DataSource = ds.Tables[0];

            btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Button Apply";
            btn.Name = "Apply";
            btn.Text = "Apply";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewJobs.Columns.Add(btn);
        }

        private void Applicants_Jobs_Load(object sender, EventArgs e)
        {
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

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Fields";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr2 = cmd.ExecuteReader();
            b = 0;
            while (dr2.Read())
            {
                fields_ID[b] = Convert.ToInt32(dr2[0]);
                comboFields.Items.Add(dr2[1]);
                ++b;
            }
            dr2.Close();

            cmdstr = "select * from Jobs";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewJobs.DataSource = ds.Tables[0];

            btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Button Apply";
            btn.Name = "Apply";
            btn.Text = "Apply";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewJobs.Columns.Add(btn);
        }

        private void dataGridViewJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewJobs.Rows[rowIndex];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                int id2 = Int32.Parse(row.Cells[5].Value.ToString());
                int id3 = Int32.Parse(row.Cells[6].Value.ToString());
                ControlID.ID = id;
                ControlID.ID2 = id2;
                ControlID.ID3 = id3;
                Applicants_Apply f = new Applicants_Apply();
                f.Show();
            }
        }
    }
}
