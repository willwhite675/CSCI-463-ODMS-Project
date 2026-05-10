namespace CSCI_463_ODMS_Project
{
    partial class auditPage
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
            this.auditSearchBox = new System.Windows.Forms.TextBox();
            this.lblAuditSearch = new System.Windows.Forms.Label();
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // auditSearchBox
            // 
            this.auditSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.auditSearchBox.Location = new System.Drawing.Point(19, 51);
            this.auditSearchBox.Name = "auditSearchBox";
            this.auditSearchBox.Size = new System.Drawing.Size(204, 26);
            this.auditSearchBox.TabIndex = 8;
            this.auditSearchBox.TextChanged += new System.EventHandler(this.auditSearchBox_TextChanged);
            // 
            // lblAuditSearch
            // 
            this.lblAuditSearch.AutoSize = true;
            this.lblAuditSearch.Location = new System.Drawing.Point(15, 17);
            this.lblAuditSearch.Name = "lblAuditSearch";
            this.lblAuditSearch.Size = new System.Drawing.Size(91, 20);
            this.lblAuditSearch.TabIndex = 6;
            this.lblAuditSearch.Text = "Search Log";
            // 
            // dgvAudit
            // 
            this.dgvAudit.AllowUserToAddRows = false;
            this.dgvAudit.AllowUserToDeleteRows = false;
            this.dgvAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit.Location = new System.Drawing.Point(19, 83);
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.ReadOnly = true;
            this.dgvAudit.RowHeadersWidth = 62;
            this.dgvAudit.Size = new System.Drawing.Size(960, 590);
            this.dgvAudit.TabIndex = 7;
            // 
            // auditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.auditSearchBox);
            this.Controls.Add(this.lblAuditSearch);
            this.Controls.Add(this.dgvAudit);
            this.Name = "auditPage";
            this.Size = new System.Drawing.Size(1000, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox auditSearchBox;
        private System.Windows.Forms.Label lblAuditSearch;
        private System.Windows.Forms.DataGridView dgvAudit;
    }
}
