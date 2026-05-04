namespace CSCI_463_ODMS_Project
{
    partial class mainNursePage
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
            this.lblExpirationHeader = new System.Windows.Forms.Label();
            this.upcomingExpirations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingExpirations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblExpirationHeader);
            this.panel1.Controls.Add(this.upcomingExpirations);
            this.panel1.Location = new System.Drawing.Point(15, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 301);
            this.panel1.TabIndex = 3;
            // 
            // lblExpirationHeader
            // 
            this.lblExpirationHeader.AutoSize = true;
            this.lblExpirationHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationHeader.Location = new System.Drawing.Point(369, 0);
            this.lblExpirationHeader.Name = "lblExpirationHeader";
            this.lblExpirationHeader.Size = new System.Drawing.Size(248, 29);
            this.lblExpirationHeader.TabIndex = 1;
            this.lblExpirationHeader.Text = "Upcoming Expirations";
            // 
            // upcomingExpirations
            // 
            this.upcomingExpirations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcomingExpirations.Location = new System.Drawing.Point(-1, 32);
            this.upcomingExpirations.Name = "upcomingExpirations";
            this.upcomingExpirations.RowHeadersWidth = 62;
            this.upcomingExpirations.RowTemplate.Height = 28;
            this.upcomingExpirations.Size = new System.Drawing.Size(963, 268);
            this.upcomingExpirations.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to the ODMS Nurse Dashboard";
            // 
            // mainNursePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "mainNursePage";
            this.Size = new System.Drawing.Size(1000, 692);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingExpirations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExpirationHeader;
        private System.Windows.Forms.DataGridView upcomingExpirations;
        private System.Windows.Forms.Label label1;
    }
}
