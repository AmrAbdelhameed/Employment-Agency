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
    public partial class Admin_Add_Field : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        OracleCommand cmd;
        int i = 0;

        public Admin_Add_Field()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Fields values (:Field_IDp,:Field_Namep)";
            cmd.Parameters.Add("Field_IDp", i);
            cmd.Parameters.Add("Field_Namep", txtFieldName.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Field is Added");
            ++i;
        }

        private void Admin_Add_Field_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select max(Field_ID) from Fields";
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
        }
    }
}
