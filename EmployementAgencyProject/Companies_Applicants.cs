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
    public partial class Companies_Applicants : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;

        public Companies_Applicants()
        {
            InitializeComponent();
        }

        private void Companies_Applicants_Load(object sender, EventArgs e)
        {
            string constr = "data source=orcl; user id=hr; password=hr;";
            DataSet ds= new DataSet();

            OracleDataAdapter adapter1 = new OracleDataAdapter("select Company_id, Company_Name  from Companies" , constr);
            adapter1.Fill(ds, "Comp");

            OracleDataAdapter adapte2 = new OracleDataAdapter("select * from Applicants", constr);
            adapte2.Fill(ds, "App");

            DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["Company_id"],
                                                     ds.Tables[1].Columns["ApplicantCompany_ID"]);

            ds.Relations.Add(r);

            BindingSource bs_Master = new BindingSource(ds, "Comp");
            BindingSource bs_Child = new BindingSource(bs_Master, "fk");

            dataGridViewCompanies.DataSource = bs_Master;
            dataGridViewApplicants.DataSource = bs_Child;
        }
    }
}
