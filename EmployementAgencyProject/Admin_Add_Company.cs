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
    public partial class Admin_Add_Company : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        int r;
        int i = 0, i2 = 0;

        public Admin_Add_Company()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Companies values (:Company_id,:Company_Name,:Company_Email,:Company_City,:Company_Street,:Company_State)";
            cmd.Parameters.Add("Company_id", i);
            cmd.Parameters.Add("Company_Name", txtName.Text);
            cmd.Parameters.Add("Company_Email", txtEmail.Text);
            cmd.Parameters.Add("Company_City", txtCity.Text);
            cmd.Parameters.Add("Company_Street", txtStreet.Text);
            cmd.Parameters.Add("Company_State", txtState.Text);
            r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Companies_Phone values (:Companies_PhoneID,:Companies_PhoneNumber,:Company_id)";
                cmd.Parameters.Add("Companies_PhoneID", i2);
                cmd.Parameters.Add("Companies_PhoneNumber", txtPhone1.Text);
                cmd.Parameters.Add("Company_id", i);
                r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    ++i2;
                    if (txtPhone2.Text.Length != 0)
                    {
                        cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into Companies_Phone values (:Companies_PhoneID,:Companies_PhoneNumber,:Company_id)";
                        cmd.Parameters.Add("Companies_PhoneID", i2);
                        cmd.Parameters.Add("Companies_PhoneNumber", txtPhone2.Text);
                        cmd.Parameters.Add("Company_id", i);
                        r = cmd.ExecuteNonQuery();

                        if (r != -1)
                        {
                            ++i2;
                            MessageBox.Show("New Company is Added");
                        }
                    }
                    else
                    {
                        MessageBox.Show("New Company is Added");
                    }
                }
                ++i;
            }
        }

        private void Admin_Add_Company_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select max(Company_id) from Companies";
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
            cmd.CommandText = "select max(Companies_PhoneID) from Companies_Phone";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd.ExecuteReader();
            if (dr2.Read())
            {
                if (dr2[0].ToString().Equals(""))
                    i2 = 0;
                else
                    i2 = Convert.ToInt32(dr2[0]);
                ++i2;
            }

            dr2.Close();
        }
    }
}
