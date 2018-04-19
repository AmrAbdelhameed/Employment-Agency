namespace EmployementAgencyProject
{
    partial class ShowCompanies
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
            this.dataGridViewCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompanies
            // 
            this.dataGridViewCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanies.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewCompanies.Name = "dataGridViewCompanies";
            this.dataGridViewCompanies.Size = new System.Drawing.Size(570, 309);
            this.dataGridViewCompanies.TabIndex = 0;
            this.dataGridViewCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompanies_CellClick);
            // 
            // ShowCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 420);
            this.Controls.Add(this.dataGridViewCompanies);
            this.Name = "ShowCompanies";
            this.Text = "ShowCompanies";
            this.Load += new System.EventHandler(this.ShowCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompanies;
    }
}