namespace CSCI_463_ODMS_Project
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.navigationSidebar1 = new CSCI_463_ODMS_Project.navigationSidebar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.recentAlerts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentAlerts)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationSidebar1
            // 
            this.navigationSidebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationSidebar1.Location = new System.Drawing.Point(0, 0);
            this.navigationSidebar1.Name = "navigationSidebar1";
            this.navigationSidebar1.Size = new System.Drawing.Size(200, 692);
            this.navigationSidebar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.recentAlerts);
            this.panel1.Location = new System.Drawing.Point(251, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 301);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recent Alerts";
            // 
            // recentAlerts
            // 
            this.recentAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recentAlerts.Location = new System.Drawing.Point(-1, 32);
            this.recentAlerts.Name = "recentAlerts";
            this.recentAlerts.RowHeadersWidth = 62;
            this.recentAlerts.RowTemplate.Height = 28;
            this.recentAlerts.Size = new System.Drawing.Size(901, 268);
            this.recentAlerts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the ODMS Admin Dashboard";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigationSidebar1);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentAlerts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private navigationSidebar navigationSidebar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView recentAlerts;
        private System.Windows.Forms.Label label1;
    }
}
