using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployementAgencyProject
{
    public partial class EmploymentAgency_Start : Form
    {
        public EmploymentAgency_Start()
        {
            InitializeComponent();
        }

        private void fieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Add_Field f = new Admin_Add_Field();
            f.Show();
        }

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Add_Job f = new Admin_Add_Job();
            f.Show();
        }

        private void companyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin_Add_Company f = new Admin_Add_Company();
            f.Show();
        }

        private void fieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFields f = new ShowFields();
            f.Show();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowJobs f = new ShowJobs();
            f.Show();
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCompanies f = new ShowCompanies();
            f.Show();
        }

        private void EmploymentAgency_Start_Load(object sender, EventArgs e)
        {

        }

        private void showAllApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Companies_Applicants f = new Companies_Applicants();
            f.Show();
        }

        private void showAllJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Applicants_Jobs f = new Applicants_Jobs();
            f.Show();
        }

        private void applicantsAppliedForEachCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_Applicants_Report f = new Company_Applicants_Report();
            f.Show();
        }

        private void applicantsAppliedForEachJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Job_Applicants_Report f = new Job_Applicants_Report();
            f.Show();
        }

        private void applicantsAppliedForEachFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Field_Applicants_Report f = new Field_Applicants_Report();
            f.Show();
        }
    }
}
