namespace EmployementAgencyProject
{
    partial class ShowJobs
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.Size = new System.Drawing.Size(492, 368);
            this.dataGridViewJobs.TabIndex = 0;
            this.dataGridViewJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellClick);
            // 
            // ShowJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 395);
            this.Controls.Add(this.dataGridViewJobs);
            this.Name = "ShowJobs";
            this.Text = "ShowJobs";
            this.Load += new System.EventHandler(this.ShowJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJobs;
    }
}