namespace EmployementAgencyProject
{
    partial class ShowFields
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
            this.dataGridViewFields = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFields
            // 
            this.dataGridViewFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFields.Location = new System.Drawing.Point(12, 24);
            this.dataGridViewFields.Name = "dataGridViewFields";
            this.dataGridViewFields.Size = new System.Drawing.Size(282, 343);
            this.dataGridViewFields.TabIndex = 0;
            this.dataGridViewFields.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFields_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(346, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Updates";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ShowFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 433);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewFields);
            this.Name = "ShowFields";
            this.Text = "ShowFields";
            this.Load += new System.EventHandler(this.ShowFields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFields;
        private System.Windows.Forms.Button btnSave;
    }
}