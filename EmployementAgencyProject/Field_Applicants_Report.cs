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
    public partial class Field_Applicants_Report : Form
    {
        CrystalReport3 CR;

        public Field_Applicants_Report()
        {
            InitializeComponent();
        }
        
        private void Field_Applicants_Report_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport3();
            crystalReportViewer3.ReportSource = CR;         
        }
    }
}
