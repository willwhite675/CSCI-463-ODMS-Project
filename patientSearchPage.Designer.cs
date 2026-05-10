namespace CSCI_463_ODMS_Project
{
    partial class patientSearchPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientSearchBox = new System.Windows.Forms.TextBox();
            this.lblPatientSearch = new System.Windows.Forms.Label();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // patientSearchBox
            // 
            this.patientSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientSearchBox.Location = new System.Drawing.Point(22, 52);
            this.patientSearchBox.Name = "patientSearchBox";
            this.patientSearchBox.Size = new System.Drawing.Size(204, 26);
            this.patientSearchBox.TabIndex = 11;
            this.patientSearchBox.TextChanged += new System.EventHandler(this.patientSearchBox_TextChanged);
            // 
            // lblPatientSearch
            // 
            this.lblPatientSearch.AutoSize = true;
            this.lblPatientSearch.Location = new System.Drawing.Point(18, 18);
            this.lblPatientSearch.Name = "lblPatientSearch";
            this.lblPatientSearch.Size = new System.Drawing.Size(114, 20);
            this.lblPatientSearch.TabIndex = 9;
            this.lblPatientSearch.Text = "Patient Search";
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(22, 84);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersWidth = 62;
            this.dgvPatient.Size = new System.Drawing.Size(960, 590);
            this.dgvPatient.TabIndex = 10;
            // 
            // patientSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientSearchBox);
            this.Controls.Add(this.lblPatientSearch);
            this.Controls.Add(this.dgvPatient);
            this.Name = "patientSearchPage";
            this.Size = new System.Drawing.Size(1000, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patientSearchBox;
        private System.Windows.Forms.Label lblPatientSearch;
        private System.Windows.Forms.DataGridView dgvPatient;
    }
}
