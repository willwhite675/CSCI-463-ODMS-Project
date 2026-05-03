namespace CSCI_463_ODMS_Project
{
    partial class PrescriptionForm : System.Windows.Forms.UserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpNewPrescription = new System.Windows.Forms.GroupBox();
            this.nmbrDosage = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblDosage = new System.Windows.Forms.Label();
            this.lblMedication = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.comboBoxMedication = new System.Windows.Forms.ComboBox();
            this.grpNewPrescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrDosage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewPrescription
            // 
            this.grpNewPrescription.BackColor = System.Drawing.Color.Transparent;
            this.grpNewPrescription.Controls.Add(this.comboBoxMedication);
            this.grpNewPrescription.Controls.Add(this.nmbrDosage);
            this.grpNewPrescription.Controls.Add(this.btnSubmit);
            this.grpNewPrescription.Controls.Add(this.txtInstructions);
            this.grpNewPrescription.Controls.Add(this.lblInstructions);
            this.grpNewPrescription.Controls.Add(this.lblDosage);
            this.grpNewPrescription.Controls.Add(this.lblMedication);
            this.grpNewPrescription.Controls.Add(this.txtPatient);
            this.grpNewPrescription.Controls.Add(this.lblPatient);
            this.grpNewPrescription.Location = new System.Drawing.Point(12, 12);
            this.grpNewPrescription.Name = "grpNewPrescription";
            this.grpNewPrescription.Size = new System.Drawing.Size(960, 295);
            this.grpNewPrescription.TabIndex = 0;
            this.grpNewPrescription.TabStop = false;
            this.grpNewPrescription.Text = "Write New Prescription";
            // 
            // nmbrDosage
            // 
            this.nmbrDosage.Location = new System.Drawing.Point(160, 122);
            this.nmbrDosage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbrDosage.Name = "nmbrDosage";
            this.nmbrDosage.Size = new System.Drawing.Size(300, 26);
            this.nmbrDosage.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(160, 255);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Prescription";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstructions.Location = new System.Drawing.Point(160, 161);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(300, 80);
            this.txtInstructions.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(20, 164);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(96, 20);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Instructions:";
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Location = new System.Drawing.Point(20, 122);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(69, 20);
            this.lblDosage.TabIndex = 6;
            this.lblDosage.Text = "Dosage:";
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Location = new System.Drawing.Point(20, 80);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(90, 20);
            this.lblMedication.TabIndex = 7;
            this.lblMedication.Text = "Medication:";
            // 
            // txtPatient
            // 
            this.txtPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatient.Location = new System.Drawing.Point(160, 35);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(300, 26);
            this.txtPatient.TabIndex = 0;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(20, 38);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(109, 20);
            this.lblPatient.TabIndex = 8;
            this.lblPatient.Text = "Patient Name:";
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(12, 322);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(142, 20);
            this.lblHistory.TabIndex = 0;
            this.lblHistory.Text = "Your Prescriptions:";
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.AllowUserToAddRows = false;
            this.dgvPrescriptions.AllowUserToDeleteRows = false;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.Location = new System.Drawing.Point(12, 348);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.ReadOnly = true;
            this.dgvPrescriptions.RowHeadersWidth = 62;
            this.dgvPrescriptions.Size = new System.Drawing.Size(960, 290);
            this.dgvPrescriptions.TabIndex = 1;
            // 
            // comboBoxMedication
            // 
            this.comboBoxMedication.FormattingEnabled = true;
            this.comboBoxMedication.Location = new System.Drawing.Point(160, 77);
            this.comboBoxMedication.Name = "comboBoxMedication";
            this.comboBoxMedication.Size = new System.Drawing.Size(300, 28);
            this.comboBoxMedication.TabIndex = 10;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dgvPrescriptions);
            this.Controls.Add(this.grpNewPrescription);
            this.Name = "PrescriptionForm";
            this.Size = new System.Drawing.Size(1408, 778);
            this.grpNewPrescription.ResumeLayout(false);
            this.grpNewPrescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrDosage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewPrescription;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.NumericUpDown nmbrDosage;
        private System.Windows.Forms.ComboBox comboBoxMedication;
    }
}
