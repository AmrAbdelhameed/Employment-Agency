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
    public partial class UpdateCompany : Form
    {
        int id;
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        int r;

        public UpdateCompany()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Companies set Company_Name = :Company_Name, Company_Email = :Company_Email, Company_City = :Company_City, Company_Street = :Company_Street, Company_State = :Company_State where Company_id = :Company_id";
            cmd.Parameters.Add("Company_Name", txtName.Text);
            cmd.Parameters.Add("Company_Email", txtEmail.Text);
            cmd.Parameters.Add("Company_City", txtCity.Text);
            cmd.Parameters.Add("Company_Street", txtStreet.Text);
            cmd.Parameters.Add("Company_State", txtState.Text);
            cmd.Parameters.Add("Company_id", id);
            r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Updated Successfully");
                this.Close();
            }
        }

        private void UpdateCompany_Load(object sender, EventArgs e)
        {
            id = ControlID.ID;

            conn = new OracleConnection(ordb);
            conn.Open();
            
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Companies where Company_id=:Company_idp";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Company_idp", id);

           OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtEmail.Text = dr[2].ToString();
                txtCity.Text = dr[3].ToString();
                txtStreet.Text = dr[4].ToString();
                txtState.Text = dr[5].ToString();
            }
        }
    }
}
