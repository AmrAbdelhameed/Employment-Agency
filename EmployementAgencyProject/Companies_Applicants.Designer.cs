namespace EmployementAgencyProject
{
    partial class Companies_Applicants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewApplicants = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCompanies = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewApplicants
            // 
            this.dataGridViewApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplicants.Location = new System.Drawing.Point(15, 255);
            this.dataGridViewApplicants.Name = "dataGridViewApplicants";
            this.dataGridViewApplicants.Size = new System.Drawing.Size(552, 230);
            this.dataGridViewApplicants.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select company name to show all applicants applied in it";
            // 
            // dataGridViewCompanies
            // 
            this.dataGridViewCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanies.Location = new System.Drawing.Point(15, 25);
            this.dataGridViewCompanies.Name = "dataGridViewCompanies";
            this.dataGridViewCompanies.Size = new System.Drawing.Size(286, 200);
            this.dataGridViewCompanies.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Applicants";
            // 
            // Companies_Applicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCompanies);
            this.Controls.Add(this.dataGridViewApplicants);
            this.Controls.Add(this.label1);
            this.Name = "Companies_Applicants";
            this.Text = "Companies_Applicants";
            this.Load += new System.EventHandler(this.Companies_Applicants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewApplicants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCompanies;
        private System.Windows.Forms.Label label2;
    }
}