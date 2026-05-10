namespace CSCI_463_ODMS_Project
{
    partial class InventoryPage
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
            this.medicationSearchBox = new System.Windows.Forms.TextBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.grpAddInventory = new System.Windows.Forms.GroupBox();
            this.comboBoxMedication = new System.Windows.Forms.ComboBox();
            this.nmbrMedicationInventory = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblMeds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.grpAddInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMedicationInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // medicationSearchBox
            // 
            this.medicationSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicationSearchBox.Location = new System.Drawing.Point(22, 343);
            this.medicationSearchBox.Name = "medicationSearchBox";
            this.medicationSearchBox.Size = new System.Drawing.Size(204, 26);
            this.medicationSearchBox.TabIndex = 9;
            this.medicationSearchBox.TextChanged += new System.EventHandler(this.medicationSearchBox_TextChanged);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(18, 309);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(145, 20);
            this.lblHistory.TabIndex = 6;
            this.lblHistory.Text = "Search Medication:";
            // 
            // dgvMedications
            // 
            this.dgvMedications.AllowUserToAddRows = false;
            this.dgvMedications.AllowUserToDeleteRows = false;
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.Location = new System.Drawing.Point(22, 375);
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.ReadOnly = true;
            this.dgvMedications.RowHeadersWidth = 62;
            this.dgvMedications.Size = new System.Drawing.Size(960, 290);
            this.dgvMedications.TabIndex = 8;
            // 
            // grpAddInventory
            // 
            this.grpAddInventory.Controls.Add(this.comboBoxMedication);
            this.grpAddInventory.Controls.Add(this.nmbrMedicationInventory);
            this.grpAddInventory.Controls.Add(this.btnSubmit);
            this.grpAddInventory.Controls.Add(this.lblInventory);
            this.grpAddInventory.Controls.Add(this.lblMeds);
            this.grpAddInventory.Location = new System.Drawing.Point(22, 34);
            this.grpAddInventory.Name = "grpAddInventory";
            this.grpAddInventory.Size = new System.Drawing.Size(960, 163);
            this.grpAddInventory.TabIndex = 10;
            this.grpAddInventory.TabStop = false;
            this.grpAddInventory.Text = "Add Inventory";
            // 
            // comboBoxMedication
            // 
            this.comboBoxMedication.FormattingEnabled = true;
            this.comboBoxMedication.Location = new System.Drawing.Point(181, 38);
            this.comboBoxMedication.Name = "comboBoxMedication";
            this.comboBoxMedication.Size = new System.Drawing.Size(300, 28);
            this.comboBoxMedication.TabIndex = 11;
            // 
            // nmbrMedicationInventory
            // 
            this.nmbrMedicationInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmbrMedicationInventory.Location = new System.Drawing.Point(181, 75);
            this.nmbrMedicationInventory.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbrMedicationInventory.Name = "nmbrMedicationInventory";
            this.nmbrMedicationInventory.Size = new System.Drawing.Size(300, 26);
            this.nmbrMedicationInventory.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(24, 117);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Add Inventory";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(20, 81);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(127, 20);
            this.lblInventory.TabIndex = 6;
            this.lblInventory.Text = "Inventory to add:";
            // 
            // lblMeds
            // 
            this.lblMeds.AutoSize = true;
            this.lblMeds.Location = new System.Drawing.Point(20, 38);
            this.lblMeds.Name = "lblMeds";
            this.lblMeds.Size = new System.Drawing.Size(136, 20);
            this.lblMeds.TabIndex = 8;
            this.lblMeds.Text = "Medication Name:";
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpAddInventory);
            this.Controls.Add(this.medicationSearchBox);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dgvMedications);
            this.Name = "InventoryPage";
            this.Size = new System.Drawing.Size(1000, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.grpAddInventory.ResumeLayout(false);
            this.grpAddInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMedicationInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox medicationSearchBox;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.GroupBox grpAddInventory;
        private System.Windows.Forms.ComboBox comboBoxMedication;
        private System.Windows.Forms.NumericUpDown nmbrMedicationInventory;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblMeds;
    }
}
