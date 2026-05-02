using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class navigationSidebar : UserControl
    {
        public event EventHandler LogoutRequested;

        public navigationSidebar()
        {
            InitializeComponent();
        }

        private void logoutNavButton_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
        public void SetupRoleBasedNavigation(string role)
        {
            patientSearchNavButton.Visible = false;
            medicationSearchNavButton.Visible = false;
            alertNavButton.Visible = false;
            inventoryNavButton.Visible = false;
            userManagementNavButton.Visible = false;
            auditNavButton.Visible = false;

            switch (role)
            {
                case "Doctor":
                    patientSearchNavButton.Visible = true;
                    medicationSearchNavButton.Visible = true;
                    alertNavButton.Visible = true;
                    break;

                case "Nurse":
                    patientSearchNavButton.Visible = true;
                    medicationSearchNavButton.Visible = true;
                    break;

                case "Administrator":
                    inventoryNavButton.Visible = true;
                    userManagementNavButton.Visible = true;
                    auditNavButton.Visible = true;
                    break;
            }

            profileNavButton.Visible = true;
            logoutNavButton.Visible = true;
        }
    }
}