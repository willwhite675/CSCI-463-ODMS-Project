namespace CSCI_463_ODMS_Project
{
    partial class medicationSearch
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
            this.lblHistory = new System.Windows.Forms.Label();
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.medicationSearchBox = new System.Windows.Forms.TextBox();
            this.grpAddMedication = new System.Windows.Forms.GroupBox();
            this.nmbrMaxDosage = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.lblDosage = new System.Windows.Forms.Label();
            this.txtMeds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.grpAddMedication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMaxDosage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(16, 303);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(145, 20);
            this.lblHistory.TabIndex = 2;
            this.lblHistory.Text = "Search Medication:";
            // 
            // dgvMedications
            // 
            this.dgvMedications.AllowUserToAddRows = false;
            this.dgvMedications.AllowUserToDeleteRows = false;
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.Location = new System.Drawing.Point(20, 369);
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.ReadOnly = true;
            this.dgvMedications.RowHeadersWidth = 62;
            this.dgvMedications.Size = new System.Drawing.Size(960, 290);
            this.dgvMedications.TabIndex = 4;
            // 
            // medicationSearchBox
            // 
            this.medicationSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicationSearchBox.Location = new System.Drawing.Point(20, 337);
            this.medicationSearchBox.Name = "medicationSearchBox";
            this.medicationSearchBox.Size = new System.Drawing.Size(204, 26);
            this.medicationSearchBox.TabIndex = 5;
            this.medicationSearchBox.TextChanged += new System.EventHandler(this.medicationSearchBox_TextChanged);
            // 
            // grpAddMedication
            // 
            this.grpAddMedication.Controls.Add(this.nmbrMaxDosage);
            this.grpAddMedication.Controls.Add(this.submit);
            this.grpAddMedication.Controls.Add(this.lblDosage);
            this.grpAddMedication.Controls.Add(this.txtMeds);
            this.grpAddMedication.Controls.Add(this.label1);
            this.grpAddMedication.Location = new System.Drawing.Point(20, 33);
            this.grpAddMedication.Name = "grpAddMedication";
            this.grpAddMedication.Size = new System.Drawing.Size(960, 163);
            this.grpAddMedication.TabIndex = 8;
            this.grpAddMedication.TabStop = false;
            this.grpAddMedication.Text = "Add New Medication";
            // 
            // nmbrMaxDosage
            // 
            this.nmbrMaxDosage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmbrMaxDosage.Location = new System.Drawing.Point(181, 75);
            this.nmbrMaxDosage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbrMaxDosage.Name = "nmbrMaxDosage";
            this.nmbrMaxDosage.Size = new System.Drawing.Size(300, 26);
            this.nmbrMaxDosage.TabIndex = 9;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(24, 117);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(180, 30);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit Medication";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Location = new System.Drawing.Point(20, 81);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(102, 20);
            this.lblDosage.TabIndex = 6;
            this.lblDosage.Text = "Max Dosage:";
            // 
            // txtMeds
            // 
            this.txtMeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMeds.Location = new System.Drawing.Point(181, 38);
            this.txtMeds.Name = "txtMeds";
            this.txtMeds.Size = new System.Drawing.Size(300, 26);
            this.txtMeds.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Medication Name:";
            // 
            // medicationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpAddMedication);
            this.Controls.Add(this.medicationSearchBox);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dgvMedications);
            this.Name = "medicationSearch";
            this.Size = new System.Drawing.Size(1000, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.grpAddMedication.ResumeLayout(false);
            this.grpAddMedication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMaxDosage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.TextBox medicationSearchBox;
        private System.Windows.Forms.GroupBox grpAddMedication;
        private System.Windows.Forms.NumericUpDown nmbrMaxDosage;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.TextBox txtMeds;
        private System.Windows.Forms.Label label1;
    }
}
