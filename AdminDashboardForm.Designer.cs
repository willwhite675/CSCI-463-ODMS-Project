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
            this.contentPanel = new System.Windows.Forms.Panel();
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
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1000, 692);
            this.contentPanel.TabIndex = 2;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navigationSidebar1);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private navigationSidebar navigationSidebar1;
        private System.Windows.Forms.Panel contentPanel;
    }
}
