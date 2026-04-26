namespace CSCI_463_ODMS_Project
{
    partial class DoctorDashboardForm
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
            this.navigationSidebar1 = new CSCI_463_ODMS_Project.navigationSidebar();
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
            // DoctorDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.navigationSidebar1);
            this.Name = "DoctorDashboardForm";
            this.Text = "DoctorDashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private navigationSidebar navigationSidebar1;
    }
}