namespace EmployementAgencyProject
{
    partial class Applicants_Jobs
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
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboFields = new System.Windows.Forms.ComboBox();
            this.comboCompanies = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.Size = new System.Drawing.Size(550, 281);
            this.dataGridViewJobs.TabIndex = 14;
            this.dataGridViewJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(438, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboFields
            // 
            this.comboFields.FormattingEnabled = true;
            this.comboFields.Location = new System.Drawing.Point(268, 40);
            this.comboFields.Name = "comboFields";
            this.comboFields.Size = new System.Drawing.Size(121, 21);
            this.comboFields.TabIndex = 12;
            // 
            // comboCompanies
            // 
            this.comboCompanies.FormattingEnabled = true;
            this.comboCompanies.Location = new System.Drawing.Point(113, 40);
            this.comboCompanies.Name = "comboCompanies";
            this.comboCompanies.Size = new System.Drawing.Size(121, 21);
            this.comboCompanies.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search by Field name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search by Company name";
            // 
            // Applicants_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 391);
            this.Controls.Add(this.dataGridViewJobs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboFields);
            this.Controls.Add(this.comboCompanies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Applicants_Jobs";
            this.Text = "Applicants_Jobs";
            this.Load += new System.EventHandler(this.Applicants_Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboFields;
        private System.Windows.Forms.ComboBox comboCompanies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}