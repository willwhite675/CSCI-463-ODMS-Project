namespace CSCI_463_ODMS_Project
{
    partial class mainDoctorPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecentHeader = new System.Windows.Forms.Label();
            this.recentPrescriptions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblRecentHeader);
            this.panel1.Controls.Add(this.recentPrescriptions);
            this.panel1.Location = new System.Drawing.Point(16, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 301);
            this.panel1.TabIndex = 1;
            // 
            // lblRecentHeader
            // 
            this.lblRecentHeader.AutoSize = true;
            this.lblRecentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentHeader.Location = new System.Drawing.Point(369, 0);
            this.lblRecentHeader.Name = "lblRecentHeader";
            this.lblRecentHeader.Size = new System.Drawing.Size(236, 29);
            this.lblRecentHeader.TabIndex = 1;
            this.lblRecentHeader.Text = "Recent Prescriptions";
            // 
            // recentPrescriptions
            // 
            this.recentPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recentPrescriptions.Location = new System.Drawing.Point(-1, 32);
            this.recentPrescriptions.Name = "recentPrescriptions";
            this.recentPrescriptions.RowHeadersWidth = 62;
            this.recentPrescriptions.RowTemplate.Height = 28;
            this.recentPrescriptions.Size = new System.Drawing.Size(963, 268);
            this.recentPrescriptions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the ODMS Doctor Dashboard";
            // 
            // mainDoctorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "mainDoctorPage";
            this.Size = new System.Drawing.Size(1000, 692);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecentHeader;
        private System.Windows.Forms.DataGridView recentPrescriptions;
        private System.Windows.Forms.Label label1;
    }
}
