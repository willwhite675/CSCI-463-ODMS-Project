namespace CSCI_463_ODMS_Project
{
    partial class navigationSidebar
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
            this.alertNavButton = new System.Windows.Forms.Button();
            this.profileNavButton = new System.Windows.Forms.Button();
            this.logoutNavButton = new System.Windows.Forms.Button();
            this.medicationSearchNavButton = new System.Windows.Forms.Button();
            this.patientSearchNavButton = new System.Windows.Forms.Button();
            this.inventoryNavButton = new System.Windows.Forms.Button();
            this.auditNavButton = new System.Windows.Forms.Button();
            this.userManagementNavButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.userManagementNavButton);
            this.panel1.Controls.Add(this.auditNavButton);
            this.panel1.Controls.Add(this.inventoryNavButton);
            this.panel1.Controls.Add(this.alertNavButton);
            this.panel1.Controls.Add(this.profileNavButton);
            this.panel1.Controls.Add(this.logoutNavButton);
            this.panel1.Controls.Add(this.medicationSearchNavButton);
            this.panel1.Controls.Add(this.patientSearchNavButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // alertNavButton
            // 
            this.alertNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertNavButton.Location = new System.Drawing.Point(0, 140);
            this.alertNavButton.Name = "alertNavButton";
            this.alertNavButton.Size = new System.Drawing.Size(200, 70);
            this.alertNavButton.TabIndex = 4;
            this.alertNavButton.Text = "Alerts";
            this.alertNavButton.UseVisualStyleBackColor = true;
            // 
            // profileNavButton
            // 
            this.profileNavButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profileNavButton.Location = new System.Drawing.Point(0, 460);
            this.profileNavButton.Name = "profileNavButton";
            this.profileNavButton.Size = new System.Drawing.Size(200, 70);
            this.profileNavButton.TabIndex = 3;
            this.profileNavButton.Text = "Profile";
            this.profileNavButton.UseVisualStyleBackColor = true;
            // 
            // logoutNavButton
            // 
            this.logoutNavButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutNavButton.Location = new System.Drawing.Point(0, 530);
            this.logoutNavButton.Name = "logoutNavButton";
            this.logoutNavButton.Size = new System.Drawing.Size(200, 70);
            this.logoutNavButton.TabIndex = 2;
            this.logoutNavButton.Text = "Logout";
            this.logoutNavButton.UseVisualStyleBackColor = true;
            // 
            // medicationSearchNavButton
            // 
            this.medicationSearchNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.medicationSearchNavButton.Location = new System.Drawing.Point(0, 70);
            this.medicationSearchNavButton.Name = "medicationSearchNavButton";
            this.medicationSearchNavButton.Size = new System.Drawing.Size(200, 70);
            this.medicationSearchNavButton.TabIndex = 1;
            this.medicationSearchNavButton.Text = "Medication Search";
            this.medicationSearchNavButton.UseVisualStyleBackColor = true;
            // 
            // patientSearchNavButton
            // 
            this.patientSearchNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientSearchNavButton.Location = new System.Drawing.Point(0, 0);
            this.patientSearchNavButton.Name = "patientSearchNavButton";
            this.patientSearchNavButton.Size = new System.Drawing.Size(200, 70);
            this.patientSearchNavButton.TabIndex = 0;
            this.patientSearchNavButton.Text = "Patient Search";
            this.patientSearchNavButton.UseVisualStyleBackColor = true;
            // 
            // inventoryNavButton
            // 
            this.inventoryNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryNavButton.Location = new System.Drawing.Point(0, 210);
            this.inventoryNavButton.Name = "inventoryNavButton";
            this.inventoryNavButton.Size = new System.Drawing.Size(200, 70);
            this.inventoryNavButton.TabIndex = 5;
            this.inventoryNavButton.Text = "Inventory";
            this.inventoryNavButton.UseVisualStyleBackColor = true;
            // 
            // auditNavButton
            // 
            this.auditNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.auditNavButton.Location = new System.Drawing.Point(0, 280);
            this.auditNavButton.Name = "auditNavButton";
            this.auditNavButton.Size = new System.Drawing.Size(200, 70);
            this.auditNavButton.TabIndex = 6;
            this.auditNavButton.Text = "Audit";
            this.auditNavButton.UseVisualStyleBackColor = true;
            // 
            // userManagementNavButton
            // 
            this.userManagementNavButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userManagementNavButton.Location = new System.Drawing.Point(0, 350);
            this.userManagementNavButton.Name = "userManagementNavButton";
            this.userManagementNavButton.Size = new System.Drawing.Size(200, 70);
            this.userManagementNavButton.TabIndex = 7;
            this.userManagementNavButton.Text = "User Management";
            this.userManagementNavButton.UseVisualStyleBackColor = true;
            // 
            // navigationSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "navigationSidebar";
            this.Size = new System.Drawing.Size(200, 600);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button patientSearchNavButton;
        public System.Windows.Forms.Button logoutNavButton;
        public System.Windows.Forms.Button medicationSearchNavButton;
        public System.Windows.Forms.Button profileNavButton;
        public System.Windows.Forms.Button alertNavButton;
        public System.Windows.Forms.Button inventoryNavButton;
        public System.Windows.Forms.Button userManagementNavButton;
        public System.Windows.Forms.Button auditNavButton;
    }
}
