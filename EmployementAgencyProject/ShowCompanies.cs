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
    public partial class ShowCompanies : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        DataGridViewButtonColumn btn1, btn2;

        public ShowCompanies()
        {
            InitializeComponent();
        }

        private void ShowCompanies_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Companies";
            cmd.CommandType = CommandType.Text;

            DataTable tbl_Cat = new DataTable();
            tbl_Cat.Columns.Add("Company_id");
            tbl_Cat.Columns.Add("Company_Name");
            tbl_Cat.Columns.Add("Company_Email");
            tbl_Cat.Columns.Add("Company_City");
            tbl_Cat.Columns.Add("Company_Street");
            tbl_Cat.Columns.Add("Company_State");
            tbl_Cat.Columns.Add("Company_Phone1");
            tbl_Cat.Columns.Add("Company_Phone2");
            DataRow row;
            
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                row = tbl_Cat.NewRow();
                row["Company_id"] = dr["Company_id"];

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select Companies_PhoneID,Companies_PhoneNumber from Companies_Phone where Company_id=:Company_id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("Company_id", dr["Company_id"].ToString());

                OracleDataReader dr2 = cmd.ExecuteReader();
                int o = 0;
                while (dr2.Read())
                {
                    if (o == 1)
                        row["Company_Phone2"] = dr2["Companies_PhoneNumber"];
                    else
                        row["Company_Phone1"] = dr2["Companies_PhoneNumber"];
                    o = 1;
                }
                dr2.Close();

                row["Company_Name"] = dr["Company_Name"];
                row["Company_Email"] = dr["Company_Email"];
                row["Company_City"] = dr["Company_City"];
                row["Company_Street"] = dr["Company_Street"];
                row["Company_State"] = dr["Company_State"];
                tbl_Cat.Rows.Add(row);
            }

            dr.Close();
            dataGridViewCompanies.DataSource = tbl_Cat;

            btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Button Update";
            btn1.Name = "Update";
            btn1.Text = "Update";
            btn1.UseColumnTextForButtonValue = true;
            dataGridViewCompanies.Columns.Add(btn1);

            btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Button Delete";
            btn2.Name = "Delete";
            btn2.Text = "Delete";
            btn2.UseColumnTextForButtonValue = true;
            dataGridViewCompanies.Columns.Add(btn2);
        }

        private void dataGridViewCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewCompanies.Rows[rowIndex];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                ControlID.ID = id;
                UpdateCompany f = new UpdateCompany();
                f.Show();
            }
            else if (e.ColumnIndex == 9)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewCompanies.Rows[rowIndex];
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM Companies where Company_id=:Company_idp";
                cmd.Parameters.Add("Company_idp", id);
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Deleted Successfully");

                    dataGridViewCompanies.Columns.Remove(btn1);
                    dataGridViewCompanies.Columns.Remove(btn2);

                    ShowCompanies_Load(sender, e);
                }
            }
        }
    }
}
