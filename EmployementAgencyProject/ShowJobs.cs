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
    public partial class ShowJobs : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        DataGridViewButtonColumn btn1, btn2;

        public ShowJobs()
        {
            InitializeComponent();
        }

        private void ShowJobs_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetAllJobs";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("job", OracleDbType.RefCursor, ParameterDirection.Output);

            DataTable tbl_Cat = new DataTable();
            tbl_Cat.Columns.Add("Job_id");
            tbl_Cat.Columns.Add("Job_Title");
            tbl_Cat.Columns.Add("Job_Salary");
            tbl_Cat.Columns.Add("Job_Description");
            tbl_Cat.Columns.Add("Job_Year_of_Experience");
            DataRow row;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                row = tbl_Cat.NewRow();
                row["Job_id"] = dr["Job_id"];
                row["Job_Title"] = dr["Job_Title"];
                row["Job_Salary"] = dr["Job_Salary"];
                row["Job_Description"] = dr["Job_Description"];
                row["Job_Year_of_Experience"] = dr["Job_Year_of_Experience"];
                tbl_Cat.Rows.Add(row);
            }

            dr.Close();
            dataGridViewJobs.DataSource = tbl_Cat;

            btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Button Update";
            btn1.Name = "Update";
            btn1.Text = "Update";
            btn1.UseColumnTextForButtonValue = true;
            dataGridViewJobs.Columns.Add(btn1);

            btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Button Delete";
            btn2.Name = "Delete";
            btn2.Text = "Delete";
            btn2.UseColumnTextForButtonValue = true;
            dataGridViewJobs.Columns.Add(btn2);
        }

        private void dataGridViewJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewJobs.Rows[rowIndex];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string jobName = row.Cells[1].Value.ToString();
                string jobDes = row.Cells[3].Value.ToString();
                ControlID.ID = id;
                ControlID.str1 = jobName;
                ControlID.str2 = jobDes;
                UpdateJobs f = new UpdateJobs();
                f.Show();
            }
            else if (e.ColumnIndex == 6)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewJobs.Rows[rowIndex];
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete_Job";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Job_idp", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");

                dataGridViewJobs.Columns.Remove(btn1);
                dataGridViewJobs.Columns.Remove(btn2);

                ShowJobs_Load(sender, e);
            }
        }
    }
}
