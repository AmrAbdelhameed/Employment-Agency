namespace EmployementAgencyProject
{
    partial class Admin_Add_Field
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
            this.lab_name = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(129, 95);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(60, 13);
            this.lab_name.TabIndex = 113;
            this.lab_name.Text = "Field Name";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(197, 92);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(121, 20);
            this.txtFieldName.TabIndex = 112;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 114;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Admin_Add_Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 353);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.txtFieldName);
            this.Name = "Admin_Add_Field";
            this.Text = "Admin_Add_Field";
            this.Load += new System.EventHandler(this.Admin_Add_Field_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Button btnSave;

    }
}